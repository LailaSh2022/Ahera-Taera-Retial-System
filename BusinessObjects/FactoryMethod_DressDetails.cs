using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_DressDetails : DressDetailsFactory
	{
		protected override IDressDetails MakeProductDetailsInstance()
		{
			IDressDetails DressDetails_Obj = new DressDetails();
			return DressDetails_Obj;
		}
	}
}
