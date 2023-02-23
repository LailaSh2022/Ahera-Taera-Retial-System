using SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects;
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
	public partial class CustomerDashboardForm : Form
	{
		OpenChildForm OpenChildForm_object = new OpenChildForm();       // Create an instance of OpenChildForm Class
		//LoginForm LGF = new LoginForm();
		IViewProduct ViewProducts_Obj;
		public int customerId;
		public string username;
		public CustomerDashboardForm()
		{
			InitializeComponent();
			Main_Frame.instance.womenBtn.Visible = true;
			Main_Frame.instance.addToCart.Enabled = true;
			
		}

		private void view_btn_Click(object sender, EventArgs e)     // Call the Display Product form View left product information 
		{
			DisplayProductForm DPF = new DisplayProductForm() { TopLevel = false, TopMost = true };           // Load the Display product subform into the main frame.
			DPF.productId = Convert.ToInt32(Image02_lbl.Text);  // Send the selected product Id
			DPF.customerId = customerId;
			DPF.username = username;
			CustomerDashboard_pnl.Controls.Add(DPF);
			OpenChildForm_object.openChildForm(DPF);     // Dispaly the form on panel and hide the exist one.
		}
		

		private void CustomerDashboard_pnl_Paint(object sender, PaintEventArgs e)		// Loading the form and paint the panel
		{
			if (customerId == 0)
				customerId = LoginForm.instance.customerId;
			else
				LoginForm.instance.customerId = customerId;
			Main_Frame.instance.welcomeLable.Text = username;
			ViewProducts_Obj = new FactoryMethod_ViewProduct().GetViewProductInstant();       // Using Factory Method to return an instance of a Concrete ViewDress.
			DataSet ds = ViewProducts_Obj.GetProducts("CUS");			// Customer 

			LoadImages(ds);

		}
		public void LoadImages(DataSet ds)			// Load the products' images from the data set into the picture boxs.
		{
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				byte[] img = (byte[])ds.Tables[0].Rows[i]["PR_Main_Image"];         // Save the image into bynary array.
				MemoryStream ms = new MemoryStream(img);            // Create a memory stream instance for the given image
				switch (i)
				{
					case 0:
						{
							if (img == null)
								product01_pbx.Image = null;
							else
								product01_pbx.Image = Image.FromStream(ms);         // Load the image inot the picture box.
							Image01_lbl.Text = ds.Tables[0].Rows[i]["PR_Id"].ToString();
							break;
						}
					case 1:
						{

							if (img == null)
								product03_pbx.Image = null;
							else
								product03_pbx.Image = Image.FromStream(ms);
							Image03_lbl.Text = ds.Tables[0].Rows[i]["PR_Id"].ToString();
							break;
						}
					default:
						{
							if (img == null)
								product02_pbx.Image = null;
							else
								product02_pbx.Image = Image.FromStream(ms);
							Image02_lbl.Text = ds.Tables[0].Rows[i]["PR_Id"].ToString();
							break;
						}
				}	
			}
		}

		private void view0_btn_Click(object sender, EventArgs e)            // Call the Display Product form View center product information 
		{
			DisplayProductForm DPF = new DisplayProductForm() { TopLevel = false, TopMost = true };           // Load the Display product subform into the main frame.
			DPF.productId = Convert.ToInt32(Image01_lbl.Text);  // Send the selected product Id
			DPF.customerId = customerId;
			DPF.username = username;
			CustomerDashboard_pnl.Controls.Add(DPF);
			OpenChildForm_object.openChildForm(DPF);     // Dispaly the form on panel and hide the exist one.
		}

		private void view1_btn_Click(object sender, EventArgs e)			// Call the Display Product form to View right product information
		{
			DisplayProductForm DPF = new DisplayProductForm() { TopLevel = false, TopMost = true };           // Load the Display product subform into the main frame.
			DPF.productId = Convert.ToInt32(Image03_lbl.Text);  // Send the selected product Id 
			DPF.customerId = customerId;
			DPF.username = username;
			CustomerDashboard_pnl.Controls.Add(DPF);
			OpenChildForm_object.openChildForm(DPF);     // Dispaly the form on panel and hide the exist one.
		}
	}
}
