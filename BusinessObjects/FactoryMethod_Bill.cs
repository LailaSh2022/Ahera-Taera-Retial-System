using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_Bill : BillFactory
	{
		protected override IBill MakeBillInstance()
		{
			IBill bill_Object = new Bill();
			return bill_Object;
		}
	}
}
