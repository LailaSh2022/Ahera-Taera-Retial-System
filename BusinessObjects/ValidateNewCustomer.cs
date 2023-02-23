using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP4_2.RJControls;
using SWD604_Task2_RetialCustomerManagementSystem.DataBase;

namespace SWD604_Task2_RetialCustomerManagementSystem.Interfaces
{
	class ValidateNewCustomer :  IValidateCustomer 
	{
		public bool ValidateCustomerInput(string username, string password)			// Validate the Username and Password.
		{
			string sqlQuiry = "select * from [dbo].[Customers] where [UserName]='" + username 
				+ "' COLLATE SQL_Latin1_General_CP1_CS_AS and [Password]='" + password + "' COLLATE SQL_Latin1_General_CP1_CS_AS"; 
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteReader(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;			// True if the query retuns record.
			else
				return false;			// False if the query not return record.
		}
		public DataTable SignedCustomerInfo(string username, string password)
		{
			string sqlQuiry = "select * from [dbo].[Customers] where [UserName]='" + username
				+ "' COLLATE SQL_Latin1_General_CP1_CS_AS and [Password]='" + password + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);
			databaseConnection.Close();
			return dt;
		}
	}
}
