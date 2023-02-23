using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects;
using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;

namespace SWD604_Task2_RetialCustomerManagementSystem
{
	public partial class LoginForm : Form
	{
		IValidateCustomer validateCustomer_obj;
		IValidateInput validateInput_Obj;
		OpenChildForm childForm = new OpenChildForm();
		public static LoginForm instance;
		public int customerId =0;
		public string userType;
		public string userName;

		public LoginForm()
		{
			InitializeComponent();
			instance = this;
		}
		private void rjSignUp_btn_Click(object sender, EventArgs e)
		{
			SignUpForm SF = new SignUpForm() { TopLevel = false, TopMost = true };           // Load the Sign up subform into the main frame.
			loginSubForm_pnl.Controls.Add(SF);
			childForm.openChildForm(SF);
		}
		private void rjShowPassword_btn_Click(object sender, EventArgs e)
		{
			rjPassword_tbx.PasswordChar = false;
		}
		private void rjLogIn_btn_Click(object sender, EventArgs e)
		{
			validateCustomer_obj = new FactoryMethod_ValidateNewCustomer().CreateCustomerInst();		// Using Factory Method
			validateInput_Obj = new FactoryMethod_ValidateInput().CreateValidateInputInst();            // Using Factory Method
			bool validInput = validateInput_Obj.ValidateInput(rjUserName_tbx);
			validInput = validateInput_Obj.ValidateInput(rjPassword_tbx);
			if (validInput)
			{
				bool registedCustomer = validateCustomer_obj.ValidateCustomerInput(rjUserName_tbx.Texts, rjPassword_tbx.Texts);     // Validate New Customer.
				if (!registedCustomer)
				{
					MessageBox.Show("Please double check your input or sign up if you are a new user!", "Invalid username or password");
				}
				else
				{
					
					// Validate if the user is admin or not.
					CustomerDashboardForm CDF = new CustomerDashboardForm() { TopLevel = false, TopMost = true };   // Load the customer dashboard subform into the main frame.
					DataTable dt = validateCustomer_obj.SignedCustomerInfo(rjUserName_tbx.Texts, rjPassword_tbx.Texts);		// Get login customer.
					foreach(DataRow dr in dt.Rows)
					{
						userName = "Welcome " + dr["CU_First_Name"].ToString() + " " + dr["CU_Last_Name"].ToString() + " To Ahera Taera Online Shopping App!";
						CDF.username = userName;
						CDF.customerId = (int)dr["CU_Id"];
						customerId = (int)dr["CU_Id"];
						userType = dr["User_Type"].ToString();
					}
					if (userType == "ADM")  // open admin dashboard
					{
						Main_Frame.instance.welcomeLable.Text = userName;
						AdminTabPagesForm AF = new AdminTabPagesForm() { TopLevel = false, TopMost = true };   // Load the admin dashboard subform into the main frame. 
						Main_Frame.instance.signInBtn.Visible = false;		// Disable and hide the sign in button.
						Main_Frame.instance.signOutBtn.Visible = true;		// Enable and show the sign out button.
						loginSubForm_pnl.Controls.Add(AF);
						childForm.openChildForm(AF);       // Dispaly the form on panel and hide the exist one.
					}
					else
					{
						Main_Frame.instance.numberItems_pnl.Visible = true;
						Main_Frame.instance.addToCart.Visible = true;
						Main_Frame.instance.signInBtn.Visible = false;  // Disable and hide the sign in button.
						Main_Frame.instance.signOutBtn.Visible = true;  // Enable and show the sign out button.
						loginSubForm_pnl.Controls.Add(CDF);
						childForm.openChildForm(CDF);       // Dispaly the form on panel and hide the exist one.
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
