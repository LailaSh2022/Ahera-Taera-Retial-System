using SWD604_Task2_RetialCustomerManagementSystem.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class CreateEditDeleteProduct : ICreateEditDeleteProduct
	{
		public bool DeleteProductFromCart(int productId, int customerId)			// -1 --> means used by the admin.
		{
			string sqlQuiry;
			if (customerId == -1)			// Admin side
			{
				sqlQuiry = "Delete from [dbo].[Products] where [PR_Id] = " + productId;
			}
			else                            // Customer side
			{
				sqlQuiry = "Delete from Shopping_Cart where (PR_Id =" + productId + " and CU_Id =" + customerId + ") and Status = 'Unpaid'";
			}
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
		

		public bool EdiSelectedProductDetails(int productId, int customerId, int quantity, string size)
		{
			string sqlQuiry = "update Shopping_Cart set Quantitiy = "+quantity +", Size='"+ size +"'" +
				" where (PR_Id =" + productId + " and CU_Id =" + customerId + ") and Status = 'Unpaid'";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
		public DataTable getSelectedProductInfo(int productId, int customerId)
		{
			string sqlQuiry = "select * from Shopping_Cart where (PR_Id = " + productId + " and CU_Id = " + customerId + ") and Status = 'Unpaid'";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			return dt;           // Return the data table
		}
		
		public bool AddNewProduct(string name,string description,double price, int stock, string size)
		{
			string sqlQuiry = "insert into [dbo].[Products] values('" + name + "'," + price + ",'" + description + "',"+ stock + ",null,null,'" + size + "')";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
			
		}

		public bool EditProduct(int productId,string name, string description, double price, int stock, string size)
		{
			string sqlQuiry =
				"update [dbo].[Products] set [PR_Stock_Qantity] = " + stock + ", [PR_Size]='" + size + "'" + ", [PR_Name]='" + name + "'"+
				",[PR_Discription] = '"+description+"',[PR_Price]="+ price +" where PR_Id =" + productId ; 
			
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.

		}
		public int getNewCreatedProductId()
		{
			int productId =0;
			string sqlQuiry = "select max(PR_Id) as PR_Id from Products";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			productId = databaseConnection.ExecuteReader(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			return productId;
		}
	}
}
