using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_ValidateNewCustomer : ValidateCustomerFactory
	{
		protected override IValidateCustomer MakeCustomerInstance()
		{
			IValidateCustomer NewCustomer_Obj = new ValidateNewCustomer();
			return NewCustomer_Obj;
		}
	}
}
