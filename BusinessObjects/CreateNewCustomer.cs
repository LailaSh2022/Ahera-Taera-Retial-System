using SWD604_Task2_RetialCustomerManagementSystem.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.Interfaces
{
	class CreateNewCustomer : Customer, ICreateCustomer
	{
		public bool CreateNew_Customer(string firstName, string lastName, DateTime dateOfBirth,
			string email,string phoneNumber,string address, string suburb, string zipCode,string city,
			string username, string password)
		{
			string sqlQuiry = "insert into [dbo].[Customers] values('" + firstName + "', '" + lastName + "', '" +
			   dateOfBirth.ToString("yyyy-MM-dd") + "','" + email + "','" + phoneNumber + "','" 
			   + address + "','" + suburb + "','" + zipCode + "','" 
			   + city + "','" + username + "','" + password + "','CUS')";
			DatabaseConnection databaseConnection = new DatabaseConnection();
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
	}
}
