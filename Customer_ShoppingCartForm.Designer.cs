﻿
namespace SWD604_Task2_RetialCustomerManagementSystem
{
	partial class Customer_ShoppingCartForm
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
			this.Customer_Cart_pnl = new System.Windows.Forms.Panel();
			this.rjChangeOrder_btn = new AP4_2.RJControls.RJButton();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.total_lbl = new System.Windows.Forms.Label();
			this.discount_lbl = new System.Windows.Forms.Label();
			this.delivary_lbl = new System.Windows.Forms.Label();
			this.subTotal_lbl = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rjProceedToCheckout_btn = new AP4_2.RJControls.RJButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rjDelivery_btn = new RJCodeAdvance.RJControls.RJToggleButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.shoppingItems_lst = new System.Windows.Forms.ListView();
			this.Customer_Cart_pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Customer_Cart_pnl
			// 
			this.Customer_Cart_pnl.Controls.Add(this.rjChangeOrder_btn);
			this.Customer_Cart_pnl.Controls.Add(this.label7);
			this.Customer_Cart_pnl.Controls.Add(this.pictureBox2);
			this.Customer_Cart_pnl.Controls.Add(this.panel3);
			this.Customer_Cart_pnl.Controls.Add(this.panel2);
			this.Customer_Cart_pnl.Controls.Add(this.shoppingItems_lst);
			this.Customer_Cart_pnl.Location = new System.Drawing.Point(0, -1);
			this.Customer_Cart_pnl.Name = "Customer_Cart_pnl";
			this.Customer_Cart_pnl.Size = new System.Drawing.Size(1095, 626);
			this.Customer_Cart_pnl.TabIndex = 0;
			this.Customer_Cart_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Customer_Cart_pnl_Paint);
			// 
			// rjChangeOrder_btn
			// 
			this.rjChangeOrder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjChangeOrder_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjChangeOrder_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjChangeOrder_btn.BorderRadius = 5;
			this.rjChangeOrder_btn.BorderSize = 0;
			this.rjChangeOrder_btn.FlatAppearance.BorderSize = 0;
			this.rjChangeOrder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjChangeOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjChangeOrder_btn.ForeColor = System.Drawing.Color.White;
			this.rjChangeOrder_btn.Location = new System.Drawing.Point(22, 576);
			this.rjChangeOrder_btn.Name = "rjChangeOrder_btn";
			this.rjChangeOrder_btn.Size = new System.Drawing.Size(350, 50);
			this.rjChangeOrder_btn.TabIndex = 9;
			this.rjChangeOrder_btn.Text = "Change Order";
			this.rjChangeOrder_btn.TextColor = System.Drawing.Color.White;
			this.rjChangeOrder_btn.UseVisualStyleBackColor = false;
			this.rjChangeOrder_btn.Click += new System.EventHandler(this.rjChangeOrder_btn_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.label7.Location = new System.Drawing.Point(348, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(318, 88);
			this.label7.TabIndex = 15;
			this.label7.Text = "My Cart";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::SWD604_Task2_RetialCustomerManagementSystem.Properties.Resources.Payment_Logo;
			this.pictureBox2.Location = new System.Drawing.Point(424, 531);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(649, 88);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.total_lbl);
			this.panel3.Controls.Add(this.discount_lbl);
			this.panel3.Controls.Add(this.delivary_lbl);
			this.panel3.Controls.Add(this.subTotal_lbl);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.rjProceedToCheckout_btn);
			this.panel3.Location = new System.Drawing.Point(424, 202);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(649, 323);
			this.panel3.TabIndex = 13;
			// 
			// total_lbl
			// 
			this.total_lbl.AutoSize = true;
			this.total_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total_lbl.Location = new System.Drawing.Point(196, 161);
			this.total_lbl.Name = "total_lbl";
			this.total_lbl.Size = new System.Drawing.Size(120, 26);
			this.total_lbl.TabIndex = 8;
			this.total_lbl.Text = "NZ$000.00";
			// 
			// discount_lbl
			// 
			this.discount_lbl.AutoSize = true;
			this.discount_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.discount_lbl.Location = new System.Drawing.Point(233, 110);
			this.discount_lbl.Name = "discount_lbl";
			this.discount_lbl.Size = new System.Drawing.Size(80, 22);
			this.discount_lbl.TabIndex = 7;
			this.discount_lbl.Text = "% 00.00";
			// 
			// delivary_lbl
			// 
			this.delivary_lbl.AutoSize = true;
			this.delivary_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delivary_lbl.Location = new System.Drawing.Point(243, 66);
			this.delivary_lbl.Name = "delivary_lbl";
			this.delivary_lbl.Size = new System.Drawing.Size(70, 22);
			this.delivary_lbl.TabIndex = 6;
			this.delivary_lbl.Text = "$00.00";
			// 
			// subTotal_lbl
			// 
			this.subTotal_lbl.AutoSize = true;
			this.subTotal_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subTotal_lbl.Location = new System.Drawing.Point(233, 30);
			this.subTotal_lbl.Name = "subTotal_lbl";
			this.subTotal_lbl.Size = new System.Drawing.Size(80, 22);
			this.subTotal_lbl.TabIndex = 5;
			this.subTotal_lbl.Text = "$000.00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(35, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 26);
			this.label6.TabIndex = 4;
			this.label6.Text = "Total";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(30, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 22);
			this.label5.TabIndex = 3;
			this.label5.Text = "Discount";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(29, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 22);
			this.label4.TabIndex = 2;
			this.label4.Text = "Delivery";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Sub Total";
			// 
			// rjProceedToCheckout_btn
			// 
			this.rjProceedToCheckout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProceedToCheckout_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProceedToCheckout_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjProceedToCheckout_btn.BorderRadius = 5;
			this.rjProceedToCheckout_btn.BorderSize = 0;
			this.rjProceedToCheckout_btn.FlatAppearance.BorderSize = 0;
			this.rjProceedToCheckout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjProceedToCheckout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjProceedToCheckout_btn.ForeColor = System.Drawing.Color.White;
			this.rjProceedToCheckout_btn.Location = new System.Drawing.Point(7, 258);
			this.rjProceedToCheckout_btn.Name = "rjProceedToCheckout_btn";
			this.rjProceedToCheckout_btn.Size = new System.Drawing.Size(635, 50);
			this.rjProceedToCheckout_btn.TabIndex = 0;
			this.rjProceedToCheckout_btn.Text = "Proceed to Checkout";
			this.rjProceedToCheckout_btn.TextColor = System.Drawing.Color.White;
			this.rjProceedToCheckout_btn.UseVisualStyleBackColor = false;
			this.rjProceedToCheckout_btn.Click += new System.EventHandler(this.rjProceedToCheckout_btn_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Location = new System.Drawing.Point(424, 103);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(649, 82);
			this.panel2.TabIndex = 12;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.rjDelivery_btn);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(7, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(626, 61);
			this.panel1.TabIndex = 2;
			// 
			// rjDelivery_btn
			// 
			this.rjDelivery_btn.AutoSize = true;
			this.rjDelivery_btn.Location = new System.Drawing.Point(577, 17);
			this.rjDelivery_btn.MinimumSize = new System.Drawing.Size(45, 22);
			this.rjDelivery_btn.Name = "rjDelivery_btn";
			this.rjDelivery_btn.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjDelivery_btn.OffToggleColor = System.Drawing.Color.White;
			this.rjDelivery_btn.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjDelivery_btn.OnToggleColor = System.Drawing.Color.WhiteSmoke;
			this.rjDelivery_btn.Size = new System.Drawing.Size(45, 22);
			this.rjDelivery_btn.TabIndex = 9;
			this.rjDelivery_btn.UseVisualStyleBackColor = true;
			this.rjDelivery_btn.CheckedChanged += new System.EventHandler(this.rjDelivery_btn_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(333, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "$10.00 For all Deliveries.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Standard Delivery(NZ)";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SWD604_Task2_RetialCustomerManagementSystem.Properties.Resources.DelivaryImage;
			this.pictureBox1.Location = new System.Drawing.Point(8, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// shoppingItems_lst
			// 
			this.shoppingItems_lst.HideSelection = false;
			this.shoppingItems_lst.Location = new System.Drawing.Point(22, 103);
			this.shoppingItems_lst.Name = "shoppingItems_lst";
			this.shoppingItems_lst.Size = new System.Drawing.Size(350, 471);
			this.shoppingItems_lst.TabIndex = 11;
			this.shoppingItems_lst.UseCompatibleStateImageBehavior = false;
			// 
			// Customer_ShoppingCartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1096, 627);
			this.Controls.Add(this.Customer_Cart_pnl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Customer_ShoppingCartForm";
			this.Text = "Customer_ShoppingCart";
			this.Load += new System.EventHandler(this.Customer_ShoppingCartForm_Load);
			this.Customer_Cart_pnl.ResumeLayout(false);
			this.Customer_Cart_pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Customer_Cart_pnl;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label total_lbl;
		private System.Windows.Forms.Label discount_lbl;
		private System.Windows.Forms.Label delivary_lbl;
		private System.Windows.Forms.Label subTotal_lbl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private AP4_2.RJControls.RJButton rjProceedToCheckout_btn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private RJCodeAdvance.RJControls.RJToggleButton rjDelivery_btn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView shoppingItems_lst;
		private AP4_2.RJControls.RJButton rjChangeOrder_btn;
	}
}