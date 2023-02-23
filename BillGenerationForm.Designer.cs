
namespace SWD604_Task2_RetialCustomerManagementSystem
{
	partial class BillGenerationForm
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
			this.BillGeneration_pnl = new System.Windows.Forms.Panel();
			this.Back_btn = new RJCodeAdvance.RJControls.RJButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.rjMasterCard_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.rjVisa_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.rjPlaceOrder_btn = new AP4_2.RJControls.RJButton();
			this.rjExpiryDate_tbx = new AP4_2.RJControls.RJTextBox();
			this.rjCVC_CVV_tbx = new AP4_2.RJControls.RJTextBox();
			this.rjCardNumber_tbx = new AP4_2.RJControls.RJTextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.orderNumber_lbl = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.total_lbl = new System.Windows.Forms.Label();
			this.discount_lbl = new System.Windows.Forms.Label();
			this.delivary_lbl = new System.Windows.Forms.Label();
			this.subTotal_lbl = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.orderListView_lsv = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BillGeneration_pnl.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BillGeneration_pnl
			// 
			this.BillGeneration_pnl.BackColor = System.Drawing.Color.White;
			this.BillGeneration_pnl.Controls.Add(this.Back_btn);
			this.BillGeneration_pnl.Controls.Add(this.panel4);
			this.BillGeneration_pnl.Controls.Add(this.panel1);
			this.BillGeneration_pnl.Controls.Add(this.label7);
			this.BillGeneration_pnl.Location = new System.Drawing.Point(-1, 0);
			this.BillGeneration_pnl.Name = "BillGeneration_pnl";
			this.BillGeneration_pnl.Size = new System.Drawing.Size(1098, 626);
			this.BillGeneration_pnl.TabIndex = 0;
			this.BillGeneration_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.BillGeneration_pnl_Paint);
			// 
			// Back_btn
			// 
			this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.Back_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.Back_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.Back_btn.BorderRadius = 5;
			this.Back_btn.BorderSize = 0;
			this.Back_btn.FlatAppearance.BorderSize = 0;
			this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Back_btn.ForeColor = System.Drawing.Color.White;
			this.Back_btn.Location = new System.Drawing.Point(13, 548);
			this.Back_btn.Name = "Back_btn";
			this.Back_btn.Size = new System.Drawing.Size(67, 40);
			this.Back_btn.TabIndex = 14;
			this.Back_btn.Text = "Back";
			this.Back_btn.TextColor = System.Drawing.Color.White;
			this.Back_btn.UseVisualStyleBackColor = false;
			this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Control;
			this.panel4.Controls.Add(this.rjMasterCard_rbn);
			this.panel4.Controls.Add(this.rjVisa_rbn);
			this.panel4.Controls.Add(this.pictureBox3);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.rjPlaceOrder_btn);
			this.panel4.Controls.Add(this.rjExpiryDate_tbx);
			this.panel4.Controls.Add(this.rjCVC_CVV_tbx);
			this.panel4.Controls.Add(this.rjCardNumber_tbx);
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Location = new System.Drawing.Point(597, 96);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(480, 492);
			this.panel4.TabIndex = 13;
			// 
			// rjMasterCard_rbn
			// 
			this.rjMasterCard_rbn.Appearance = System.Windows.Forms.Appearance.Button;
			this.rjMasterCard_rbn.AutoSize = true;
			this.rjMasterCard_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjMasterCard_rbn.Location = new System.Drawing.Point(202, 31);
			this.rjMasterCard_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.rjMasterCard_rbn.Name = "rjMasterCard_rbn";
			this.rjMasterCard_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.rjMasterCard_rbn.Size = new System.Drawing.Size(32, 27);
			this.rjMasterCard_rbn.TabIndex = 17;
			this.rjMasterCard_rbn.TabStop = true;
			this.rjMasterCard_rbn.Text = " ";
			this.rjMasterCard_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjMasterCard_rbn.UseVisualStyleBackColor = true;
			this.rjMasterCard_rbn.CheckedChanged += new System.EventHandler(this.rjMasterCard_rbn_CheckedChanged);
			// 
			// rjVisa_rbn
			// 
			this.rjVisa_rbn.Appearance = System.Windows.Forms.Appearance.Button;
			this.rjVisa_rbn.AutoSize = true;
			this.rjVisa_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjVisa_rbn.Location = new System.Drawing.Point(103, 31);
			this.rjVisa_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.rjVisa_rbn.Name = "rjVisa_rbn";
			this.rjVisa_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.rjVisa_rbn.Size = new System.Drawing.Size(32, 27);
			this.rjVisa_rbn.TabIndex = 16;
			this.rjVisa_rbn.TabStop = true;
			this.rjVisa_rbn.Text = " ";
			this.rjVisa_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjVisa_rbn.UseVisualStyleBackColor = true;
			this.rjVisa_rbn.CheckedChanged += new System.EventHandler(this.rjVisa_rbn_CheckedChanged);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::SWD604_Task2_RetialCustomerManagementSystem.Properties.Resources.Payment_Logo;
			this.pictureBox3.Location = new System.Drawing.Point(67, 383);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(311, 64);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(36, 356);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(361, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "By placing your order, you agree to our Privacy Policy and Terms & Conditions";
			// 
			// rjPlaceOrder_btn
			// 
			this.rjPlaceOrder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPlaceOrder_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPlaceOrder_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjPlaceOrder_btn.BorderRadius = 5;
			this.rjPlaceOrder_btn.BorderSize = 0;
			this.rjPlaceOrder_btn.FlatAppearance.BorderSize = 0;
			this.rjPlaceOrder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjPlaceOrder_btn.ForeColor = System.Drawing.Color.White;
			this.rjPlaceOrder_btn.Location = new System.Drawing.Point(31, 282);
			this.rjPlaceOrder_btn.Name = "rjPlaceOrder_btn";
			this.rjPlaceOrder_btn.Size = new System.Drawing.Size(390, 60);
			this.rjPlaceOrder_btn.TabIndex = 5;
			this.rjPlaceOrder_btn.Text = "Place your Order";
			this.rjPlaceOrder_btn.TextColor = System.Drawing.Color.White;
			this.rjPlaceOrder_btn.UseVisualStyleBackColor = false;
			this.rjPlaceOrder_btn.Click += new System.EventHandler(this.rjPlaceOrder_btn_Click);
			// 
			// rjExpiryDate_tbx
			// 
			this.rjExpiryDate_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjExpiryDate_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjExpiryDate_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjExpiryDate_tbx.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjExpiryDate_tbx.BorderRadius = 5;
			this.rjExpiryDate_tbx.BorderSize = 2;
			this.rjExpiryDate_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjExpiryDate_tbx.ForeColor = System.Drawing.Color.DimGray;
			this.rjExpiryDate_tbx.IsFocused = false;
			this.rjExpiryDate_tbx.Location = new System.Drawing.Point(31, 164);
			this.rjExpiryDate_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjExpiryDate_tbx.Multiline = false;
			this.rjExpiryDate_tbx.Name = "rjExpiryDate_tbx";
			this.rjExpiryDate_tbx.Padding = new System.Windows.Forms.Padding(7);
			this.rjExpiryDate_tbx.PasswordChar = false;
			this.rjExpiryDate_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjExpiryDate_tbx.PlaceholderText = "Expiry Date";
			this.rjExpiryDate_tbx.Size = new System.Drawing.Size(180, 35);
			this.rjExpiryDate_tbx.TabIndex = 4;
			this.rjExpiryDate_tbx.Texts = "";
			this.rjExpiryDate_tbx.UnderlinedStyle = false;
			// 
			// rjCVC_CVV_tbx
			// 
			this.rjCVC_CVV_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjCVC_CVV_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCVC_CVV_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCVC_CVV_tbx.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCVC_CVV_tbx.BorderRadius = 5;
			this.rjCVC_CVV_tbx.BorderSize = 2;
			this.rjCVC_CVV_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjCVC_CVV_tbx.ForeColor = System.Drawing.Color.DimGray;
			this.rjCVC_CVV_tbx.IsFocused = false;
			this.rjCVC_CVV_tbx.Location = new System.Drawing.Point(242, 164);
			this.rjCVC_CVV_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjCVC_CVV_tbx.Multiline = false;
			this.rjCVC_CVV_tbx.Name = "rjCVC_CVV_tbx";
			this.rjCVC_CVV_tbx.Padding = new System.Windows.Forms.Padding(7);
			this.rjCVC_CVV_tbx.PasswordChar = false;
			this.rjCVC_CVV_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjCVC_CVV_tbx.PlaceholderText = "CVC / CVV";
			this.rjCVC_CVV_tbx.Size = new System.Drawing.Size(179, 35);
			this.rjCVC_CVV_tbx.TabIndex = 3;
			this.rjCVC_CVV_tbx.Texts = "";
			this.rjCVC_CVV_tbx.UnderlinedStyle = false;
			// 
			// rjCardNumber_tbx
			// 
			this.rjCardNumber_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjCardNumber_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCardNumber_tbx.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCardNumber_tbx.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjCardNumber_tbx.BorderRadius = 5;
			this.rjCardNumber_tbx.BorderSize = 2;
			this.rjCardNumber_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjCardNumber_tbx.ForeColor = System.Drawing.Color.DimGray;
			this.rjCardNumber_tbx.IsFocused = false;
			this.rjCardNumber_tbx.Location = new System.Drawing.Point(31, 104);
			this.rjCardNumber_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjCardNumber_tbx.Multiline = false;
			this.rjCardNumber_tbx.Name = "rjCardNumber_tbx";
			this.rjCardNumber_tbx.Padding = new System.Windows.Forms.Padding(7);
			this.rjCardNumber_tbx.PasswordChar = false;
			this.rjCardNumber_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjCardNumber_tbx.PlaceholderText = "Card Number";
			this.rjCardNumber_tbx.Size = new System.Drawing.Size(390, 35);
			this.rjCardNumber_tbx.TabIndex = 2;
			this.rjCardNumber_tbx.Texts = "";
			this.rjCardNumber_tbx.UnderlinedStyle = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::SWD604_Task2_RetialCustomerManagementSystem.Properties.Resources.MasterCardImage;
			this.pictureBox2.Location = new System.Drawing.Point(137, 26);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(59, 33);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SWD604_Task2_RetialCustomerManagementSystem.Properties.Resources.visaImage;
			this.pictureBox1.Location = new System.Drawing.Point(37, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(59, 33);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.orderListView_lsv);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(126, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(465, 492);
			this.panel1.TabIndex = 12;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.orderNumber_lbl);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(16, 26);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(433, 33);
			this.panel3.TabIndex = 3;
			// 
			// orderNumber_lbl
			// 
			this.orderNumber_lbl.AutoSize = true;
			this.orderNumber_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderNumber_lbl.Location = new System.Drawing.Point(159, 9);
			this.orderNumber_lbl.Name = "orderNumber_lbl";
			this.orderNumber_lbl.Size = new System.Drawing.Size(104, 18);
			this.orderNumber_lbl.TabIndex = 1;
			this.orderNumber_lbl.Text = "Order Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Order Number";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.total_lbl);
			this.panel2.Controls.Add(this.discount_lbl);
			this.panel2.Controls.Add(this.delivary_lbl);
			this.panel2.Controls.Add(this.subTotal_lbl);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(16, 323);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(433, 156);
			this.panel2.TabIndex = 2;
			// 
			// total_lbl
			// 
			this.total_lbl.AutoSize = true;
			this.total_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total_lbl.Location = new System.Drawing.Point(237, 127);
			this.total_lbl.Name = "total_lbl";
			this.total_lbl.Size = new System.Drawing.Size(120, 26);
			this.total_lbl.TabIndex = 16;
			this.total_lbl.Text = "NZ$000.00";
			// 
			// discount_lbl
			// 
			this.discount_lbl.AutoSize = true;
			this.discount_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.discount_lbl.Location = new System.Drawing.Point(344, 68);
			this.discount_lbl.Name = "discount_lbl";
			this.discount_lbl.Size = new System.Drawing.Size(80, 22);
			this.discount_lbl.TabIndex = 15;
			this.discount_lbl.Text = "% 00.00";
			// 
			// delivary_lbl
			// 
			this.delivary_lbl.AutoSize = true;
			this.delivary_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delivary_lbl.Location = new System.Drawing.Point(354, 36);
			this.delivary_lbl.Name = "delivary_lbl";
			this.delivary_lbl.Size = new System.Drawing.Size(70, 22);
			this.delivary_lbl.TabIndex = 14;
			this.delivary_lbl.Text = "$00.00";
			// 
			// subTotal_lbl
			// 
			this.subTotal_lbl.AutoSize = true;
			this.subTotal_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subTotal_lbl.Location = new System.Drawing.Point(344, 4);
			this.subTotal_lbl.Name = "subTotal_lbl";
			this.subTotal_lbl.Size = new System.Drawing.Size(80, 22);
			this.subTotal_lbl.TabIndex = 13;
			this.subTotal_lbl.Text = "$000.00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 26);
			this.label6.TabIndex = 12;
			this.label6.Text = "Total";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 22);
			this.label5.TabIndex = 11;
			this.label5.Text = "Discount";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 22);
			this.label4.TabIndex = 10;
			this.label4.Text = "Delivery";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "Sub Total";
			// 
			// orderListView_lsv
			// 
			this.orderListView_lsv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.orderListView_lsv.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderListView_lsv.HideSelection = false;
			this.orderListView_lsv.Location = new System.Drawing.Point(16, 60);
			this.orderListView_lsv.Name = "orderListView_lsv";
			this.orderListView_lsv.Size = new System.Drawing.Size(433, 264);
			this.orderListView_lsv.TabIndex = 1;
			this.orderListView_lsv.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.label1.Location = new System.Drawing.Point(13, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Order Summary";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.label7.Location = new System.Drawing.Point(369, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(318, 88);
			this.label7.TabIndex = 11;
			this.label7.Text = "Payment";
			// 
			// BillGenerationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1096, 627);
			this.Controls.Add(this.BillGeneration_pnl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BillGenerationForm";
			this.Text = "BillGeneration";
			this.Load += new System.EventHandler(this.BillGeneration_Load);
			this.BillGeneration_pnl.ResumeLayout(false);
			this.BillGeneration_pnl.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BillGeneration_pnl;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView orderListView_lsv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label total_lbl;
		private System.Windows.Forms.Label discount_lbl;
		private System.Windows.Forms.Label delivary_lbl;
		private System.Windows.Forms.Label subTotal_lbl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label orderNumber_lbl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label8;
		private AP4_2.RJControls.RJButton rjPlaceOrder_btn;
		private AP4_2.RJControls.RJTextBox rjExpiryDate_tbx;
		private AP4_2.RJControls.RJTextBox rjCVC_CVV_tbx;
		private AP4_2.RJControls.RJTextBox rjCardNumber_tbx;
		private System.Windows.Forms.PictureBox pictureBox3;
		private RJCodeAdvance.RJControls.RJButton Back_btn;
		private RJCodeAdvance.RJControls.RJRadioButton rjMasterCard_rbn;
		private RJCodeAdvance.RJControls.RJRadioButton rjVisa_rbn;
	}
}