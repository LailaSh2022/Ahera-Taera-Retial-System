using SWD604_Task2_RetialCustomerManagementSystem.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class DressDetails :  IDressDetails
	{
		
		public DataTable GetProductDetails(int productId, string user)		// Returns the product details.
		{
			string sqlQuiry;
			if (user == "ADM")          // Admin
			{
				// Select product information relaed to given product Id.
				sqlQuiry = "select Products.PR_Id, Products.PR_Name,Products.PR_Price,Products.PR_Discription, " +  
				"[PR_Stock_Qantity], [PR_Main_Image],[PR_Size] from Products where Products.PR_Id =" + productId;
			}
			else      // Customer     
			{
				// Select product information relaed to given product Id.
				sqlQuiry = "select Products.PR_Id, Products.PR_Name,Products.PR_Price,Products.PR_Discription " +  
				"from Products where Products.PR_Id =" + productId;
			}
			
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			return dt;           // Return the data Table
		}
		public DataTable GetProductImages(int productId)
		{
			string sqlQuiry = "select  Image from Products_Images where PR_Id =" + productId;		// Return product images related to given product Id.
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			return dt;           // Return the data Table
		}
	}
}
