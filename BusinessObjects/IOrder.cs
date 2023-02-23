using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public interface IOrder
	{
		double getSubTotal(DataTable dTable);
		double getDiscount(DataTable dTable);
		double getTotal(double subTotal, double delivery, double discount);
		DataTable GetCustomerDetails(int customerId);
		bool addOrder( int customerId, double subTotal, int quantity, double delivary, double discount, double totalPrice);
		DataTable GetOrderDetails(int customerId);
		bool PlacePayment(string orderId, double total, string provider);
		bool UpdateOrderStatus(string orderId,string status);
		bool updateProductStock(DataTable dt);
		bool updateOrder(int orderId, int customerId, double subTotal, int quantity, double delivary, double discount, double totalPrice, string status);
		bool deleteOrder(string orderId);

	}
}
