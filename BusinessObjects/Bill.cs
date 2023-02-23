using SWD604_Task2_RetialCustomerManagementSystem.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class Bill : IBill
	{
		public void Feed_BillList(ListView shoppingItems_lst, DataTable dt)		// Display the bill details.
		{
			shoppingItems_lst.View = View.Details;
			shoppingItems_lst.Columns.Add("ID", 50);
			shoppingItems_lst.Columns.Add("Product", 100);
			shoppingItems_lst.Columns.Add("Quantity", 70);
			shoppingItems_lst.Columns.Add("Price", 70);

			foreach (DataRow dr in dt.Rows)
			{
				string id = dr["PR_Id"].ToString();
				string name = dr["PR_Name"].ToString();
				string quantity = dr["Quantitiy"].ToString();
				string price = "$" + dr["PR_Price"].ToString();

				ListViewItem lvi = new ListViewItem(id);

				lvi.SubItems.Add(name);
				lvi.SubItems.Add(quantity);
				lvi.SubItems.Add(price);

				shoppingItems_lst.Items.Add(lvi);

			}
		}

		public DataTable GetProductDetails(int customerId)		// Return the unpaid product's for the given customer.
		{
			string sqlQuiry = "select Products.PR_Id, Products.PR_Name,Products.PR_Price,Products.PR_Discription,Products.PR_Stock_Qantity," +
				"Products.PR_Main_Image,Shopping_Cart.Size,Shopping_Cart.Quantitiy from Products, Shopping_Cart " +
				"where Products.PR_Id = [dbo].[Shopping_Cart].[PR_Id] and[dbo].[Shopping_Cart].[CU_Id] = " + customerId + "And [Status] = 'Unpaid'";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			return dt;           // Return the data table
		}
		public bool deleteSelectedPayment(string paymentId)     // Delete the selected Payment from the grid.
		{
			string sqlQuiry = "update [dbo].[Payment_Bill] set [P_Deleted] = 'Y' where P_Id =" + paymentId ;
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
		public bool UpdateSelectedPayment(string paymentId,string provider, string status)	// Edit the selected Payment from the grid.
		{
			string sqlQuiry = "update [dbo].[Payment_Bill] set [Provider] = '"+ provider + "',[Status]='"+ status + "' where P_Id =" + paymentId; // Update Payment_Bill table.
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
		public bool UpdateTotalPayment(int paymentId,double total)			// Update the total payment if the total order is updated
		{
			string sqlQuiry = "update [dbo].[Payment_Bill] set [Total_Amount] = " + total + " where P_Id =" + paymentId;
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
		public int getPaymentId(string orderId)			// Returns the payment Id for given order Id
		{
			int paymentId = 0;
			string sqlQuiry = "select P_Id from Payment_Bill where OR_Id =" + orderId;
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			paymentId = databaseConnection.ExecuteReader(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			return paymentId;
		}

		public DataTable getPaymentList()
		{
			string sqlQuiry = "select DISTINCT P_Id,Payment_Bill.OR_Id,[Order].[CU_Id]," +
					"([dbo].[Customers].[CU_First_Name] + ' ' + [dbo].[Customers].[CU_Last_Name]) as Customer_Name, Payment_Bill.Total_Amount," +
					" Payment_Bill.Issued_Date,Payment_Bill.[Provider],Payment_Bill.[Status]" +
					" from Payment_Bill,[Order] INNER JOIN[Customers] On [Order].CU_Id = [Customers].CU_Id" +
					" where Payment_Bill.OR_Id = [Order].OR_Id And [P_Deleted] = 'N' ";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			return dt;           // Return the data set
		}
	}
}
