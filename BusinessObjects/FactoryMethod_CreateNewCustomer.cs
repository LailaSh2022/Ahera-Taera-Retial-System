using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_CreateNewCustomer : CreateNewCustomerFactory
	{
		protected override ICreateCustomer CreateNewCustomerInstance()
		{
			ICreateCustomer NewCustomer_Obj = new CreateNewCustomer();
			return NewCustomer_Obj;
		}
	}
}
