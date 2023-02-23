using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public abstract class DressDetailsFactory
	{
		protected abstract IDressDetails MakeProductDetailsInstance();
		public IDressDetails CreateProductDetailsInstance()
		{
			return this.MakeProductDetailsInstance();
		}
	}
}
