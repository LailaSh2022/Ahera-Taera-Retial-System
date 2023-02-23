using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public interface IBill
	{
		DataTable GetProductDetails(int customerId);
		void Feed_BillList(ListView shoppingItems_lst, DataTable dt);
		bool deleteSelectedPayment(string paymentId);
		bool UpdateSelectedPayment(string paymentId, string provider, string status);
		bool UpdateTotalPayment(int paymentId, double total);
		int getPaymentId(string orderId);
		DataTable getPaymentList();
	}
}
