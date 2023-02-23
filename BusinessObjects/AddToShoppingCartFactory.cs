using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public abstract class AddToShoppingCartFactory
	{
		protected abstract IAddToShoppingCart MakeAddToShoppingCart();
		public IAddToShoppingCart CreateAddToShoppingCart()
		{
			return this.MakeAddToShoppingCart();
		}

	}
}
