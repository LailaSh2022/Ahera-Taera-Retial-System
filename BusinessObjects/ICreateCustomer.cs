using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.Interfaces
{
	public interface ICreateCustomer 
	{
		bool CreateNew_Customer(string firstName, string lastName, DateTime dateOfBirth,
			string email, string phoneNumber, string address, string suburb, string zipCode, string city,
			string username, string password);
	}
}
