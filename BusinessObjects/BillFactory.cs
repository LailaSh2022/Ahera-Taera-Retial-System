using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public abstract class BillFactory
	{
		protected abstract IBill MakeBillInstance();
		public IBill CreateBillInstance()
		{
			return this.MakeBillInstance();
		}
	}
}
