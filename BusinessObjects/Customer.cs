using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.Interfaces
{
	public class Customer
	{
		public int Id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public DateTime dateOfBirth { get; set; }
		public string Email { get; set; }
		public string phoneNumber { get; set; }
		public string streetAddress { get; set; }
		public string suburb { get; set; }
		public string zipCode { get; set; }
		public string City { get; set; }
		public string username { get; set; }
		public string password { get; set; }

	}
}
