using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public abstract class CreateNewCustomerFactory 
	{
		protected abstract ICreateCustomer CreateNewCustomerInstance();
		public ICreateCustomer GetCustomerInst()
		{
			return this.CreateNewCustomerInstance();
		}
	}
}
