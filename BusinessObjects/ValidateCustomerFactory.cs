using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.Interfaces
{
	public abstract class ValidateCustomerFactory
	{
		protected abstract IValidateCustomer MakeCustomerInstance();
		public IValidateCustomer CreateCustomerInst()
		{
			return this.MakeCustomerInstance();
		}
	
	}
}
