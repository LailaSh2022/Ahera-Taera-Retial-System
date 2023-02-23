using SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects;
using SWD604_Task2_RetialCustomerManagementSystem.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem
{
	public partial class CustomerShoppingCart : Form
	{
		public  int customerId,quantity;
		public static CustomerShoppingCart instance;
		IAddToShoppingCart toShoppingCart;
		IOrder Order_Obj;
		double subTotal=0, discount=0, delivary=0, total=0;
		DataTable dt,customerDt;

		

		public CustomerShoppingCart()
		{
			InitializeComponent();
			instance = this;
		}
		private void ShoppingCart_pnl_Paint(object sender, PaintEventArgs e)
		{

		}
		private void CustomerShoppingCart_Load(object sender, EventArgs e)
		{
			if (LoginForm.instance != null)
				customerId = LoginForm.instance.customerId;
			else
				MessageBox.Show("You need to Login to see your chart.", "Login or Sign up.");

			toShoppingCart = new FactoryMethod_ShoppingCart().CreateAddToShoppingCart();
			Order_Obj = new FactoryMethod_Order().CreateOrderInstance();
			
			dt = toShoppingCart.GetProductDetails(customerId);
			quantity = toShoppingCart.Feed_ListView(shoppingItems_lst, dt);		// Feed List view with data.
			subTotal_lbl.Text = "$" + Order_Obj.getSubTotal(dt)+ ".00";	// Display sub total
			customerDt = Order_Obj.GetCustomerDetails(customerId);		// Return customer date of birht and city
			discount_lbl.Text = "%" + Order_Obj.getDiscount(customerDt) + ".00"; // Display discount percentage
			subTotal = Order_Obj.getSubTotal(dt);
			discount = Order_Obj.getDiscount(customerDt);
			total = (subTotal + delivary)-((subTotal + delivary) * discount) / 100;
			total_lbl.Text = "NZ$" + total;			// Display the total
		}

		private void rjProceedToCheckout_btn_Click(object sender, EventArgs e)
		{
			bool insertedOrder = Order_Obj.addOrder(customerId, subTotal, quantity, delivary, discount, total);
			if (insertedOrder)
			{
				MessageBox.Show("Your order is placed", "Order info");
			}
		}
		private void rjDelevary_btn_CheckedChanged(object sender, EventArgs e)		// Delivary check box
		{
			if (rjDelevary_btn.Checked)
			{
				delivary_lbl.Text = "$10.00";
				delivary = 10.00;
				total = (subTotal + delivary) - ((subTotal + delivary) * discount) / 100;
				total_lbl.Text = "NZ$" + total;
			}
			else
			{
				delivary_lbl.Text = "$00.00";
				delivary = 00.00;
				total = (subTotal + delivary) - ((subTotal + delivary) * discount) / 100;
				total_lbl.Text = "NZ$" + total;
			}
				
		}
	}
}
