using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public interface ICreateEditDeleteProduct
	{
		bool EdiSelectedProductDetails(int productId, int customerId, int quantity, string size);
		bool DeleteProductFromCart(int productId, int customerId);
		DataTable getSelectedProductInfo(int productId, int customerId);
		bool AddNewProduct(string name, string description, double price, int stock, string size);
		int getNewCreatedProductId();
		bool EditProduct(int productId, string name, string description, double price, int stock, string size);
	}
}
