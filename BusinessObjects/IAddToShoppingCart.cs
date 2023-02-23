using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public interface IAddToShoppingCart
	{
		bool validateQuantity(string quantity, int productId);
		bool addProductToCart(int productId, int customerId, string size,int quantity);
		DataTable GetSelectedProductDetails(int customerId);
		int Feed_ListView(ListView shoppingItems_lst, DataTable dt);
		bool UpdateCartStatus(int customerId);
	}
}
