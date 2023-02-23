using SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects;
using SWD604_Task2_RetialCustomerManagementSystem.DataBase;
using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;
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
	public partial class BillGenerationForm : Form
	{
		public int customerId;
		DataTable productDT, orderDT;
		OpenChildForm OpenChildForm_object = new OpenChildForm();
		string provider ="";
		double total;
		IOrder order_Obj;
		IBill bill_Obj;
		IAddToShoppingCart cart_Obj;
		IValidateInput validateInput_Obj;
		public BillGenerationForm()
		{
			InitializeComponent();
		}

		private void BillGeneration_pnl_Paint(object sender, PaintEventArgs e)
		{
			

		}
		public void fillBillInfo(DataTable BillDT)		// Fill the bill details
		{
			foreach(DataRow dr in BillDT.Rows)
			{
				orderNumber_lbl.Text = dr["OR_Id"].ToString();
				subTotal_lbl.Text = "$" + Convert.ToDouble(dr["Price"]).ToString("N2");
				delivary_lbl.Text = "$" + Convert.ToDouble(dr["Delivary"]).ToString("N2");
				double discount = Convert.ToDouble(dr["Discount"]) * 100;
				discount_lbl.Text = " "+ discount.ToString("N2") + "%";
				total_lbl.Text = "$" + Convert.ToDouble(dr["Total_Price"]).ToString("N2");
				total = Convert.ToDouble(dr["Total_Price"]);
			}
		}
		
		private void BillGeneration_Load(object sender, EventArgs e)
		{
			order_Obj = new FactoryMethod_Order().CreateOrderInstance();		// Using Factory Method
			bill_Obj = new FactoryMethod_Bill().CreateBillInstance();           // Using Factory Method
			productDT = bill_Obj.GetProductDetails(customerId);
			bill_Obj.Feed_BillList(orderListView_lsv, productDT);				// Generate the bill
			orderDT = order_Obj.GetOrderDetails(customerId);
			fillBillInfo(orderDT);
		}

		private void Back_btn_Click(object sender, EventArgs e)
		{
			Customer_ShoppingCartForm CSC = new Customer_ShoppingCartForm() { TopLevel = false, TopMost = true };           // Load the Login subform into the main frame.
			if (orderNumber_lbl.Text == "")		//If no order is recoreded
				CSC.orderId = 0;
			else
				CSC.orderId = Convert.ToInt32(orderNumber_lbl.Text);
			CSC.customerId = customerId;
			CSC.username = Main_Frame.instance.welcomeLable.Text;
			BillGeneration_pnl.Controls.Add(CSC);
			OpenChildForm_object.openChildForm(CSC);     // Dispaly the form on panel and hide the exist one.
		}

		private void rjVisa_rbn_CheckedChanged(object sender, EventArgs e)
		{
			provider = "Visa";
		}

		private void rjMasterCard_rbn_CheckedChanged(object sender, EventArgs e)
		{
			provider = "Master Card";
		}
		public bool ValidateCheckBox(string value)
		{
			if (value == "")
			{
				rjMasterCard_rbn.UnCheckedColor = Color.DarkGray;
				rjVisa_rbn.UnCheckedColor = Color.Gray;
				MessageBox.Show("Please select your payment method.", "Payment method");
				return false;
			}
			else
			{
				rjMasterCard_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				rjVisa_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				return true;
			}
			
		}

		private void rjPlaceOrder_btn_Click(object sender, EventArgs e)
		{
			validateInput_Obj = new FactoryMethod_ValidateInput().CreateValidateInputInst();    // Using Factory Method
			bool validateInput = validateInput_Obj.ValidateInput(rjCardNumber_tbx);
			validateInput = validateInput_Obj.ValidateInput(rjCVC_CVV_tbx);
			validateInput = validateInput_Obj.ValidateInput(rjExpiryDate_tbx);
			validateInput = ValidateCheckBox(provider);
			if (validateInput)
			{
				cart_Obj = new FactoryMethod_AddToShoppingCart().CreateAddToShoppingCart();     // Using Factory Method
				bool updateProductStock = order_Obj.updateProductStock(productDT);          // Subtract the bought quantity from product's quantity using loop and product Id.
				if (updateProductStock)
				{
					bool placePayment = order_Obj.PlacePayment(orderNumber_lbl.Text, total, provider);  // Insert a new record in Payment_Bill table
					bool updateOrder = order_Obj.UpdateOrderStatus(orderNumber_lbl.Text,"Paid");       // Update the order's status to paid
					bool updateCart = cart_Obj.UpdateCartStatus(customerId);            // Update the cart's status to paid
					if ((placePayment) && (updateOrder) && (updateCart))
					{
						MessageBox.Show("Thank you for your shopping", "Ahera Taera");
						HomePage HP = new HomePage() { TopLevel = false, TopMost = true };           // Load the Home page subform into the main frame.
						BillGeneration_pnl.Controls.Add(HP);
						OpenChildForm_object.openChildForm(HP);     // Dispaly the form on panel and hide the exist one.
					}
				}
			}
			else
			{
				MessageBox.Show("Please enter the missing information", "Missing Input");
			}
		}

	}
}
