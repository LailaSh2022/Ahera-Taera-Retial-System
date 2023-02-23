using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem.DataBase
{
    class DatabaseConnection
    {
        private static string host { get; set; }
        private static string database { get; set; }
        private static string Encrypt { get; set; }
        private static string Certificate { get; set; }
        private static string LoginDB { get; set; }
        private static string Connect { get; set; }
        private static string Access { get; set; }
        private static string Failover { get; set; }
        private static string strProvider { get; set; }
        private static string getHost()
        {
            host = "LAPTOP-Q4ENDLRT\\SQLEXPRESS";
            return host;
        }
        private static string getDatabase()
        {
            database = "RetialDB";
            return database;
        }
        private static string getEncrypt()
        {
            Encrypt = "False";
            return Encrypt;
        }
        private static string getCertificate()
        {
            Certificate = "False";
            return Certificate;
        }
        private static string getLoginDB()
        {
            LoginDB = "True";
            return LoginDB;
        }
        private static string getConnect()
        {
            Connect = "30";
            return Connect;
        }
        private static string getAccess()
        {
            Access = "ReadWrite";
            return Access;
        }
        private static string getFailover()
        {
            Failover = "False";
            return Failover;
        }
        public static string getstrProvider()
        {
            strProvider = "Data Source=" + getHost() + ";Initial Catalog=" + getDatabase() + ";Integrated Security=" + getLoginDB()
            + ";Connect Timeout=" + getConnect() + ";Encrypt=" + getEncrypt() + ";TrustServerCertificate=" + getCertificate()
            + ";ApplicationIntent=" + getAccess() + ";MultiSubnetFailover=" + getFailover();
            return strProvider;
        }
        SqlConnection conn;
        public bool Open()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString());
                sqlConnection.Open();
                conn = new SqlConnection(connectionString());
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
        public string connectionString()
        {
            return getstrProvider();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable ExecuteDataTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int ExecuteReader(string sql)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                string counter ="";
                int result;
                if (reader.HasRows)
                {
                    while (reader.Read())
                        counter = reader[0].ToString();
                    if (Int32.TryParse(counter, out result))
                        return result;
                    else
                        return -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        public int SaveImage_ExecuteNonQuery(string sql, byte[] img)
        {
            try
            {
                int affected;
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@img", img));
                affected = cmd.ExecuteNonQuery();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
