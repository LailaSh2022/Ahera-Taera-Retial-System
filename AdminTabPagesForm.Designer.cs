
namespace SWD604_Task2_RetialCustomerManagementSystem
{
	partial class AdminTabPagesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.admin_Tbs = new System.Windows.Forms.TabControl();
			this.adminPayment_tb = new System.Windows.Forms.TabPage();
			this.paymentSideButtons_pnl = new System.Windows.Forms.Panel();
			this.rjStopTimer_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjPaymentDelete_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjPaymentEdit_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjPaymentCancel_btn = new RJCodeAdvance.RJControls.RJButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.paymentTotal_lbl = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Payment_dgv = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.adminOrder_tb = new System.Windows.Forms.TabPage();
			this.orderSideButtons_pnl = new System.Windows.Forms.Panel();
			this.rjStopOrderTimer_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjOrderDelete_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjOrderEdit_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjOrderCancel_btn = new RJCodeAdvance.RJControls.RJButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.totalOrders_lbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.orderSummary_lbl = new System.Windows.Forms.Label();
			this.order_dgv = new System.Windows.Forms.DataGridView();
			this.order_lbl = new System.Windows.Forms.Label();
			this.adminProduct_tb = new System.Windows.Forms.TabPage();
			this.rjProductInfo_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjProductList_cbx = new System.Windows.Forms.ComboBox();
			this.rjCancelAction_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjAddNewProduct_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjEditProduct_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjProductAdd_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjProductDelete_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjProductEdit_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjViewProductToCustomer_btn = new RJCodeAdvance.RJControls.RJButton();
			this.viewProductToCustomer_lbl = new System.Windows.Forms.Label();
			this.rjOldProductToView_tbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.rjNewProductToView_tbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.rjUploadMainImage_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.S_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.M_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.L_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.XL_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.rjProductName_tbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.rjProductDescription_tbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.rjSave_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjProductPrice_tbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.rjProductStockNumber_tbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.rjBrowse_btn = new RJCodeAdvance.RJControls.RJButton();
			this.productImage_pbx = new System.Windows.Forms.PictureBox();
			this.Title_lbl = new System.Windows.Forms.Label();
			this.rjBackGroundOfComboBox_btn = new RJCodeAdvance.RJControls.RJButton();
			this.productImage_lst = new System.Windows.Forms.ImageList(this.components);
			this.Grid_tmr = new System.Windows.Forms.Timer(this.components);
			this.admin_Tbs.SuspendLayout();
			this.adminPayment_tb.SuspendLayout();
			this.paymentSideButtons_pnl.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Payment_dgv)).BeginInit();
			this.adminOrder_tb.SuspendLayout();
			this.orderSideButtons_pnl.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.order_dgv)).BeginInit();
			this.adminProduct_tb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productImage_pbx)).BeginInit();
			this.SuspendLayout();
			// 
			// admin_Tbs
			// 
			this.admin_Tbs.Controls.Add(this.adminPayment_tb);
			this.admin_Tbs.Controls.Add(this.adminOrder_tb);
			this.admin_Tbs.Controls.Add(this.adminProduct_tb);
			this.admin_Tbs.Location = new System.Drawing.Point(-1, 0);
			this.admin_Tbs.Name = "admin_Tbs";
			this.admin_Tbs.SelectedIndex = 0;
			this.admin_Tbs.Size = new System.Drawing.Size(1095, 627);
			this.admin_Tbs.TabIndex = 0;
			this.admin_Tbs.SelectedIndexChanged += new System.EventHandler(this.admin_Tbs_SelectedIndexChanged);
			// 
			// adminPayment_tb
			// 
			this.adminPayment_tb.Controls.Add(this.paymentSideButtons_pnl);
			this.adminPayment_tb.Controls.Add(this.rjPaymentCancel_btn);
			this.adminPayment_tb.Controls.Add(this.panel1);
			this.adminPayment_tb.Controls.Add(this.label7);
			this.adminPayment_tb.Location = new System.Drawing.Point(4, 25);
			this.adminPayment_tb.Name = "adminPayment_tb";
			this.adminPayment_tb.Padding = new System.Windows.Forms.Padding(3);
			this.adminPayment_tb.Size = new System.Drawing.Size(1087, 598);
			this.adminPayment_tb.TabIndex = 0;
			this.adminPayment_tb.Text = "Payment";
			this.adminPayment_tb.UseVisualStyleBackColor = true;
			// 
			// paymentSideButtons_pnl
			// 
			this.paymentSideButtons_pnl.BackColor = System.Drawing.SystemColors.Control;
			this.paymentSideButtons_pnl.Controls.Add(this.rjStopTimer_btn);
			this.paymentSideButtons_pnl.Controls.Add(this.rjPaymentDelete_btn);
			this.paymentSideButtons_pnl.Controls.Add(this.rjPaymentEdit_btn);
			this.paymentSideButtons_pnl.Location = new System.Drawing.Point(826, 158);
			this.paymentSideButtons_pnl.Name = "paymentSideButtons_pnl";
			this.paymentSideButtons_pnl.Size = new System.Drawing.Size(240, 357);
			this.paymentSideButtons_pnl.TabIndex = 15;
			// 
			// rjStopTimer_btn
			// 
			this.rjStopTimer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjStopTimer_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjStopTimer_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjStopTimer_btn.BorderRadius = 7;
			this.rjStopTimer_btn.BorderSize = 0;
			this.rjStopTimer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjStopTimer_btn.FlatAppearance.BorderSize = 0;
			this.rjStopTimer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjStopTimer_btn.ForeColor = System.Drawing.Color.White;
			this.rjStopTimer_btn.Location = new System.Drawing.Point(31, 92);
			this.rjStopTimer_btn.Name = "rjStopTimer_btn";
			this.rjStopTimer_btn.Size = new System.Drawing.Size(180, 43);
			this.rjStopTimer_btn.TabIndex = 0;
			this.rjStopTimer_btn.Text = "Stop Timer to Edit";
			this.rjStopTimer_btn.TextColor = System.Drawing.Color.White;
			this.rjStopTimer_btn.UseVisualStyleBackColor = false;
			this.rjStopTimer_btn.Click += new System.EventHandler(this.rjStopTimer_btn_Click);
			// 
			// rjPaymentDelete_btn
			// 
			this.rjPaymentDelete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentDelete_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentDelete_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentDelete_btn.BorderRadius = 7;
			this.rjPaymentDelete_btn.BorderSize = 0;
			this.rjPaymentDelete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjPaymentDelete_btn.FlatAppearance.BorderSize = 0;
			this.rjPaymentDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjPaymentDelete_btn.ForeColor = System.Drawing.Color.White;
			this.rjPaymentDelete_btn.Location = new System.Drawing.Point(31, 223);
			this.rjPaymentDelete_btn.Name = "rjPaymentDelete_btn";
			this.rjPaymentDelete_btn.Size = new System.Drawing.Size(180, 43);
			this.rjPaymentDelete_btn.TabIndex = 2;
			this.rjPaymentDelete_btn.Text = "Delete";
			this.rjPaymentDelete_btn.TextColor = System.Drawing.Color.White;
			this.rjPaymentDelete_btn.UseVisualStyleBackColor = false;
			this.rjPaymentDelete_btn.Click += new System.EventHandler(this.rjPaymentDelete_btn_Click);
			// 
			// rjPaymentEdit_btn
			// 
			this.rjPaymentEdit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentEdit_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentEdit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentEdit_btn.BorderRadius = 7;
			this.rjPaymentEdit_btn.BorderSize = 0;
			this.rjPaymentEdit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjPaymentEdit_btn.Enabled = false;
			this.rjPaymentEdit_btn.FlatAppearance.BorderSize = 0;
			this.rjPaymentEdit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjPaymentEdit_btn.ForeColor = System.Drawing.Color.White;
			this.rjPaymentEdit_btn.Location = new System.Drawing.Point(31, 159);
			this.rjPaymentEdit_btn.Name = "rjPaymentEdit_btn";
			this.rjPaymentEdit_btn.Size = new System.Drawing.Size(180, 43);
			this.rjPaymentEdit_btn.TabIndex = 1;
			this.rjPaymentEdit_btn.Text = "Edit";
			this.rjPaymentEdit_btn.TextColor = System.Drawing.Color.White;
			this.rjPaymentEdit_btn.UseVisualStyleBackColor = false;
			this.rjPaymentEdit_btn.Click += new System.EventHandler(this.rjPaymentEdit_btn_Click);
			// 
			// rjPaymentCancel_btn
			// 
			this.rjPaymentCancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentCancel_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentCancel_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPaymentCancel_btn.BorderRadius = 7;
			this.rjPaymentCancel_btn.BorderSize = 0;
			this.rjPaymentCancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjPaymentCancel_btn.FlatAppearance.BorderSize = 0;
			this.rjPaymentCancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjPaymentCancel_btn.ForeColor = System.Drawing.Color.White;
			this.rjPaymentCancel_btn.Location = new System.Drawing.Point(857, 530);
			this.rjPaymentCancel_btn.Name = "rjPaymentCancel_btn";
			this.rjPaymentCancel_btn.Size = new System.Drawing.Size(180, 43);
			this.rjPaymentCancel_btn.TabIndex = 2;
			this.rjPaymentCancel_btn.Text = "Cancel";
			this.rjPaymentCancel_btn.TextColor = System.Drawing.Color.White;
			this.rjPaymentCancel_btn.UseVisualStyleBackColor = false;
			this.rjPaymentCancel_btn.Visible = false;
			this.rjPaymentCancel_btn.Click += new System.EventHandler(this.rjPaymentCancel_btn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.Payment_dgv);
			this.panel1.Location = new System.Drawing.Point(3, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(793, 495);
			this.panel1.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.paymentTotal_lbl);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(20, 395);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(743, 84);
			this.panel2.TabIndex = 15;
			// 
			// paymentTotal_lbl
			// 
			this.paymentTotal_lbl.AutoSize = true;
			this.paymentTotal_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paymentTotal_lbl.Location = new System.Drawing.Point(584, 32);
			this.paymentTotal_lbl.Name = "paymentTotal_lbl";
			this.paymentTotal_lbl.Size = new System.Drawing.Size(120, 26);
			this.paymentTotal_lbl.TabIndex = 16;
			this.paymentTotal_lbl.Text = "NZ$000.00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(443, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 26);
			this.label6.TabIndex = 12;
			this.label6.Text = "Total";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.label1.Location = new System.Drawing.Point(26, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 19);
			this.label1.TabIndex = 14;
			this.label1.Text = "Payment Summary";
			// 
			// Payment_dgv
			// 
			this.Payment_dgv.AllowUserToAddRows = false;
			this.Payment_dgv.AllowUserToDeleteRows = false;
			this.Payment_dgv.AllowUserToOrderColumns = true;
			this.Payment_dgv.BackgroundColor = System.Drawing.Color.White;
			this.Payment_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Payment_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Payment_dgv.Location = new System.Drawing.Point(20, 47);
			this.Payment_dgv.Name = "Payment_dgv";
			this.Payment_dgv.RowHeadersWidth = 51;
			this.Payment_dgv.RowTemplate.Height = 24;
			this.Payment_dgv.Size = new System.Drawing.Size(743, 350);
			this.Payment_dgv.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.label7.Location = new System.Drawing.Point(320, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(358, 88);
			this.label7.TabIndex = 12;
			this.label7.Text = "Payments";
			// 
			// adminOrder_tb
			// 
			this.adminOrder_tb.Controls.Add(this.orderSideButtons_pnl);
			this.adminOrder_tb.Controls.Add(this.rjOrderCancel_btn);
			this.adminOrder_tb.Controls.Add(this.panel5);
			this.adminOrder_tb.Controls.Add(this.order_lbl);
			this.adminOrder_tb.Location = new System.Drawing.Point(4, 25);
			this.adminOrder_tb.Name = "adminOrder_tb";
			this.adminOrder_tb.Padding = new System.Windows.Forms.Padding(3);
			this.adminOrder_tb.Size = new System.Drawing.Size(1087, 598);
			this.adminOrder_tb.TabIndex = 1;
			this.adminOrder_tb.Text = "Order";
			this.adminOrder_tb.UseVisualStyleBackColor = true;
			// 
			// orderSideButtons_pnl
			// 
			this.orderSideButtons_pnl.BackColor = System.Drawing.SystemColors.Control;
			this.orderSideButtons_pnl.Controls.Add(this.rjStopOrderTimer_btn);
			this.orderSideButtons_pnl.Controls.Add(this.rjOrderDelete_btn);
			this.orderSideButtons_pnl.Controls.Add(this.rjOrderEdit_btn);
			this.orderSideButtons_pnl.Location = new System.Drawing.Point(901, 161);
			this.orderSideButtons_pnl.Name = "orderSideButtons_pnl";
			this.orderSideButtons_pnl.Size = new System.Drawing.Size(174, 357);
			this.orderSideButtons_pnl.TabIndex = 18;
			// 
			// rjStopOrderTimer_btn
			// 
			this.rjStopOrderTimer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjStopOrderTimer_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjStopOrderTimer_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjStopOrderTimer_btn.BorderRadius = 7;
			this.rjStopOrderTimer_btn.BorderSize = 0;
			this.rjStopOrderTimer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjStopOrderTimer_btn.FlatAppearance.BorderSize = 0;
			this.rjStopOrderTimer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjStopOrderTimer_btn.ForeColor = System.Drawing.Color.White;
			this.rjStopOrderTimer_btn.Location = new System.Drawing.Point(17, 92);
			this.rjStopOrderTimer_btn.Name = "rjStopOrderTimer_btn";
			this.rjStopOrderTimer_btn.Size = new System.Drawing.Size(144, 43);
			this.rjStopOrderTimer_btn.TabIndex = 0;
			this.rjStopOrderTimer_btn.Text = "Stop Timer to Edit";
			this.rjStopOrderTimer_btn.TextColor = System.Drawing.Color.White;
			this.rjStopOrderTimer_btn.UseVisualStyleBackColor = false;
			this.rjStopOrderTimer_btn.Click += new System.EventHandler(this.rjStopOrderTimer_btn_Click);
			// 
			// rjOrderDelete_btn
			// 
			this.rjOrderDelete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderDelete_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderDelete_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderDelete_btn.BorderRadius = 7;
			this.rjOrderDelete_btn.BorderSize = 0;
			this.rjOrderDelete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjOrderDelete_btn.FlatAppearance.BorderSize = 0;
			this.rjOrderDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjOrderDelete_btn.ForeColor = System.Drawing.Color.White;
			this.rjOrderDelete_btn.Location = new System.Drawing.Point(17, 215);
			this.rjOrderDelete_btn.Name = "rjOrderDelete_btn";
			this.rjOrderDelete_btn.Size = new System.Drawing.Size(144, 43);
			this.rjOrderDelete_btn.TabIndex = 2;
			this.rjOrderDelete_btn.Text = "Delete";
			this.rjOrderDelete_btn.TextColor = System.Drawing.Color.White;
			this.rjOrderDelete_btn.UseVisualStyleBackColor = false;
			this.rjOrderDelete_btn.Click += new System.EventHandler(this.rjOrderDelete_btn_Click);
			// 
			// rjOrderEdit_btn
			// 
			this.rjOrderEdit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderEdit_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderEdit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderEdit_btn.BorderRadius = 7;
			this.rjOrderEdit_btn.BorderSize = 0;
			this.rjOrderEdit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjOrderEdit_btn.Enabled = false;
			this.rjOrderEdit_btn.FlatAppearance.BorderSize = 0;
			this.rjOrderEdit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjOrderEdit_btn.ForeColor = System.Drawing.Color.White;
			this.rjOrderEdit_btn.Location = new System.Drawing.Point(17, 151);
			this.rjOrderEdit_btn.Name = "rjOrderEdit_btn";
			this.rjOrderEdit_btn.Size = new System.Drawing.Size(144, 43);
			this.rjOrderEdit_btn.TabIndex = 1;
			this.rjOrderEdit_btn.Text = "Edit";
			this.rjOrderEdit_btn.TextColor = System.Drawing.Color.White;
			this.rjOrderEdit_btn.UseVisualStyleBackColor = false;
			this.rjOrderEdit_btn.Click += new System.EventHandler(this.rjOrderEdit_btn_Click);
			// 
			// rjOrderCancel_btn
			// 
			this.rjOrderCancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderCancel_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderCancel_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOrderCancel_btn.BorderRadius = 7;
			this.rjOrderCancel_btn.BorderSize = 0;
			this.rjOrderCancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rjOrderCancel_btn.FlatAppearance.BorderSize = 0;
			this.rjOrderCancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjOrderCancel_btn.ForeColor = System.Drawing.Color.White;
			this.rjOrderCancel_btn.Location = new System.Drawing.Point(918, 533);
			this.rjOrderCancel_btn.Name = "rjOrderCancel_btn";
			this.rjOrderCancel_btn.Size = new System.Drawing.Size(144, 43);
			this.rjOrderCancel_btn.TabIndex = 2;
			this.rjOrderCancel_btn.Text = "Cancel";
			this.rjOrderCancel_btn.TextColor = System.Drawing.Color.White;
			this.rjOrderCancel_btn.UseVisualStyleBackColor = false;
			this.rjOrderCancel_btn.Visible = false;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Control;
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.orderSummary_lbl);
			this.panel5.Controls.Add(this.order_dgv);
			this.panel5.Location = new System.Drawing.Point(12, 97);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(868, 495);
			this.panel5.TabIndex = 17;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.totalOrders_lbl);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Location = new System.Drawing.Point(20, 395);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(822, 84);
			this.panel6.TabIndex = 15;
			// 
			// totalOrders_lbl
			// 
			this.totalOrders_lbl.AutoSize = true;
			this.totalOrders_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalOrders_lbl.Location = new System.Drawing.Point(584, 32);
			this.totalOrders_lbl.Name = "totalOrders_lbl";
			this.totalOrders_lbl.Size = new System.Drawing.Size(120, 26);
			this.totalOrders_lbl.TabIndex = 16;
			this.totalOrders_lbl.Text = "NZ$000.00";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(443, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 26);
			this.label3.TabIndex = 12;
			this.label3.Text = "Total";
			// 
			// orderSummary_lbl
			// 
			this.orderSummary_lbl.AutoSize = true;
			this.orderSummary_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderSummary_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.orderSummary_lbl.Location = new System.Drawing.Point(26, 16);
			this.orderSummary_lbl.Name = "orderSummary_lbl";
			this.orderSummary_lbl.Size = new System.Drawing.Size(126, 19);
			this.orderSummary_lbl.TabIndex = 14;
			this.orderSummary_lbl.Text = "Order Summary";
			// 
			// order_dgv
			// 
			this.order_dgv.AllowUserToAddRows = false;
			this.order_dgv.AllowUserToDeleteRows = false;
			this.order_dgv.AllowUserToOrderColumns = true;
			this.order_dgv.BackgroundColor = System.Drawing.Color.White;
			this.order_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.order_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.order_dgv.Location = new System.Drawing.Point(20, 47);
			this.order_dgv.Name = "order_dgv";
			this.order_dgv.RowHeadersWidth = 51;
			this.order_dgv.RowTemplate.Height = 24;
			this.order_dgv.Size = new System.Drawing.Size(822, 350);
			this.order_dgv.TabIndex = 4;
			// 
			// order_lbl
			// 
			this.order_lbl.AutoSize = true;
			this.order_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.order_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.order_lbl.Location = new System.Drawing.Point(329, 6);
			this.order_lbl.Name = "order_lbl";
			this.order_lbl.Size = new System.Drawing.Size(278, 88);
			this.order_lbl.TabIndex = 16;
			this.order_lbl.Text = "Orders";
			// 
			// adminProduct_tb
			// 
			this.adminProduct_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.adminProduct_tb.Controls.Add(this.rjProductInfo_btn);
			this.adminProduct_tb.Controls.Add(this.rjProductList_cbx);
			this.adminProduct_tb.Controls.Add(this.rjCancelAction_btn);
			this.adminProduct_tb.Controls.Add(this.rjAddNewProduct_btn);
			this.adminProduct_tb.Controls.Add(this.rjEditProduct_btn);
			this.adminProduct_tb.Controls.Add(this.rjProductAdd_btn);
			this.adminProduct_tb.Controls.Add(this.rjProductDelete_btn);
			this.adminProduct_tb.Controls.Add(this.rjProductEdit_btn);
			this.adminProduct_tb.Controls.Add(this.rjViewProductToCustomer_btn);
			this.adminProduct_tb.Controls.Add(this.viewProductToCustomer_lbl);
			this.adminProduct_tb.Controls.Add(this.rjOldProductToView_tbx);
			this.adminProduct_tb.Controls.Add(this.rjNewProductToView_tbx);
			this.adminProduct_tb.Controls.Add(this.rjUploadMainImage_rbn);
			this.adminProduct_tb.Controls.Add(this.S_rbn);
			this.adminProduct_tb.Controls.Add(this.M_rbn);
			this.adminProduct_tb.Controls.Add(this.L_rbn);
			this.adminProduct_tb.Controls.Add(this.XL_rbn);
			this.adminProduct_tb.Controls.Add(this.rjProductName_tbx);
			this.adminProduct_tb.Controls.Add(this.rjProductDescription_tbx);
			this.adminProduct_tb.Controls.Add(this.rjSave_btn);
			this.adminProduct_tb.Controls.Add(this.rjProductPrice_tbx);
			this.adminProduct_tb.Controls.Add(this.rjProductStockNumber_tbx);
			this.adminProduct_tb.Controls.Add(this.rjBrowse_btn);
			this.adminProduct_tb.Controls.Add(this.productImage_pbx);
			this.adminProduct_tb.Controls.Add(this.Title_lbl);
			this.adminProduct_tb.Controls.Add(this.rjBackGroundOfComboBox_btn);
			this.adminProduct_tb.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminProduct_tb.Location = new System.Drawing.Point(4, 25);
			this.adminProduct_tb.Name = "adminProduct_tb";
			this.adminProduct_tb.Size = new System.Drawing.Size(1087, 598);
			this.adminProduct_tb.TabIndex = 2;
			this.adminProduct_tb.Text = "Product";
			this.adminProduct_tb.UseVisualStyleBackColor = true;
			// 
			// rjProductInfo_btn
			// 
			this.rjProductInfo_btn.BackColor = System.Drawing.Color.Transparent;
			this.rjProductInfo_btn.BackgroundColor = System.Drawing.Color.Transparent;
			this.rjProductInfo_btn.BackgroundImage = global::SWD604_Task2_RetialCustomerManagementSystem.Properties.Resources.seach_icon_10;
			this.rjProductInfo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.rjProductInfo_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductInfo_btn.BorderRadius = 5;
			this.rjProductInfo_btn.BorderSize = 0;
			this.rjProductInfo_btn.FlatAppearance.BorderSize = 0;
			this.rjProductInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjProductInfo_btn.ForeColor = System.Drawing.Color.White;
			this.rjProductInfo_btn.Location = new System.Drawing.Point(652, 115);
			this.rjProductInfo_btn.Name = "rjProductInfo_btn";
			this.rjProductInfo_btn.Size = new System.Drawing.Size(37, 40);
			this.rjProductInfo_btn.TabIndex = 1;
			this.rjProductInfo_btn.TextColor = System.Drawing.Color.White;
			this.rjProductInfo_btn.UseVisualStyleBackColor = false;
			this.rjProductInfo_btn.Visible = false;
			this.rjProductInfo_btn.Click += new System.EventHandler(this.rjProductInfo_btn_Click);
			// 
			// rjProductList_cbx
			// 
			this.rjProductList_cbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjProductList_cbx.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjProductList_cbx.ForeColor = System.Drawing.Color.DarkGray;
			this.rjProductList_cbx.FormattingEnabled = true;
			this.rjProductList_cbx.Location = new System.Drawing.Point(430, 120);
			this.rjProductList_cbx.Name = "rjProductList_cbx";
			this.rjProductList_cbx.Size = new System.Drawing.Size(208, 30);
			this.rjProductList_cbx.TabIndex = 0;
			// 
			// rjCancelAction_btn
			// 
			this.rjCancelAction_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCancelAction_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCancelAction_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCancelAction_btn.BorderRadius = 5;
			this.rjCancelAction_btn.BorderSize = 0;
			this.rjCancelAction_btn.FlatAppearance.BorderSize = 0;
			this.rjCancelAction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjCancelAction_btn.ForeColor = System.Drawing.Color.White;
			this.rjCancelAction_btn.Location = new System.Drawing.Point(826, 429);
			this.rjCancelAction_btn.Name = "rjCancelAction_btn";
			this.rjCancelAction_btn.Size = new System.Drawing.Size(116, 40);
			this.rjCancelAction_btn.TabIndex = 14;
			this.rjCancelAction_btn.Text = "Cancel";
			this.rjCancelAction_btn.TextColor = System.Drawing.Color.White;
			this.rjCancelAction_btn.UseVisualStyleBackColor = false;
			this.rjCancelAction_btn.Visible = false;
			this.rjCancelAction_btn.Click += new System.EventHandler(this.rjCancelAction_btn_Click);
			// 
			// rjAddNewProduct_btn
			// 
			this.rjAddNewProduct_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjAddNewProduct_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjAddNewProduct_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjAddNewProduct_btn.BorderRadius = 5;
			this.rjAddNewProduct_btn.BorderSize = 0;
			this.rjAddNewProduct_btn.FlatAppearance.BorderSize = 0;
			this.rjAddNewProduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjAddNewProduct_btn.ForeColor = System.Drawing.Color.White;
			this.rjAddNewProduct_btn.Location = new System.Drawing.Point(423, 427);
			this.rjAddNewProduct_btn.Name = "rjAddNewProduct_btn";
			this.rjAddNewProduct_btn.Size = new System.Drawing.Size(254, 40);
			this.rjAddNewProduct_btn.TabIndex = 10;
			this.rjAddNewProduct_btn.Text = "Add New Product";
			this.rjAddNewProduct_btn.TextColor = System.Drawing.Color.White;
			this.rjAddNewProduct_btn.UseVisualStyleBackColor = false;
			this.rjAddNewProduct_btn.Visible = false;
			this.rjAddNewProduct_btn.Click += new System.EventHandler(this.rjAddNewProduct_btn_Click);
			// 
			// rjEditProduct_btn
			// 
			this.rjEditProduct_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjEditProduct_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjEditProduct_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjEditProduct_btn.BorderRadius = 5;
			this.rjEditProduct_btn.BorderSize = 0;
			this.rjEditProduct_btn.FlatAppearance.BorderSize = 0;
			this.rjEditProduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjEditProduct_btn.ForeColor = System.Drawing.Color.White;
			this.rjEditProduct_btn.Location = new System.Drawing.Point(404, 427);
			this.rjEditProduct_btn.Name = "rjEditProduct_btn";
			this.rjEditProduct_btn.Size = new System.Drawing.Size(132, 40);
			this.rjEditProduct_btn.TabIndex = 10;
			this.rjEditProduct_btn.Text = "Edit";
			this.rjEditProduct_btn.TextColor = System.Drawing.Color.White;
			this.rjEditProduct_btn.UseVisualStyleBackColor = false;
			this.rjEditProduct_btn.Visible = false;
			this.rjEditProduct_btn.Click += new System.EventHandler(this.rjEditProduct_btn_Click);
			// 
			// rjProductAdd_btn
			// 
			this.rjProductAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductAdd_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductAdd_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductAdd_btn.BorderRadius = 5;
			this.rjProductAdd_btn.BorderSize = 0;
			this.rjProductAdd_btn.FlatAppearance.BorderSize = 0;
			this.rjProductAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjProductAdd_btn.ForeColor = System.Drawing.Color.White;
			this.rjProductAdd_btn.Location = new System.Drawing.Point(420, 427);
			this.rjProductAdd_btn.Name = "rjProductAdd_btn";
			this.rjProductAdd_btn.Size = new System.Drawing.Size(67, 40);
			this.rjProductAdd_btn.TabIndex = 0;
			this.rjProductAdd_btn.Text = "Add";
			this.rjProductAdd_btn.TextColor = System.Drawing.Color.White;
			this.rjProductAdd_btn.UseVisualStyleBackColor = false;
			this.rjProductAdd_btn.Click += new System.EventHandler(this.rjProductAdd_btn_Click);
			// 
			// rjProductDelete_btn
			// 
			this.rjProductDelete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductDelete_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductDelete_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductDelete_btn.BorderRadius = 5;
			this.rjProductDelete_btn.BorderSize = 0;
			this.rjProductDelete_btn.Enabled = false;
			this.rjProductDelete_btn.FlatAppearance.BorderSize = 0;
			this.rjProductDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjProductDelete_btn.ForeColor = System.Drawing.Color.White;
			this.rjProductDelete_btn.Location = new System.Drawing.Point(542, 427);
			this.rjProductDelete_btn.Name = "rjProductDelete_btn";
			this.rjProductDelete_btn.Size = new System.Drawing.Size(147, 40);
			this.rjProductDelete_btn.TabIndex = 11;
			this.rjProductDelete_btn.Text = "Delete";
			this.rjProductDelete_btn.TextColor = System.Drawing.Color.White;
			this.rjProductDelete_btn.UseVisualStyleBackColor = false;
			this.rjProductDelete_btn.Visible = false;
			this.rjProductDelete_btn.Click += new System.EventHandler(this.rjProductDelete_btn_Click);
			// 
			// rjProductEdit_btn
			// 
			this.rjProductEdit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductEdit_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductEdit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductEdit_btn.BorderRadius = 5;
			this.rjProductEdit_btn.BorderSize = 0;
			this.rjProductEdit_btn.FlatAppearance.BorderSize = 0;
			this.rjProductEdit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjProductEdit_btn.ForeColor = System.Drawing.Color.White;
			this.rjProductEdit_btn.Location = new System.Drawing.Point(559, 427);
			this.rjProductEdit_btn.Name = "rjProductEdit_btn";
			this.rjProductEdit_btn.Size = new System.Drawing.Size(67, 40);
			this.rjProductEdit_btn.TabIndex = 1;
			this.rjProductEdit_btn.Text = "Edit";
			this.rjProductEdit_btn.TextColor = System.Drawing.Color.White;
			this.rjProductEdit_btn.UseVisualStyleBackColor = false;
			this.rjProductEdit_btn.Click += new System.EventHandler(this.rjProductEdit_btn_Click);
			// 
			// rjViewProductToCustomer_btn
			// 
			this.rjViewProductToCustomer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjViewProductToCustomer_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjViewProductToCustomer_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjViewProductToCustomer_btn.BorderRadius = 5;
			this.rjViewProductToCustomer_btn.BorderSize = 0;
			this.rjViewProductToCustomer_btn.FlatAppearance.BorderSize = 0;
			this.rjViewProductToCustomer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjViewProductToCustomer_btn.ForeColor = System.Drawing.Color.White;
			this.rjViewProductToCustomer_btn.Location = new System.Drawing.Point(421, 532);
			this.rjViewProductToCustomer_btn.Name = "rjViewProductToCustomer_btn";
			this.rjViewProductToCustomer_btn.Size = new System.Drawing.Size(268, 40);
			this.rjViewProductToCustomer_btn.TabIndex = 13;
			this.rjViewProductToCustomer_btn.Text = "Display The Product";
			this.rjViewProductToCustomer_btn.TextColor = System.Drawing.Color.White;
			this.rjViewProductToCustomer_btn.UseVisualStyleBackColor = false;
			this.rjViewProductToCustomer_btn.Visible = false;
			this.rjViewProductToCustomer_btn.Click += new System.EventHandler(this.rjViewProductToCustomer_btn_Click);
			// 
			// viewProductToCustomer_lbl
			// 
			this.viewProductToCustomer_lbl.AutoSize = true;
			this.viewProductToCustomer_lbl.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewProductToCustomer_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.viewProductToCustomer_lbl.Location = new System.Drawing.Point(426, 419);
			this.viewProductToCustomer_lbl.Name = "viewProductToCustomer_lbl";
			this.viewProductToCustomer_lbl.Size = new System.Drawing.Size(225, 19);
			this.viewProductToCustomer_lbl.TabIndex = 52;
			this.viewProductToCustomer_lbl.Text = "View Product to Customer";
			this.viewProductToCustomer_lbl.Visible = false;
			// 
			// rjOldProductToView_tbx
			// 
			this.rjOldProductToView_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjOldProductToView_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOldProductToView_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjOldProductToView_tbx.BorderRadius = 5;
			this.rjOldProductToView_tbx.BorderSize = 2;
			this.rjOldProductToView_tbx.Font = new System.Drawing.Font("JetBrains Mono NL", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjOldProductToView_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjOldProductToView_tbx.Location = new System.Drawing.Point(423, 484);
			this.rjOldProductToView_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjOldProductToView_tbx.Multiline = false;
			this.rjOldProductToView_tbx.Name = "rjOldProductToView_tbx";
			this.rjOldProductToView_tbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjOldProductToView_tbx.PasswordChar = false;
			this.rjOldProductToView_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjOldProductToView_tbx.PlaceholderText = "Old Product Name";
			this.rjOldProductToView_tbx.Size = new System.Drawing.Size(226, 36);
			this.rjOldProductToView_tbx.TabIndex = 12;
			this.rjOldProductToView_tbx.Texts = "";
			this.rjOldProductToView_tbx.UnderlinedStyle = false;
			this.rjOldProductToView_tbx.Visible = false;
			// 
			// rjNewProductToView_tbx
			// 
			this.rjNewProductToView_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjNewProductToView_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjNewProductToView_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjNewProductToView_tbx.BorderRadius = 5;
			this.rjNewProductToView_tbx.BorderSize = 2;
			this.rjNewProductToView_tbx.Font = new System.Drawing.Font("JetBrains Mono NL", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjNewProductToView_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjNewProductToView_tbx.Location = new System.Drawing.Point(423, 442);
			this.rjNewProductToView_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjNewProductToView_tbx.Multiline = false;
			this.rjNewProductToView_tbx.Name = "rjNewProductToView_tbx";
			this.rjNewProductToView_tbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjNewProductToView_tbx.PasswordChar = false;
			this.rjNewProductToView_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjNewProductToView_tbx.PlaceholderText = "New Product Name";
			this.rjNewProductToView_tbx.Size = new System.Drawing.Size(226, 36);
			this.rjNewProductToView_tbx.TabIndex = 11;
			this.rjNewProductToView_tbx.Texts = "";
			this.rjNewProductToView_tbx.UnderlinedStyle = false;
			this.rjNewProductToView_tbx.Visible = false;
			// 
			// rjUploadMainImage_rbn
			// 
			this.rjUploadMainImage_rbn.Appearance = System.Windows.Forms.Appearance.Button;
			this.rjUploadMainImage_rbn.AutoSize = true;
			this.rjUploadMainImage_rbn.BackColor = System.Drawing.Color.White;
			this.rjUploadMainImage_rbn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rjUploadMainImage_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.rjUploadMainImage_rbn.Font = new System.Drawing.Font("JetBrains Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjUploadMainImage_rbn.Location = new System.Drawing.Point(67, 447);
			this.rjUploadMainImage_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.rjUploadMainImage_rbn.Name = "rjUploadMainImage_rbn";
			this.rjUploadMainImage_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.rjUploadMainImage_rbn.Size = new System.Drawing.Size(276, 28);
			this.rjUploadMainImage_rbn.TabIndex = 47;
			this.rjUploadMainImage_rbn.TabStop = true;
			this.rjUploadMainImage_rbn.Text = "Upload Product\'s main image.   ";
			this.rjUploadMainImage_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjUploadMainImage_rbn.UseVisualStyleBackColor = false;
			this.rjUploadMainImage_rbn.CheckedChanged += new System.EventHandler(this.rjUploadMainImage_rbn_CheckedChanged);
			// 
			// S_rbn
			// 
			this.S_rbn.Appearance = System.Windows.Forms.Appearance.Button;
			this.S_rbn.AutoSize = true;
			this.S_rbn.BackColor = System.Drawing.Color.White;
			this.S_rbn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.S_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.S_rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.S_rbn.Location = new System.Drawing.Point(613, 293);
			this.S_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.S_rbn.Name = "S_rbn";
			this.S_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.S_rbn.Size = new System.Drawing.Size(49, 27);
			this.S_rbn.TabIndex = 7;
			this.S_rbn.TabStop = true;
			this.S_rbn.Text = "S   ";
			this.S_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.S_rbn.UseVisualStyleBackColor = false;
			this.S_rbn.CheckedChanged += new System.EventHandler(this.S_rbn_CheckedChanged);
			// 
			// M_rbn
			// 
			this.M_rbn.Appearance = System.Windows.Forms.Appearance.Button;
			this.M_rbn.AutoSize = true;
			this.M_rbn.BackColor = System.Drawing.Color.White;
			this.M_rbn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.M_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.M_rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.M_rbn.Location = new System.Drawing.Point(553, 293);
			this.M_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.M_rbn.Name = "M_rbn";
			this.M_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.M_rbn.Size = new System.Drawing.Size(51, 27);
			this.M_rbn.TabIndex = 6;
			this.M_rbn.TabStop = true;
			this.M_rbn.Text = "M   ";
			this.M_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.M_rbn.UseVisualStyleBackColor = false;
			this.M_rbn.CheckedChanged += new System.EventHandler(this.M_rbn_CheckedChanged);
			// 
			// L_rbn
			// 
			this.L_rbn.Appearance = System.Windows.Forms.Appearance.Button;
			this.L_rbn.AutoSize = true;
			this.L_rbn.BackColor = System.Drawing.Color.White;
			this.L_rbn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.L_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.L_rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.L_rbn.Location = new System.Drawing.Point(495, 293);
			this.L_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.L_rbn.Name = "L_rbn";
			this.L_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.L_rbn.Size = new System.Drawing.Size(48, 27);
			this.L_rbn.TabIndex = 5;
			this.L_rbn.TabStop = true;
			this.L_rbn.Text = "L   ";
			this.L_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.L_rbn.UseVisualStyleBackColor = false;
			this.L_rbn.CheckedChanged += new System.EventHandler(this.L_rbn_CheckedChanged);
			// 
			// XL_rbn
			// 
			this.XL_rbn.Appearance = System.Windows.Forms.Appearance.Button;
			this.XL_rbn.AutoSize = true;
			this.XL_rbn.BackColor = System.Drawing.Color.White;
			this.XL_rbn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.XL_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.XL_rbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.XL_rbn.Location = new System.Drawing.Point(426, 293);
			this.XL_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.XL_rbn.Name = "XL_rbn";
			this.XL_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.XL_rbn.Size = new System.Drawing.Size(53, 27);
			this.XL_rbn.TabIndex = 4;
			this.XL_rbn.TabStop = true;
			this.XL_rbn.Text = "XL  ";
			this.XL_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.XL_rbn.UseVisualStyleBackColor = false;
			this.XL_rbn.CheckedChanged += new System.EventHandler(this.XL_rbn_CheckedChanged);
			// 
			// rjProductName_tbx
			// 
			this.rjProductName_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjProductName_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductName_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductName_tbx.BorderRadius = 5;
			this.rjProductName_tbx.BorderSize = 2;
			this.rjProductName_tbx.Font = new System.Drawing.Font("JetBrains Mono NL", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjProductName_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjProductName_tbx.Location = new System.Drawing.Point(421, 165);
			this.rjProductName_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjProductName_tbx.Multiline = false;
			this.rjProductName_tbx.Name = "rjProductName_tbx";
			this.rjProductName_tbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjProductName_tbx.PasswordChar = false;
			this.rjProductName_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjProductName_tbx.PlaceholderText = "Name";
			this.rjProductName_tbx.Size = new System.Drawing.Size(228, 36);
			this.rjProductName_tbx.TabIndex = 2;
			this.rjProductName_tbx.Texts = "";
			this.rjProductName_tbx.UnderlinedStyle = false;
			// 
			// rjProductDescription_tbx
			// 
			this.rjProductDescription_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjProductDescription_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductDescription_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductDescription_tbx.BorderRadius = 5;
			this.rjProductDescription_tbx.BorderSize = 2;
			this.rjProductDescription_tbx.Font = new System.Drawing.Font("JetBrains Mono NL", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjProductDescription_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjProductDescription_tbx.Location = new System.Drawing.Point(420, 209);
			this.rjProductDescription_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjProductDescription_tbx.Multiline = true;
			this.rjProductDescription_tbx.Name = "rjProductDescription_tbx";
			this.rjProductDescription_tbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjProductDescription_tbx.PasswordChar = false;
			this.rjProductDescription_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjProductDescription_tbx.PlaceholderText = "Description";
			this.rjProductDescription_tbx.Size = new System.Drawing.Size(228, 73);
			this.rjProductDescription_tbx.TabIndex = 3;
			this.rjProductDescription_tbx.Texts = "";
			this.rjProductDescription_tbx.UnderlinedStyle = false;
			// 
			// rjSave_btn
			// 
			this.rjSave_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjSave_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjSave_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjSave_btn.BorderRadius = 5;
			this.rjSave_btn.BorderSize = 0;
			this.rjSave_btn.Enabled = false;
			this.rjSave_btn.FlatAppearance.BorderSize = 0;
			this.rjSave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjSave_btn.ForeColor = System.Drawing.Color.White;
			this.rjSave_btn.Location = new System.Drawing.Point(199, 532);
			this.rjSave_btn.Name = "rjSave_btn";
			this.rjSave_btn.Size = new System.Drawing.Size(116, 40);
			this.rjSave_btn.TabIndex = 35;
			this.rjSave_btn.Text = "Save Image";
			this.rjSave_btn.TextColor = System.Drawing.Color.White;
			this.rjSave_btn.UseVisualStyleBackColor = false;
			this.rjSave_btn.Click += new System.EventHandler(this.rjSave_btn_Click);
			// 
			// rjProductPrice_tbx
			// 
			this.rjProductPrice_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjProductPrice_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductPrice_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductPrice_tbx.BorderRadius = 5;
			this.rjProductPrice_tbx.BorderSize = 2;
			this.rjProductPrice_tbx.Font = new System.Drawing.Font("JetBrains Mono NL", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjProductPrice_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjProductPrice_tbx.Location = new System.Drawing.Point(420, 330);
			this.rjProductPrice_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjProductPrice_tbx.Multiline = false;
			this.rjProductPrice_tbx.Name = "rjProductPrice_tbx";
			this.rjProductPrice_tbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjProductPrice_tbx.PasswordChar = false;
			this.rjProductPrice_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjProductPrice_tbx.PlaceholderText = "Price";
			this.rjProductPrice_tbx.Size = new System.Drawing.Size(107, 36);
			this.rjProductPrice_tbx.TabIndex = 8;
			this.rjProductPrice_tbx.Texts = "";
			this.rjProductPrice_tbx.UnderlinedStyle = false;
			// 
			// rjProductStockNumber_tbx
			// 
			this.rjProductStockNumber_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjProductStockNumber_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductStockNumber_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProductStockNumber_tbx.BorderRadius = 5;
			this.rjProductStockNumber_tbx.BorderSize = 2;
			this.rjProductStockNumber_tbx.Font = new System.Drawing.Font("JetBrains Mono NL", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjProductStockNumber_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjProductStockNumber_tbx.Location = new System.Drawing.Point(420, 374);
			this.rjProductStockNumber_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjProductStockNumber_tbx.Multiline = false;
			this.rjProductStockNumber_tbx.Name = "rjProductStockNumber_tbx";
			this.rjProductStockNumber_tbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjProductStockNumber_tbx.PasswordChar = false;
			this.rjProductStockNumber_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjProductStockNumber_tbx.PlaceholderText = "Stock";
			this.rjProductStockNumber_tbx.Size = new System.Drawing.Size(107, 36);
			this.rjProductStockNumber_tbx.TabIndex = 9;
			this.rjProductStockNumber_tbx.Texts = "";
			this.rjProductStockNumber_tbx.UnderlinedStyle = false;
			// 
			// rjBrowse_btn
			// 
			this.rjBrowse_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjBrowse_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjBrowse_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjBrowse_btn.BorderRadius = 5;
			this.rjBrowse_btn.BorderSize = 0;
			this.rjBrowse_btn.Enabled = false;
			this.rjBrowse_btn.FlatAppearance.BorderSize = 0;
			this.rjBrowse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjBrowse_btn.ForeColor = System.Drawing.Color.White;
			this.rjBrowse_btn.Location = new System.Drawing.Point(27, 532);
			this.rjBrowse_btn.Name = "rjBrowse_btn";
			this.rjBrowse_btn.Size = new System.Drawing.Size(135, 40);
			this.rjBrowse_btn.TabIndex = 25;
			this.rjBrowse_btn.Text = "Browse Image";
			this.rjBrowse_btn.TextColor = System.Drawing.Color.White;
			this.rjBrowse_btn.UseVisualStyleBackColor = false;
			this.rjBrowse_btn.Click += new System.EventHandler(this.rjBrowse_btn_Click);
			// 
			// productImage_pbx
			// 
			this.productImage_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.productImage_pbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.productImage_pbx.Location = new System.Drawing.Point(108, 114);
			this.productImage_pbx.Name = "productImage_pbx";
			this.productImage_pbx.Size = new System.Drawing.Size(187, 321);
			this.productImage_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.productImage_pbx.TabIndex = 24;
			this.productImage_pbx.TabStop = false;
			// 
			// Title_lbl
			// 
			this.Title_lbl.AutoSize = true;
			this.Title_lbl.BackColor = System.Drawing.Color.Transparent;
			this.Title_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.Title_lbl.Location = new System.Drawing.Point(348, 20);
			this.Title_lbl.Name = "Title_lbl";
			this.Title_lbl.Size = new System.Drawing.Size(278, 76);
			this.Title_lbl.TabIndex = 17;
			this.Title_lbl.Text = "Product";
			this.Title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rjBackGroundOfComboBox_btn
			// 
			this.rjBackGroundOfComboBox_btn.BackColor = System.Drawing.Color.Transparent;
			this.rjBackGroundOfComboBox_btn.BackgroundColor = System.Drawing.Color.Transparent;
			this.rjBackGroundOfComboBox_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjBackGroundOfComboBox_btn.BorderRadius = 5;
			this.rjBackGroundOfComboBox_btn.BorderSize = 2;
			this.rjBackGroundOfComboBox_btn.Enabled = false;
			this.rjBackGroundOfComboBox_btn.FlatAppearance.BorderSize = 0;
			this.rjBackGroundOfComboBox_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjBackGroundOfComboBox_btn.ForeColor = System.Drawing.Color.White;
			this.rjBackGroundOfComboBox_btn.Location = new System.Drawing.Point(422, 111);
			this.rjBackGroundOfComboBox_btn.Name = "rjBackGroundOfComboBox_btn";
			this.rjBackGroundOfComboBox_btn.Size = new System.Drawing.Size(224, 46);
			this.rjBackGroundOfComboBox_btn.TabIndex = 43;
			this.rjBackGroundOfComboBox_btn.TextColor = System.Drawing.Color.White;
			this.rjBackGroundOfComboBox_btn.UseVisualStyleBackColor = false;
			// 
			// productImage_lst
			// 
			this.productImage_lst.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.productImage_lst.ImageSize = new System.Drawing.Size(165, 256);
			this.productImage_lst.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Grid_tmr
			// 
			this.Grid_tmr.Interval = 5000;
			this.Grid_tmr.Tick += new System.EventHandler(this.PaymentGrid_tmr_Tick);
			// 
			// AdminTabPagesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1095, 626);
			this.Controls.Add(this.admin_Tbs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminTabPagesForm";
			this.Text = "AdminTabPagesForm";
			this.Load += new System.EventHandler(this.AdminTabPagesForm_Load);
			this.admin_Tbs.ResumeLayout(false);
			this.adminPayment_tb.ResumeLayout(false);
			this.adminPayment_tb.PerformLayout();
			this.paymentSideButtons_pnl.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Payment_dgv)).EndInit();
			this.adminOrder_tb.ResumeLayout(false);
			this.adminOrder_tb.PerformLayout();
			this.orderSideButtons_pnl.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.order_dgv)).EndInit();
			this.adminProduct_tb.ResumeLayout(false);
			this.adminProduct_tb.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productImage_pbx)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl admin_Tbs;
		private System.Windows.Forms.TabPage adminPayment_tb;
		private System.Windows.Forms.TabPage adminOrder_tb;
		private System.Windows.Forms.TabPage adminProduct_tb;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView Payment_dgv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel paymentSideButtons_pnl;
		private RJCodeAdvance.RJControls.RJButton rjPaymentCancel_btn;
		private RJCodeAdvance.RJControls.RJButton rjPaymentDelete_btn;
		private RJCodeAdvance.RJControls.RJButton rjPaymentEdit_btn;
		private System.Windows.Forms.Label paymentTotal_lbl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel orderSideButtons_pnl;
		private RJCodeAdvance.RJControls.RJButton rjOrderCancel_btn;
		private RJCodeAdvance.RJControls.RJButton rjOrderDelete_btn;
		private RJCodeAdvance.RJControls.RJButton rjOrderEdit_btn;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label totalOrders_lbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label orderSummary_lbl;
		private System.Windows.Forms.DataGridView order_dgv;
		private System.Windows.Forms.Label order_lbl;
		private RJCodeAdvance.RJControls.RJTextBox rjProductName_tbx;
		private RJCodeAdvance.RJControls.RJTextBox rjProductDescription_tbx;
		private RJCodeAdvance.RJControls.RJButton rjSave_btn;
		private RJCodeAdvance.RJControls.RJButton rjProductAdd_btn;
		private RJCodeAdvance.RJControls.RJTextBox rjProductPrice_tbx;
		private RJCodeAdvance.RJControls.RJButton rjProductDelete_btn;
		private RJCodeAdvance.RJControls.RJButton rjProductEdit_btn;
		private RJCodeAdvance.RJControls.RJTextBox rjProductStockNumber_tbx;
		private RJCodeAdvance.RJControls.RJButton rjBrowse_btn;
		private System.Windows.Forms.PictureBox productImage_pbx;
		private System.Windows.Forms.Label Title_lbl;
		private RJCodeAdvance.RJControls.RJRadioButton S_rbn;
		private RJCodeAdvance.RJControls.RJRadioButton M_rbn;
		private RJCodeAdvance.RJControls.RJRadioButton L_rbn;
		private RJCodeAdvance.RJControls.RJRadioButton XL_rbn;
		private RJCodeAdvance.RJControls.RJButton rjBackGroundOfComboBox_btn;
		private RJCodeAdvance.RJControls.RJButton rjEditProduct_btn;
		private System.Windows.Forms.ImageList productImage_lst;
		private RJCodeAdvance.RJControls.RJRadioButton rjUploadMainImage_rbn;
		private RJCodeAdvance.RJControls.RJButton rjAddNewProduct_btn;
		private RJCodeAdvance.RJControls.RJButton rjCancelAction_btn;
		private System.Windows.Forms.Label viewProductToCustomer_lbl;
		private RJCodeAdvance.RJControls.RJTextBox rjOldProductToView_tbx;
		private RJCodeAdvance.RJControls.RJTextBox rjNewProductToView_tbx;
		private RJCodeAdvance.RJControls.RJButton rjViewProductToCustomer_btn;
		private System.Windows.Forms.ComboBox rjProductList_cbx;
		private RJCodeAdvance.RJControls.RJButton rjProductInfo_btn;
		private System.Windows.Forms.Timer Grid_tmr;
		private RJCodeAdvance.RJControls.RJButton rjStopTimer_btn;
		private RJCodeAdvance.RJControls.RJButton rjStopOrderTimer_btn;
	}
}