using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP4_2.RJControls;
using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;

namespace SWD604_Task2_RetialCustomerManagementSystem
{
	public partial class Main_Frame : Form
	{
		public static Main_Frame instance;
		public Button womenBtn, addToCart,signInBtn,signOutBtn;
		public Panel numberItems_pnl;
		public Label welcomeLable;
		//int customerId;
		
		public Main_Frame()
		{
			InitializeComponent();
			instance = this;
			womenBtn = women_btn;
			welcomeLable = Welcome_lbl;
			addToCart = shoppingCart_btn;
			numberItems_pnl = numItems_pnl;
			signInBtn = Login_btn;
			signOutBtn = signOut_btn;


		}
		OpenChildForm OpenChildForm_object = new OpenChildForm();
		private void Main_Frame_Load(object sender, EventArgs e)
		{
			search_btn.Visible = false;
			rjSearch_tbx.Visible = false;
			signOut_btn.Visible = false;
			LoadHomePage(); // Load the Home Page subform into the main frame.
			
		}

		private void Login_btn_Click(object sender, EventArgs e)
		{

			LoginForm LGF = new LoginForm() { TopLevel = false, TopMost = true };           // Load the Login subform into the main frame.
			SubForm_pnl.Controls.Add(LGF);
			OpenChildForm_object.openChildForm(LGF);     // Dispaly the form on panel and hide the exist one.
		}

		private void women_btn_Click(object sender, EventArgs e)
		{
			CustomerDashboardForm CDF = new CustomerDashboardForm() { TopLevel = false, TopMost = true };
			CDF.customerId = LoginForm.instance.customerId;
			CDF.username = Welcome_lbl.Text;
			SubForm_pnl.Controls.Add(CDF);
			OpenChildForm_object.openChildForm(CDF);

		}

		private void signOut_btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Logo_btn_Click(object sender, EventArgs e)
		{
			LoadHomePage(); // Load the Home Page subform into the main frame.
		}
		
		public void LoadHomePage()
		{
			HomePage HM = new HomePage() { TopLevel = false, TopMost = true };   // Load the Home Page subform into the main frame.
			SubForm_pnl.Controls.Add(HM);
			OpenChildForm_object.openChildForm(HM);     // Dispaly the form on panel and hide the exist one.
		}

		private void shoppingCart_btn_Click(object sender, EventArgs e)
		{
			Customer_ShoppingCartForm CSC = new Customer_ShoppingCartForm() { TopLevel = false, TopMost = true };   // Load the Home Page subform into the main frame.
			CSC.customerId = LoginForm.instance.customerId;
			CSC.username = Welcome_lbl.Text;
			SubForm_pnl.Controls.Add(CSC);
			OpenChildForm_object.openChildForm(CSC);
		}
	}
}
