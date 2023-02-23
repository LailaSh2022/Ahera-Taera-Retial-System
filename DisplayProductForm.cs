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
	public partial class DisplayProductForm : Form
	{
        OpenChildForm OpenChildForm_object = new OpenChildForm();		// Create an instance of OpenChildForm Class
        IDressDetails ProductDetails_Obj;
        IAddToShoppingCart toShoppingCart;
        IViewProduct viewDress_Obj;
        ICreateEditDeleteProduct editDeleteProduct_Obj;
        public int productId, numberOfItems, customerId;
        public DataTable dt,image_dt,editProduct_dt;
        public string productSize, username,viewMode;

        public DisplayProductForm()
		{
			InitializeComponent();
		}

		private void DisplayProductForm_Load(object sender, EventArgs e)
		{
			if (viewMode == "Edit")         // (Edit/Delet product mode) Enable the edit and delete buttons + disable the add to cart and back button.
			{
                activateEditMode();
            }
            else                               // (View/Add product mode) Disable the edit and delete buttons + enable the add to cart and back button.
            {
                AddToCart_btn.Visible = true;
                Back_btn.Visible = true;
                rjDelete_btn.Visible = false;
                rjEdit_btn.Visible = false;
			}
            //LoginForm.instance.customerId = customerId;
            Main_Frame.instance.welcomeLable.Text = username;
            ProductDetails_Obj = new FactoryMethod_DressDetails().CreateProductDetailsInstance();       // Using Factory Method 
            viewDress_Obj = new FactoryMethod_ViewProduct().GetViewProductInstant();  // Using Factory Method
            dt = ProductDetails_Obj.GetProductDetails(productId,"CUS");
            image_dt = ProductDetails_Obj.GetProductImages(productId);      // Retuns images for selected dress.
            viewDress_Obj.LoadDressImages(image_dt, dressImage_lst);        // View images for selected dress using image list.
            Title_lbl.Text = dt.Rows[0]["PR_Name"].ToString();
            rjDiscription_lbx.PlaceholderText = dt.Rows[0]["PR_Discription"].ToString();
            Price_lbl.Text = "$"+dt.Rows[0]["PR_Price"].ToString();
        }
        public void activateEditMode()
		{
            AddToCart_btn.Visible = false;
            Back_btn.Visible = false;
            rjDelete_btn.Visible = true;
            rjEdit_btn.Visible = true;
            editDeleteProduct_Obj = new FactoryMethod_CreateEditDeleteProduct().CreateEditDeleteInst();
            editProduct_dt = editDeleteProduct_Obj.getSelectedProductInfo(productId, customerId);
			foreach (DataRow dr in editProduct_dt.Rows)
			{
                rjNumberOfIems_tbx.Texts = dr["Quantitiy"].ToString();
                switch (dr["Size"].ToString())
				{
                    case "XL":
						{
                            XL_rbn.Checked = true;
                            break;
						}
                    case "L":
                        {
                            L_rbn.Checked = true;
                            break;
                        }
                    case "M":
                        {
                            M_rbn.Checked = true;
                            break;
                        }
                    default:
						{
                            S_rbn.Checked = true;
                            break;
						}
                }
			}
        }
       
        int imageIndex = 0;

		private void Back_btn_Click(object sender, EventArgs e)         // Back button to return the user to the back Form
		{
            CustomerDashboardForm CDP = new CustomerDashboardForm() { TopLevel = false, TopMost = true };           // Load the Display product subform into the main frame.
            CDP.customerId = customerId;
            CDP.username = username;
           DisplayProduct_pnl.Controls.Add(CDP);
            OpenChildForm_object.openChildForm(CDP);     // Dispaly the form on panel and hide the exist one.
        }

		private void AddToCart_btn_Click(object sender, EventArgs e)        // Add to cart button
		{
            toShoppingCart = new FactoryMethod_AddToShoppingCart().CreateAddToShoppingCart();        // Using Factory Method
         
                if (toShoppingCart.validateQuantity(rjNumberOfIems_tbx.Texts,productId))
				{
                    numberOfItems = Convert.ToInt32(rjNumberOfIems_tbx.Texts);
                    //customerId = LoginForm.instance.customerId;
                    bool result = toShoppingCart.addProductToCart(productId, customerId, productSize, numberOfItems);
                    if (result)
                        MessageBox.Show("Your product has been added to your chopping cart.", "Adding to cart.");
                }
            
        }

		private void rjEdit_btn_Click(object sender, EventArgs e)        // Update selected product.
        {
            editDeleteProduct_Obj = new FactoryMethod_CreateEditDeleteProduct().CreateEditDeleteInst();
            toShoppingCart = new FactoryMethod_AddToShoppingCart().CreateAddToShoppingCart();        // Using Factory Method
            if (toShoppingCart.validateQuantity(rjNumberOfIems_tbx.Texts, productId))
            {
                numberOfItems = Convert.ToInt32(rjNumberOfIems_tbx.Texts);
                bool updateProduct = editDeleteProduct_Obj.EdiSelectedProductDetails(productId, customerId, numberOfItems, productSize);
                if (updateProduct)
                {
                    MessageBox.Show("Your item is updated", "Update selected Product");
                }
            }
        }

        private void rjDelete_btn_Click(object sender, EventArgs e)     // Delete selected product.
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                editDeleteProduct_Obj = new FactoryMethod_CreateEditDeleteProduct().CreateEditDeleteInst();
                bool updateProduct = editDeleteProduct_Obj.DeleteProductFromCart(productId, customerId);
                if (updateProduct)
                {
                    MessageBox.Show("Your item is deleted from your cart", "Delete selected Product");
                }
            }
           // else if (dialogResult == DialogResult.No)
           // {
                //do something else
           // }
            
            
        }

		// Dress size radio buttons
		private void XL_rbn_CheckedChanged(object sender, EventArgs e)
		{
            productSize = "XL";
		}

		private void L_rbn_CheckedChanged(object sender, EventArgs e)
		{
            productSize = "L";
        }
	
       private void M_rbn_CheckedChanged(object sender, EventArgs e)
		{
            productSize = "M";
        }

		private void S_rbn_CheckedChanged(object sender, EventArgs e)
		{
            productSize = "S";
        }

		private void DisplayImage_tmr_Tick(object sender, EventArgs e)      // Using timer to display the image list.
		{
            
            viewDress_pbx.Image = dressImage_lst.Images[imageIndex];        // Load the image into picture box.
            if (imageIndex == dressImage_lst.Images.Count - 1)
                imageIndex = 0; 
            else
                imageIndex++;
		}
 
    }
}
