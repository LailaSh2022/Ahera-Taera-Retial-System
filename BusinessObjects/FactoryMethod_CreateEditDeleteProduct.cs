using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_CreateEditDeleteProduct : CreateEditDeleteProductFactory
	{
		protected override ICreateEditDeleteProduct MakeEditDeleteProductInstance()
		{
			ICreateEditDeleteProduct EditDeleteProduct_Obj = new CreateEditDeleteProduct();
			return EditDeleteProduct_Obj;
		}
	}
}
