using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_AddToShoppingCart : AddToShoppingCartFactory
	{
		protected override IAddToShoppingCart MakeAddToShoppingCart()
		{
			IAddToShoppingCart addToShoppingCart = new AddToShoppingCart();
			return addToShoppingCart;
		}
	}
}
