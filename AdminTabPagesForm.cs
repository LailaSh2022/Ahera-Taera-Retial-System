using AP4_2.RJControls;
using SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem
{
	public partial class AdminTabPagesForm : Form
	{
		IOrder Order_obj;
		IViewProduct ViewProducts_Obj;
		IDressDetails ProductDetails_Obj;
		IBill updatePayment_Obj,Payment_Obj;
		bool displayOrderList, displayPaymentList, uploadMainImage = false;
		double totalPayment = 0, totalOrdersPayment =0;
		public AdminTabPagesForm()
		{
			InitializeComponent();
			Main_Frame.instance.womenBtn.Visible = false;
			Main_Frame.instance.addToCart.Visible = false;
			Main_Frame.instance.numberItems_pnl.Visible = false;
		}

		private void admin_Tbs_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			Payment_Obj = new FactoryMethod_Bill().CreateBillInstance();        // Re-use the Bill Factory Method pattern.
			if (admin_Tbs.SelectedTab == adminPayment_tb)		// When the use click the Payment tab.
			{
				displayPaymentList = DisplayPymentsDataGrid(Payment_dgv, Payment_Obj.getPaymentList()); // Use the getPaymentList method.
				Grid_tmr.Start();
				if (!displayPaymentList)
				{
					MessageBox.Show("There are no Payments to display!", "Payment");
					// Disable buttons if the order payment list is empty.
					this.rjPaymentEdit_btn.Enabled = false;
					this.rjPaymentDelete_btn.Enabled = false;
				}
				else
				{
					this.rjPaymentEdit_btn.Enabled = false;
					this.rjPaymentDelete_btn.Enabled = true;
				}
				if (totalPayment > 0)
				{
					paymentTotal_lbl.Text = "NZ$" + totalPayment.ToString("N2");
				}
				
			}
			else if (admin_Tbs.SelectedTab == adminOrder_tb)            // When the use click the Order tab.
			{
				Order_obj = new FactoryMethod_Order().CreateOrderInstance();	// Re-use the Order Factory Method pattern.
				displayOrderList = DisplayOrdersDataGrid(order_dgv, Order_obj.GetOrderDetails(-1));  // Re-use GetOrderDetails method --> pass -1 for Admin.
				Grid_tmr.Start();			// Start the timer.
				if (! displayOrderList)			// When Display an empty order list.
				{
					MessageBox.Show("There are no Orders to display!", "Order");
					this.rjOrderEdit_btn.Enabled = false;
					this.rjOrderDelete_btn.Enabled = false;
				}
				else
				{
					this.rjOrderEdit_btn.Enabled = false;
					this.rjOrderDelete_btn.Enabled = true;
				}
				if (totalOrdersPayment > 0)
				{
					totalOrders_lbl.Text = "NZ$" + totalOrdersPayment.ToString("N2");
				}
			}
			else                         // When the use click the Product tab.
			{
				// Reset the Product tab's buttons
				rjProductList_cbx.Visible = false;
				rjBackGroundOfComboBox_btn.Visible = false;
				rjProductEdit_btn.Visible = true;
				rjEditProduct_btn.Visible = false;
				rjProductDelete_btn.Visible = false;
				rjAddNewProduct_btn.Visible = false;
				rjProductAdd_btn.Visible = true;
				Grid_tmr.Stop();



			}
		}
		public bool DisplayOrdersDataGrid(DataGridView dataGrid, DataTable dt)
		{
			if (dt.Rows.Count>0)
			{
				dataGrid.DataSource = dt;  // Add customer name.

				dataGrid.Columns[0].Width = 50;
				dataGrid.Columns[0].HeaderText = "Order Id";
				dataGrid.Columns[1].Width = 50;
				dataGrid.Columns[1].HeaderText = "Customer Id";
				dataGrid.Columns[2].Width = 90;
				dataGrid.Columns[2].HeaderText = "Customer Name";
				dataGrid.Columns[3].Width = 50;
				var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();        // Create a clone variable to handle the cells style.
				format.CurrencySymbol = "$ ";
				dataGrid.Columns[4].DefaultCellStyle.FormatProvider = format;
				dataGrid.Columns[4].DefaultCellStyle.Format = "c";
				dataGrid.Columns[4].Width = 65;
				dataGrid.Columns[5].DefaultCellStyle.FormatProvider = format;
				dataGrid.Columns[5].DefaultCellStyle.Format = "c";
				dataGrid.Columns[5].Width = 50;
				dataGrid.Columns[5].HeaderText = "Delivery";
				dataGrid.Columns[6].DefaultCellStyle.Format = "P";
				dataGrid.Columns[6].Width = 57;
				dataGrid.Columns[6].HeaderText = "Discount";
				dataGrid.Columns[7].Width = 65;
				dataGrid.Columns[7].HeaderText = "Total Price";
				dataGrid.Columns[7].DefaultCellStyle.FormatProvider = format;
				dataGrid.Columns[7].DefaultCellStyle.Format = "c";
				dataGrid.Columns[8].Width = 70;
				dataGrid.Columns[8].HeaderText = "Issue Date";
				dataGrid.Columns[9].Width = 55;
				totalOrdersPayment = 0;
				foreach (DataRow dr in dt.Rows)
					totalOrdersPayment += Convert.ToDouble(dr["Total_Price"]);
				return true;
			}
			else
			{
				return false;
			}
			
		}
		public bool DisplayPymentsDataGrid(DataGridView dataGrid, DataTable dt)
		{
			if (dt.Rows.Count > 0)
			{
				dataGrid.DataSource = dt;  // Add customer name.

				dataGrid.Columns[0].Width = 50;
				dataGrid.Columns[0].HeaderText = "Payment Id";
				dataGrid.Columns[1].Width = 50;
				dataGrid.Columns[1].HeaderText = "Order Id";
				dataGrid.Columns[2].HeaderText = "Customer Id";
				dataGrid.Columns[2].Width = 50;
				dataGrid.Columns[3].Width = 90;
				dataGrid.Columns[3].HeaderText = "Customer Name";				
				var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();        // Create a clone variable to handle the cells style.
				format.CurrencySymbol = "$ ";
				dataGrid.Columns[4].DefaultCellStyle.FormatProvider = format;
				dataGrid.Columns[4].DefaultCellStyle.Format = "c";
				dataGrid.Columns[4].HeaderText = "Total";
				dataGrid.Columns[4].Width = 65;
				dataGrid.Columns[5].Width = 70;
				dataGrid.Columns[5].HeaderText = "Issue Date";
				dataGrid.Columns[6].Width = 70;
				dataGrid.Columns[7].Width = 55;

				totalPayment = 0;
				foreach (DataRow dr in dt.Rows)
				{
					totalPayment += Convert.ToDouble(dr["Total_Amount"]);
				}

				
				return true;
			}
			else
			{
				return false;
			}

		}

		private void rjOrderEdit_btn_Click(object sender, EventArgs e)          // Click Edit  button in Orders' tab.
		{
			int rowindex = order_dgv.CurrentCell.RowIndex;		// Spicify the selected row index.
			string orderId = order_dgv.Rows[rowindex].Cells[0].Value.ToString();           // Get the Order Id column's value.
			int quantity = Convert.ToInt32(order_dgv.Rows[rowindex].Cells[3].Value.ToString());     // Get the Quantity column's value.
			double price = Convert.ToDouble(order_dgv.Rows[rowindex].Cells[4].Value.ToString());      // Get the Price Id column's value.
			string delivaryStr = RemoveSpecialCharacters(order_dgv.Rows[rowindex].Cells[5].Value.ToString());
			double delivary = Convert.ToDouble(delivaryStr);      // Get the Delivary column's value.
			string dicountStr = RemoveSpecialCharacters(order_dgv.Rows[rowindex].Cells[6].Value.ToString());
			double discount = Convert.ToDouble(dicountStr);      // Get the Discount column's value.
			string status = order_dgv.Rows[rowindex].Cells[9].Value.ToString();       // Get the Status column's value.

			updatePayment_Obj = new FactoryMethod_Bill().CreateBillInstance();
			Order_obj = new FactoryMethod_Order().CreateOrderInstance();
			// Re-Use the getTotal method from IOrder interface to calculate the updated amounts.
			double total = Order_obj.getTotal(price, delivary, discount*100);           
			// Re-Use the updateOrder Method --> -1 means Admin.
			bool OrderUpdated = Order_obj.updateOrder(Convert.ToInt32(orderId),-1,price,quantity,delivary,discount,total,status);  
				if (OrderUpdated)
				{
					int paymentId = updatePayment_Obj.getPaymentId(orderId);
					bool pymentUpdate = updatePayment_Obj.UpdateTotalPayment(paymentId, total);         // Update the payment record with the new caculated total amount
					if (pymentUpdate)
					{
						MessageBox.Show("One record has been updated", "Update Record");
					Grid_tmr.Start();
						rjOrderEdit_btn.Enabled = false;
					}
				}

		}
		public string RemoveSpecialCharacters(string str)
		{
			StringBuilder sb = new StringBuilder();
			foreach (char c in str)
			{
				if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
				{
					sb.Append(c);
				}
			}
			return sb.ToString();
		}

		private void rjOrderDelete_btn_Click(object sender, EventArgs e)
		{
			Order_obj = new FactoryMethod_Order().CreateOrderInstance();			// Re-use Order Factory Method.
			int rowindex = order_dgv.CurrentCell.RowIndex;
			string orderId = order_dgv.Rows[rowindex].Cells[0].Value.ToString();
			DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete the selected Payment?", "Delete Payment", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				bool deleteOrder = Order_obj.deleteOrder(orderId);      // Delete selected order.
				if (deleteOrder)
				{
					MessageBox.Show("The selected order is deleted", "Delete Order");
				}
			}

		}

		private void rjPaymentEdit_btn_Click(object sender, EventArgs e)		// Click the Payment's Edit button.
		{
			int rowindex = Payment_dgv.CurrentCell.RowIndex;							// Get the selected row number.
			paymentId = Payment_dgv.Rows[rowindex].Cells[0].Value.ToString();           // Get the Payment Id column's value.
			string orderId = Payment_dgv.Rows[rowindex].Cells[1].Value.ToString();      // Get the Order Id column's value.
			string provider = Payment_dgv.Rows[rowindex].Cells[6].Value.ToString();     // Get the Provider column's value.
			string status = Payment_dgv.Rows[rowindex].Cells[7].Value.ToString();       // Get the Status column's value.
			if ((status == "")&&(status.ToUpper() != "PAID")&&(status.ToUpper() !="UNPAID"))	// Validate the given Status value by the user.
			{
				MessageBox.Show("Please Enter Correct Payment Status", "Payment status");
			}
			else
			{
				updatePayment_Obj = new FactoryMethod_Bill().CreateBillInstance();		// Re-use the Bill Factory Method.
				Order_obj = new FactoryMethod_Order().CreateOrderInstance();			// Re-use the Order Factory Method.
				bool paymentUpdated = updatePayment_Obj.UpdateSelectedPayment(paymentId, provider, status);     // Use the UpdateSelectedPayment method from the IBill interface.
				if (paymentUpdated)
				{
					
					bool orderUpdated = Order_obj.UpdateOrderStatus(orderId, status);       // Re-use the UpdateOrderStatus method from the IOrder interface.
					if (orderUpdated)
					{
						MessageBox.Show("One record has been updated", "Update Payment");
						Grid_tmr.Start();
						rjPaymentEdit_btn.Enabled = false;				// Disable the Edit button.
					}
				}
			}
			
		}

		private void AdminTabPagesForm_Load(object sender, EventArgs e)
		{
			
			Payment_Obj = new FactoryMethod_Bill().CreateBillInstance();        // Re-use the Bill Factory classes.
			displayPaymentList = DisplayPymentsDataGrid(Payment_dgv, Payment_Obj.getPaymentList());     // Re-use the Bill Factory classes.
			Grid_tmr.Start();
			if (!displayPaymentList)
			{
				MessageBox.Show("There are no Payments to display!", "Admin Payment");
				// Disable buttons if the order payment list is empty.
				this.rjPaymentEdit_btn.Enabled = false;
				this.rjPaymentDelete_btn.Enabled = false;
			}
			if (totalPayment > 0)
			{
				paymentTotal_lbl.Text = "NZ$" + totalPayment.ToString("N2");
			}
		}

		private void rjProductEdit_btn_Click(object sender, EventArgs e)
		{
					
			rjProductList_cbx.Visible = true;
			rjBackGroundOfComboBox_btn.Visible = true;
			rjProductEdit_btn.Visible = false;
			rjProductDelete_btn.Enabled = true;
			// Re-Use Factory Method to return an instance of a Concrete ViewProduct.
			ViewProducts_Obj = new FactoryMethod_ViewProduct().GetViewProductInstant();  
			DataSet ds = ViewProducts_Obj.GetProducts("ADM");   // Admin 
			rjProductList_cbx.DataSource = null;

			if (ds.Tables[0].Rows.Count > 0)            // Fill the Product's DropDownList
			{
				rjProductList_cbx.DataSource = ds.Tables[0];
				rjProductList_cbx.DisplayMember = "PR_Name";
				rjProductList_cbx.ValueMember = "PR_Id";

			}
			rjProductList_cbx.Text = "Select a Product";
			rjProductList_cbx.TabIndex = 0;
			rjEditProduct_btn.Visible = true;
			rjProductDelete_btn.Visible = true;
			rjProductAdd_btn.Visible = false;
			rjCancelAction_btn.Visible = true;
			rjProductInfo_btn.Visible = true;

		}
		int productId;
		
		private void rjUploadMainImage_rbn_CheckedChanged(object sender, EventArgs e)
		{
			
				uploadMainImage = true;
		}
		string imageLocation = "";
		private void rjBrowse_btn_Click(object sender, EventArgs e)		// Browse produc's image.
		{
			try
			{
				OpenFileDialog dlg = new OpenFileDialog();		// Open a file dialog window.
				dlg.Filter = "JPG Files(*.jpg)|*.jbg| GIF Files(*.gif)|*.gif| All Files(*.*)|*.*";			// Filter the file's extentions to upload.
				dlg.Title = "Select product image.";			// The title of the displayed dialog box.
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					imageLocation = dlg.FileName.ToString();			// Image's file name and location.
					productImage_pbx.ImageLocation = imageLocation;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void rjSave_btn_Click(object sender, EventArgs e)		// Save Image.
		{
			ViewProducts_Obj = new FactoryMethod_ViewProduct().GetViewProductInstant();       // Re-Use Factory Method to return an instance of a Concrete ViewProduct.
			if (uploadMainImage == true)
			{
				if(ViewProducts_Obj.addProductMainImage(imageLocation, productId))      // Re-use the addProductMainImage to add main image for given product Id.
				{
					rjUploadMainImage_rbn.Checked = false;
					uploadMainImage = false;
					MessageBox.Show("The selected image is added", "Add image to product");
				}
			}
			else
			{
				ViewProducts_Obj.addProductSubImages(imageLocation, productId);				// Re-use the addProductSubImage to add main image for given product Id.
				MessageBox.Show("The selected image is added", "Add image to product");
				uploadMainImage = false;
			}
			
		}

		private void rjProductAdd_btn_Click(object sender, EventArgs e)
		{
			rjProductList_cbx.Visible = false;
			rjBackGroundOfComboBox_btn.Visible = false;
			rjProductEdit_btn.Visible = false;
			rjEditProduct_btn.Visible = false;
			rjOrderDelete_btn.Visible = false;
			rjAddNewProduct_btn.Visible = true;
			rjCancelAction_btn.Visible = true;
		}

		private void rjCancelAction_btn_Click(object sender, EventArgs e)
		{
			rjProductName_tbx.PlaceholderText = "Name";
			rjProductDescription_tbx.PlaceholderText = "Product Description";
			rjProductPrice_tbx.PlaceholderText = "Price";
			rjProductStockNumber_tbx.PlaceholderText = "Stock";
			XL_rbn.Checked = false;
			L_rbn.Checked = false;
			M_rbn.Checked = false;
			S_rbn.Checked = false;
			rjProductList_cbx.Visible = false;
			rjBackGroundOfComboBox_btn.Visible = false;
			rjProductEdit_btn.Visible = true;
			rjEditProduct_btn.Visible = false;
			rjProductDelete_btn.Visible = false;
			rjProductAdd_btn.Visible = true;
			rjAddNewProduct_btn.Visible = false;
			rjCancelAction_btn.Visible = false;
			productImage_pbx.Image = null;
			rjBrowse_btn.Enabled = false;
			rjSave_btn.Enabled = false;
			rjViewProductToCustomer_btn.Visible = false;
			rjNewProductToView_tbx.Visible = false;
			rjOldProductToView_tbx.Visible = false;
			viewProductToCustomer_lbl.Visible = false;
			rjProductInfo_btn.Visible = false;
		}
		IValidateInput validateInput_Obj;
		ICreateEditDeleteProduct addEditDeleteProduct_Obj;
		string productSize;
		private void rjAddNewProduct_btn_Click(object sender, EventArgs e)
		{
			bool validateSize = false;
			validateInput_Obj = new FactoryMethod_ValidateInput().CreateValidateInputInst();        // Re-use Validate input.
			bool validateName = validateInput_Obj.ValidateInput(rjProductName_tbx);
			bool validatePrice = validateInput_Obj.ValidateInput(rjProductPrice_tbx);
			bool validateStock = validateInput_Obj.ValidateInput(rjProductStockNumber_tbx);
			if (XL_rbn.Checked || L_rbn.Checked || M_rbn.Checked || S_rbn.Checked)
			{
				XL_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				L_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				M_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				S_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				validateSize = true;
			}
			else
			{
				XL_rbn.UnCheckedColor = Color.Gray;
				L_rbn.UnCheckedColor = Color.Gray;
				M_rbn.UnCheckedColor = Color.Gray;
				S_rbn.UnCheckedColor = Color.Gray;
				validateSize = false;
			}
			if (validateName && validatePrice && validateStock && validateSize)
			{
				addEditDeleteProduct_Obj = new FactoryMethod_CreateEditDeleteProduct().CreateEditDeleteInst();		// Re-use CreateEditDeleteProduct factory method class.
				bool addNewProduct = addEditDeleteProduct_Obj.AddNewProduct(rjProductName_tbx.Texts,rjProductDescription_tbx.Texts,
									Convert.ToDouble(rjProductPrice_tbx.Texts), Convert.ToInt32(rjProductStockNumber_tbx.Texts), productSize);
				productId = addEditDeleteProduct_Obj.getNewCreatedProductId();
				if (addNewProduct)
				{
					rjAddNewProduct_btn.Visible = false;
					rjBrowse_btn.Enabled = true;
					rjSave_btn.Enabled = true;
					rjViewProductToCustomer_btn.Visible = true;
					rjNewProductToView_tbx.Visible = true;
					rjOldProductToView_tbx.Visible = true;
					viewProductToCustomer_lbl.Visible = true;
					rjProductAdd_btn.Visible = false;
				}

				
			}
			else
			{
				MessageBox.Show("Please fill the missing input", "Missing Data");
			}

			

		}
		ICreateEditDeleteProduct editDeleteProduct_Obj;
		private void rjProductDelete_btn_Click(object sender, EventArgs e)			// Delete the selected product.
		{
			DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this Product and all of its items?", "Delete a Product", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				editDeleteProduct_Obj = new FactoryMethod_CreateEditDeleteProduct().CreateEditDeleteInst();       // Re-Use Factory Method.
				bool deleteProduct = editDeleteProduct_Obj.DeleteProductFromCart(productId, -1);    // Re-use DeleteProductFromCart method. -1 --> means admin side.
				if (deleteProduct)
				{
					MessageBox.Show("The selected product is deleted successfully.", "Delete a Product");
					// Reset the Product's tab fields.
					rjProductName_tbx.PlaceholderText = "Name";
					rjProductDescription_tbx.PlaceholderText = "Product Description";
					rjProductPrice_tbx.PlaceholderText = "Price";
					rjProductStockNumber_tbx.PlaceholderText = "Stock";
					productImage_pbx.Image = null;
					rjBrowse_btn.Enabled = false;
					rjSave_btn.Enabled = false;
					
				}
				
			}
		}

		private void rjViewProductToCustomer_btn_Click(object sender, EventArgs e)		// Display and hide given product on Customer's dashboard.
		{
			ViewProducts_Obj = new FactoryMethod_ViewProduct().GetViewProductInstant();       // Re-Use Factory Method to return an instance of a Concrete ViewProduct.
			if (rjNewProductToView_tbx.Texts == "" || rjOldProductToView_tbx.Texts == "")	// Input's Validation.
			{
				if (rjNewProductToView_tbx.Texts == "")
				{
					rjNewProductToView_tbx.BorderColor = Color.Gray;
				}
				if (rjOldProductToView_tbx.Texts == "")
				{
					rjOldProductToView_tbx.BorderColor = Color.Gray;
				}
						
				MessageBox.Show("Please enter the product's name.", "View product");
			}
			else
			{
				rjOldProductToView_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				rjNewProductToView_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				ViewProducts_Obj.displayProduct(rjNewProductToView_tbx.Texts);		// Display the given product on Customer's dashboard
				ViewProducts_Obj.HideProduct(rjOldProductToView_tbx.Texts);         // Hide the given product on Customer's dashboard
			}
			
		}
		// Get the radio button selected value
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

		

		private void rjProductInfo_btn_Click(object sender, EventArgs e)	// Click search button.
		{
			// Get selected value from the drop-down list.
			if (rjProductList_cbx.SelectedIndex == 0)
			{
				rjProductList_cbx.SelectedIndex += 1;

				if (rjProductList_cbx.SelectedValue.ToString() != "")
					productId = (int)rjProductList_cbx.SelectedValue;
			}
			else if (rjProductList_cbx.SelectedValue.ToString() != "")
				productId = (int)rjProductList_cbx.SelectedValue;
			
			if (rjEditProduct_btn.Visible)
			{
				FillEditProduct(productId);			// Display the product details on admin's dashboard.
			}
		}

	
		public void FillEditProduct(int productId)      // Display the product details on admin's dashboard.
		{
			try
			{
				DataTable dt;
				ProductDetails_Obj = new FactoryMethod_DressDetails().CreateProductDetailsInstance();       // Re-use Factory Method 
				dt = ProductDetails_Obj.GetProductDetails(productId, "ADM");         // Re-use GetProductDetails method.
				bool imageViewed = LoadDressImages(dt);        // View images for selected dress using image list.
				rjProductName_tbx.PlaceholderText = dt.Rows[0]["PR_Name"].ToString();   // Display the product's name.
				rjProductDescription_tbx.PlaceholderText = dt.Rows[0]["PR_Discription"].ToString(); // Display the product's description.
				rjProductPrice_tbx.PlaceholderText = "$" + dt.Rows[0]["PR_Price"].ToString();   // Display the product's price.
				rjProductStockNumber_tbx.PlaceholderText = dt.Rows[0]["PR_Stock_Qantity"].ToString();   // Display the product's size.
				switch (dt.Rows[0]["PR_Size"].ToString())		// Display the product's size.
				{
					case "XL":
						{
							XL_rbn.Checked = true;
							productSize = "XL";
							break;
						}
					case "L":
						{
							L_rbn.Checked = true;
							productSize = "L";
							break;
						}
					case "M":
						{
							M_rbn.Checked = true;
							productSize = "M";
							break;
						}
					default:
						{
							S_rbn.Checked = true;
							productSize = "S";
							break;
						}
				}
				if (imageViewed)
				{
					rjBrowse_btn.Enabled = true;
					rjSave_btn.Enabled = true;
				}
				else
				{
					rjBrowse_btn.Enabled = true;
					rjSave_btn.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void PaymentGrid_tmr_Tick(object sender, EventArgs e)
		{
			Payment_Obj = new FactoryMethod_Bill().CreateBillInstance();            // Re-use the Bill Factory classes.
			displayPaymentList = DisplayPymentsDataGrid(Payment_dgv, Payment_Obj.getPaymentList());   // Re-use the Bill Factory classes.
			Order_obj = new FactoryMethod_Order().CreateOrderInstance();    // Re-use the Order Factory Method pattern.
			displayOrderList = DisplayOrdersDataGrid(order_dgv, Order_obj.GetOrderDetails(-1));  // Re-use GetOrderDetails method --> pass -1 for Admin.

			Grid_tmr.Start();
		}

		public bool LoadDressImages(DataTable image_dt)        // Feed the image list with images from the data table.
		{
			foreach (DataRow dr in image_dt.Rows)
			{
				if (dr["PR_Main_Image"].ToString() != "")
				{
					byte[] img = (byte[])dr["PR_Main_Image"];         // Save the image into bynary array.
					MemoryStream ms = new MemoryStream(img);
					productImage_pbx.Image = Image.FromStream(ms);
				}
				else
					productImage_pbx.Image = null;

			}
			if (productImage_pbx.Image != null)
				return true;
			else
				return false;
			
		}

		private void rjStopTimer_btn_Click(object sender, EventArgs e)		// To Stop Timer to Edit the Payment Grid
		{
			Grid_tmr.Stop();				// Stop the timer.
			rjPaymentEdit_btn.Enabled = true;			// Enable the Edit payment button.
			int rows = Convert.ToInt32(Payment_dgv.Rows.Count.ToString());		// Count the grid rows.
			for (int i = 0; i< rows; i++)
			{
				Payment_dgv.Rows[i].Cells[0].ReadOnly = true;		// Make Payment Id column as a read only.
				Payment_dgv.Rows[i].Cells[1].ReadOnly = true;       // Make Order Id column as a read only.
				Payment_dgv.Rows[i].Cells[2].ReadOnly = true;       // Make Customer Id column as a read only.
				Payment_dgv.Rows[i].Cells[3].ReadOnly = true;       // Make Customer Name column as a read only.
				Payment_dgv.Rows[i].Cells[4].ReadOnly = true;       // Make Total column as a read only.
				Payment_dgv.Rows[i].Cells[5].ReadOnly = true;       // Make Issue Date column as a read only.

			}

		}

		private void rjEditProduct_btn_Click(object sender, EventArgs e)		// Save edited product. 
		{

			bool validateSize = false;
			validateInput_Obj = new FactoryMethod_ValidateInput().CreateValidateInputInst();        // Re-use Validate input.
			bool validateName = validateInput_Obj.ValidateInput(rjProductName_tbx);
			bool validatePrice = validateInput_Obj.ValidateInput(rjProductPrice_tbx);
			bool validateStock = validateInput_Obj.ValidateInput(rjProductStockNumber_tbx);
			if (XL_rbn.Checked || L_rbn.Checked || M_rbn.Checked || S_rbn.Checked)
			{
				XL_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				L_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				M_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				S_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				validateSize = true;
			}
			else
			{
				XL_rbn.UnCheckedColor = Color.Gray;
				L_rbn.UnCheckedColor = Color.Gray;
				M_rbn.UnCheckedColor = Color.Gray;
				S_rbn.UnCheckedColor = Color.Gray;
				validateSize = false;
			}
			if (validateName && validatePrice && validateStock && validateSize && (productId !=0))
			{
				// Re-use CreateEditDeleteProduct factory method class.
				addEditDeleteProduct_Obj = new FactoryMethod_CreateEditDeleteProduct().CreateEditDeleteInst();   
				// Use EditProduct method.
				bool EditProduct = addEditDeleteProduct_Obj.EditProduct(productId,returnText(rjProductName_tbx), returnText(rjProductDescription_tbx),
									Convert.ToDouble(RemoveSpecialCharacters(returnText(rjProductPrice_tbx))), 
									Convert.ToInt32(returnText(rjProductStockNumber_tbx)), productSize);
				
				if (EditProduct)
				{
					MessageBox.Show("Your product is updated successfully.", "Update Product");
				}


			}
			else
			{
				MessageBox.Show("Please fill the missing input", "Missing Data");
			}

		}

	

		public string returnText(RJCodeAdvance.RJControls.RJTextBox textBox)		// Remove special characters from given text. 
		{
			string text ="";
			if (textBox.Texts == "")
			{
				if (textBox.PlaceholderText == "")
					MessageBox.Show("Please fill in the missing fields", "missing info");
				else
					text = textBox.PlaceholderText;
			}
			else
				text = textBox.Texts;
			return text;
		}

		private void rjPaymentCancel_btn_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}

		string paymentId;

		private void rjStopOrderTimer_btn_Click(object sender, EventArgs e)     // To Stop the Timer to Edit the Order Grid
		{
			Grid_tmr.Stop();        // Stop the timer.
			rjOrderEdit_btn.Enabled = true;     // Enable the Edit payment button.
			int rows = Convert.ToInt32(order_dgv.Rows.Count.ToString());            // Count the grid rows.
			for (int i = 0; i < rows; i++)
			{
				order_dgv.Rows[i].Cells[0].ReadOnly = true;     // Make Order Id column as a read only.
				order_dgv.Rows[i].Cells[1].ReadOnly = true;     // Make Customer Id column as a read only.
				order_dgv.Rows[i].Cells[2].ReadOnly = true;     // Make Customer Name column as a read only.
				order_dgv.Rows[i].Cells[3].ReadOnly = true;     // Make Quantity column as a read only.
				order_dgv.Rows[i].Cells[4].ReadOnly = true;     // Make Price column as a read only.
				order_dgv.Rows[i].Cells[7].ReadOnly = true;     // Make Total Price column as a read only.
				order_dgv.Rows[i].Cells[8].ReadOnly = true;     // Make Issue Date column as a read only.
				order_dgv.Rows[i].Cells[9].ReadOnly = true;     // Make status column as a read only.

			}

		}

		private void rjPaymentDelete_btn_Click(object sender, EventArgs e)			// Delete selected payment record.
		{
			int rowindex = Payment_dgv.CurrentCell.RowIndex;	// Get the selected row index.
			paymentId = Payment_dgv.Rows[rowindex].Cells[0].Value.ToString();		// Get the Payment Id from the selected row.
			Payment_Obj = new FactoryMethod_Bill().CreateBillInstance();        // Re-use the IBill interface.
			// Use the Yes/No dialog message box.
			DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete the selected Payment?", "Delete Payment", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)			// If the user click Yes.
			{
				bool deletePayment = Payment_Obj.deleteSelectedPayment(paymentId);      // Use deleteSelectedPayment method to delete selected Payment record.
				if (deletePayment)
				{
					MessageBox.Show("The selected Payment is deleted", "Delete Payment");
					
				}
			}
			
		}
		
	}
}
