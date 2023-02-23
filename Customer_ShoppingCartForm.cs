using SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects;
using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem
{
	public partial class Customer_ShoppingCartForm : Form
	{
		public int customerId, quantity, orderId = 0;
		public static Customer_ShoppingCartForm instance;
		IAddToShoppingCart toShoppingCart;
		IOrder Order_Obj;
		double subTotal = 0, discount = 0, delivery = 0, total = 0;
		OpenChildForm OpenChildForm_object = new OpenChildForm();
		DataTable dt, customerDt,orderDt;
		public string username;

		public Customer_ShoppingCartForm()
		{
			InitializeComponent();
			instance = this;
		}
		private void Customer_ShoppingCartForm_Load(object sender, EventArgs e)
		{
			if (customerId != 0)
				LoginForm.instance.customerId = customerId;
			Main_Frame.instance.welcomeLable.Text = username;
			toShoppingCart = new FactoryMethod_AddToShoppingCart().CreateAddToShoppingCart();       // Using Factory Method
			Order_Obj = new FactoryMethod_Order().CreateOrderInstance();                        // Using Factory Method
			orderDt = Order_Obj.GetOrderDetails(customerId);
			if (orderDt.Rows.Count>0)
			{
				foreach(DataRow dr in orderDt.Rows)
				{
					orderId = Convert.ToInt32(dr["OR_ID"]);
				}
			}
			dt = toShoppingCart.GetSelectedProductDetails(customerId);                  // Get product's details
			quantity = toShoppingCart.Feed_ListView(shoppingItems_lst, dt);     // Feed List view with data.
			subTotal_lbl.Text = "$" + Order_Obj.getSubTotal(dt).ToString("N2");    // Display sub total
			customerDt = Order_Obj.GetCustomerDetails(customerId);      // Return customer date of birht and city
			discount_lbl.Text = "%" + Order_Obj.getDiscount(customerDt).ToString("N2"); // Display discount percentage
			subTotal = Order_Obj.getSubTotal(dt);
			if (subTotal == 0)
				rjChangeOrder_btn.Enabled = false;
			else
				rjChangeOrder_btn.Enabled = true;
			discount = Order_Obj.getDiscount(customerDt);
			total = (subTotal + delivery) - ((subTotal + delivery) * discount) / 100;
			total_lbl.Text = "NZ$" + total.ToString("N2");         // Display the total
		}
		private void Customer_Cart_pnl_Paint(object sender, PaintEventArgs e)
		{
			
		}
		private void rjDelivery_btn_CheckedChanged(object sender, EventArgs e)			// Check Delivery button.
		{
			if (rjDelivery_btn.Checked)				// Add $10 if checked
			{
				delivary_lbl.Text = "$10.00";
				delivery = 10.00;
				total = Order_Obj.getTotal(subTotal, delivery, discount);		// Use Factory Method to calculate the total amount of money to pay.
				total_lbl.Text = "NZ$" + total;
			}
			else
			{
				delivary_lbl.Text = "$00.00";
				delivery = 00.00;
				total = Order_Obj.getTotal(subTotal, delivery, discount);   // Use Factory Method to calculate the total amount of money to pay.
				total_lbl.Text = "NZ$" + total;
			}
		}
		private void rjProceedToCheckout_btn_Click(object sender, EventArgs e)		// Add new order.
		{
			if ((subTotal != 0)&&(orderId == 0))
			{
				discount /= 100;
				bool insertedOrder = Order_Obj.addOrder(customerId, subTotal, quantity, delivery, discount, total);
				if (insertedOrder)
				{
					MessageBox.Show("Your order is placed", "Order info");
					BillGenerationForm BL = new BillGenerationForm() { TopLevel = false, TopMost = true };           // Load the Bill Generation subform into the main frame.
					BL.customerId = customerId;
					Customer_Cart_pnl.Controls.Add(BL);
					OpenChildForm_object.openChildForm(BL);     // Dispaly the form on panel and hide the exist one.
				}
			}
			else if(orderId !=0)
			{
				discount /= 100;
				bool updateOrder = Order_Obj.updateOrder(orderId, customerId, subTotal, quantity, delivery, discount, total,"UnPaid");
				if (updateOrder)
				{
					MessageBox.Show("Your order is updated", "Order info");
					BillGenerationForm BL = new BillGenerationForm() { TopLevel = false, TopMost = true };           // Load the Bill Generation subform into the main frame.
					BL.customerId = customerId;
					Customer_Cart_pnl.Controls.Add(BL);
					OpenChildForm_object.openChildForm(BL);     // Dispaly the form on panel and hide the exist one.
				}
			}
			else
			{
				MessageBox.Show("Please select a product.", "Order info");
			}
			
		}
		private void rjChangeOrder_btn_Click(object sender, EventArgs e)		// Change old order.
		{
			int prId = 0, found = 0;
			string str, str1;
			if (shoppingItems_lst.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please select an item from order list", "No item selected");
			}
			else
			{
				str = shoppingItems_lst.SelectedItems[0].Text;
				for (int j = 0; j < str.Length; j++)
					if (Char.IsDigit(str[j]) && (found != -1))
					{

						str1 = Convert.ToString(str[j]);
						Int32.TryParse(str1, out prId);
						found++;

					}
					else
					{
						if (found != 0)
							found = -1;
					}

				DisplayProductForm DPF = new DisplayProductForm() { TopLevel = false, TopMost = true };     // Load the Display Product subform into the main frame.
				DPF.productId = prId;
				DPF.viewMode = "Edit";
				DPF.customerId = customerId;
				DPF.username = username;
				Customer_Cart_pnl.Controls.Add(DPF);
				OpenChildForm_object.openChildForm(DPF);     // Dispaly the form on panel and hide the exist one.
			}
			
			
		}
	}
}
