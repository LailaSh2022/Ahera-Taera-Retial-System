using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.Interfaces
{
	public interface IValidateCustomer
	{

		bool ValidateCustomerInput(string username, string password);
		DataTable SignedCustomerInfo(string username, string password);
		
	}
}
