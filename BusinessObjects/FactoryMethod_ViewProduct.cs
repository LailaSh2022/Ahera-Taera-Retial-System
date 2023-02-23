using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_ViewProduct : ViewProductFactory
	{
		protected override IViewProduct CreateViewProductInstant()
		{
			IViewProduct viewProduct_Obj = new ViewProduct();
			return viewProduct_Obj;
		}
	}
}
