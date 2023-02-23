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
	class Order : IOrder
	{
		public DataTable GetCustomerDetails(int customerId)			// Get the date of birth and city to apply the needed discounts
		{
			string sqlQuiry = "select [CU_Date_of_Birth],[CU_City]from [dbo].[Customers] where [CU_Id] =" + customerId;
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			return dt;           // Return the data set
		}

		public double getDiscount(DataTable dTable)			// Apply the needed discounts
		{
			double totalDiscount = 0, seniorDiscount = 10, weekendDiscount = 2, cityDiscount = 1;
			DateTime dateOfBirth;
			string city = "";
			int age = 0;
			foreach (DataRow dr in dTable.Rows)
			{
				dateOfBirth = Convert.ToDateTime(dr["CU_Date_of_Birth"]);
				age = DateTime.Now.Year - dateOfBirth.Year;             // Get age from date of birth.
				city = dr["CU_City"].ToString();
			}
			if (age > 60)               // Check age discount.
			{
				totalDiscount += seniorDiscount;
			}
			if ((city.ToUpper() == "AUCKLAND") || (city.ToUpper() == "WELLINGTON")) //Check city dicount. 
			{
				totalDiscount += cityDiscount;
			}
			if ((DateTime.Now.DayOfWeek == DayOfWeek.Saturday) || (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)) // Check weekend discount.
				totalDiscount += weekendDiscount;
			return totalDiscount;       //Return total discount.
		}

		public double getSubTotal(DataTable dTable)			// Calculate the sub total.
		{
			double subTotal = 0, itemPrice = 0, price, quantity;
			foreach (DataRow dr in dTable.Rows)
			{
				price = Convert.ToDouble(dr["PR_Price"]);
				quantity = Convert.ToDouble(dr["Quantitiy"]);
				itemPrice = price * quantity;
				subTotal += itemPrice;
			}
			return subTotal;
		}

		public bool addOrder(int customerId, double subTotal, int quantity, double delivary,double discount,double totalPrice) // Insert new Order
		{
			string sqlQuiry = "insert into [dbo].[Order] values(" + 
				customerId + "," + quantity + "," + subTotal +","+ delivary +","+discount+","+
				totalPrice+",'"+ DateTime.Now.ToString("yyyy-MM-dd")+"','Unpaid','N')";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.

		}

		public DataTable GetOrderDetails(int customerId)		// To retun data table for given parameters
		{
			
			string sqlQuiry = "";
			if (customerId == -1)			// Admin side.		add type "Or" for order and "PM" for payment 
			{
		
					sqlQuiry = "select DISTINCT [OR_Id],[dbo].[Order].[CU_Id]," +
					"([dbo].[Customers].[CU_First_Name] + ' ' + [dbo].[Customers].[CU_Last_Name]) as Customer_Name," +
					"[Quantity],[Price],[Delivary],[Discount],[Total_Price],[OR_Issue_Date],[Status] from[dbo].[Order]" +
					" INNER JOIN[dbo].[Customers] On[dbo].[Order].CU_Id = [dbo].[Customers].CU_Id AND [dbo].[Order].OR_Deleted = 'N'";
				
				
			}

			else                           // Returns unpaid order for given customer
			{
				 sqlQuiry = "select [OR_Id],[Quantity],[Price],[Delivary],[Discount]," +
								"[Total_Price],[OR_Issue_Date] from [dbo].[Order] where [CU_Id] =" + customerId + " And status = 'Unpaid' And OR_Deleted = 'N'";
			}
			
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			return dt;           // Return the data set
		}

		public bool PlacePayment(string orderId, double total, string provider)		// After payment --> Generate the payment bill. 
		{
				string sqlQuiry = "insert into [dbo].[Payment_Bill] values(" + orderId + "," + total + ",'" +
				provider + "','Paid','" + DateTime.Now.ToString("yyyy-MM-dd") + "','N')";
						
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}

		public bool UpdateOrderStatus(string orderId,string status)       // After payment --> update status to paid in Order table
		{
			string	sqlQuiry = "update [dbo].[Order] set [Status]='"+status+"' where [OR_Id] = " + orderId;
			
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;
		}

		public double getTotal(double subTotal, double delivery, double discount)
		{
			double total= (subTotal + delivery) - ((subTotal + delivery) * discount) / 100;    // Calculate  total.
			return total;
		}
		public bool updateProductStock(DataTable dt)
		{
			bool updatedRecord = false;
			foreach (DataRow dr in dt.Rows)
			{
				int productStock, availableStock = Convert.ToInt32(dr["PR_Stock_Qantity"]);
				int quantitiy = Convert.ToInt32(dr["Quantitiy"]);
				int productId = Convert.ToInt32(dr["PR_Id"]);
				if (availableStock != 0)
				{
					if (availableStock > quantitiy)
					{
						productStock = availableStock - quantitiy;      // Get new product stock
						string sqlQuiry = "update [dbo].[Products] set [PR_Stock_Qantity]= " + productStock + " where [PR_Id] = " + productId;  // Update product stock.
						DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
						databaseConnection.Open();
						int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
						databaseConnection.Close();
						if (result > 0)
							updatedRecord = true;            // Insert new record.
						else
							updatedRecord = false;
					}
					else
					{
						MessageBox.Show("Sorry! Not enough stock for product number " + productId, "Product Stock");
						updatedRecord = false;
					}
				}
				else
				{
					MessageBox.Show("Sorry! Out of stock for product number " + productId, "Product Stock");
					updatedRecord = false;
				}
			}
			return updatedRecord;
		}

		public bool updateOrder(int orderId, int customerId, double subTotal, int quantity, 
								double delivary, double discount, double totalPrice, string status)  // Update order.
		{
			string sqlQuiry;
			if (customerId == -1)		// Update the order from the Admin side
			{
				sqlQuiry = "update [dbo].[Order] set [Price] = " + subTotal +
				", [Delivary] = " + delivary + ", [Discount] = " + discount + ", [Total_Price] = " +
				totalPrice + ",[Status] = '"+ status + "' where [OR_Id] = " + orderId;
			}
			else
			{
				sqlQuiry = "update [dbo].[Order] set [Quantity] = " + quantity + ", [Price] = " + subTotal +
								", [Delivary] = " + delivary + ", [Discount] = " + discount + ", [Total_Price] = " +
								totalPrice + ",[OR_Issue_Date] = '" + DateTime.Now.ToString("yyyy-MM-dd") + "',[Status] = 'Unpaid'" +
								" where [OR_Id] = " + orderId;
			}
			
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;
		}
		public bool deleteOrder(string orderId)       // Delete Order
		{
			string sqlQuiry = "update [dbo].[Order] set [OR_Deleted]='Y' where [OR_Id] = " + orderId;

			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;
		}
	}

}
