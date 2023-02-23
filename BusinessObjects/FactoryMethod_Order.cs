using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_Order : OrderFactory
	{
		protected override IOrder MakeOrderInstance()
		{
			IOrder Order_Obj = new Order();
			return Order_Obj;
		}
	}
}
