
namespace SWD604_Task2_RetialCustomerManagementSystem
{
	partial class DisplayProductForm
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
			this.Title_lbl = new System.Windows.Forms.Label();
			this.SubTitle_lbl = new System.Windows.Forms.Label();
			this.XL_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.L_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.M_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.S_rbn = new RJCodeAdvance.RJControls.RJRadioButton();
			this.Price_lbl = new System.Windows.Forms.Label();
			this.Back_btn = new RJCodeAdvance.RJControls.RJButton();
			this.AddToCart_btn = new RJCodeAdvance.RJControls.RJButton();
			this.DisplayProduct_pnl = new System.Windows.Forms.Panel();
			this.rjDiscription_lbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rjNumberOfIems_tbx = new RJCodeAdvance.RJControls.RJTextBox();
			this.viewDress_pbx = new System.Windows.Forms.PictureBox();
			this.dressImage_lst = new System.Windows.Forms.ImageList(this.components);
			this.DisplayImage_tmr = new System.Windows.Forms.Timer(this.components);
			this.rjEdit_btn = new RJCodeAdvance.RJControls.RJButton();
			this.rjDelete_btn = new RJCodeAdvance.RJControls.RJButton();
			this.DisplayProduct_pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewDress_pbx)).BeginInit();
			this.SuspendLayout();
			// 
			// Title_lbl
			// 
			this.Title_lbl.AutoSize = true;
			this.Title_lbl.BackColor = System.Drawing.Color.Transparent;
			this.Title_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.Title_lbl.Location = new System.Drawing.Point(351, 11);
			this.Title_lbl.Name = "Title_lbl";
			this.Title_lbl.Size = new System.Drawing.Size(278, 76);
			this.Title_lbl.TabIndex = 0;
			this.Title_lbl.Text = "Eligant";
			this.Title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// SubTitle_lbl
			// 
			this.SubTitle_lbl.AutoSize = true;
			this.SubTitle_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.SubTitle_lbl.Location = new System.Drawing.Point(465, 80);
			this.SubTitle_lbl.Name = "SubTitle_lbl";
			this.SubTitle_lbl.Size = new System.Drawing.Size(43, 16);
			this.SubTitle_lbl.TabIndex = 1;
			this.SubTitle_lbl.Text = "Dress";
			// 
			// XL_rbn
			// 
			this.XL_rbn.AutoSize = true;
			this.XL_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.XL_rbn.Location = new System.Drawing.Point(373, 290);
			this.XL_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.XL_rbn.Name = "XL_rbn";
			this.XL_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.XL_rbn.Size = new System.Drawing.Size(55, 22);
			this.XL_rbn.TabIndex = 3;
			this.XL_rbn.TabStop = true;
			this.XL_rbn.Text = "XL";
			this.XL_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.XL_rbn.UseVisualStyleBackColor = true;
			this.XL_rbn.CheckedChanged += new System.EventHandler(this.XL_rbn_CheckedChanged);
			// 
			// L_rbn
			// 
			this.L_rbn.AutoSize = true;
			this.L_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.L_rbn.Location = new System.Drawing.Point(434, 290);
			this.L_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.L_rbn.Name = "L_rbn";
			this.L_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.L_rbn.Size = new System.Drawing.Size(47, 22);
			this.L_rbn.TabIndex = 4;
			this.L_rbn.TabStop = true;
			this.L_rbn.Text = "L";
			this.L_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.L_rbn.UseVisualStyleBackColor = true;
			this.L_rbn.CheckedChanged += new System.EventHandler(this.L_rbn_CheckedChanged);
			// 
			// M_rbn
			// 
			this.M_rbn.AutoSize = true;
			this.M_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.M_rbn.Location = new System.Drawing.Point(487, 290);
			this.M_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.M_rbn.Name = "M_rbn";
			this.M_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.M_rbn.Size = new System.Drawing.Size(47, 22);
			this.M_rbn.TabIndex = 5;
			this.M_rbn.TabStop = true;
			this.M_rbn.Text = "M";
			this.M_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.M_rbn.UseVisualStyleBackColor = true;
			this.M_rbn.CheckedChanged += new System.EventHandler(this.M_rbn_CheckedChanged);
			// 
			// S_rbn
			// 
			this.S_rbn.AutoSize = true;
			this.S_rbn.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.S_rbn.Location = new System.Drawing.Point(540, 290);
			this.S_rbn.MinimumSize = new System.Drawing.Size(0, 21);
			this.S_rbn.Name = "S_rbn";
			this.S_rbn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.S_rbn.Size = new System.Drawing.Size(47, 22);
			this.S_rbn.TabIndex = 6;
			this.S_rbn.TabStop = true;
			this.S_rbn.Text = "S";
			this.S_rbn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.S_rbn.UseVisualStyleBackColor = true;
			this.S_rbn.CheckedChanged += new System.EventHandler(this.S_rbn_CheckedChanged);
			// 
			// Price_lbl
			// 
			this.Price_lbl.AutoSize = true;
			this.Price_lbl.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.Price_lbl.Location = new System.Drawing.Point(369, 337);
			this.Price_lbl.Name = "Price_lbl";
			this.Price_lbl.Size = new System.Drawing.Size(70, 22);
			this.Price_lbl.TabIndex = 7;
			this.Price_lbl.Text = "$Price";
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
			this.Back_btn.Location = new System.Drawing.Point(361, 419);
			this.Back_btn.Name = "Back_btn";
			this.Back_btn.Size = new System.Drawing.Size(67, 40);
			this.Back_btn.TabIndex = 10;
			this.Back_btn.Text = "Back";
			this.Back_btn.TextColor = System.Drawing.Color.White;
			this.Back_btn.UseVisualStyleBackColor = false;
			this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
			// 
			// AddToCart_btn
			// 
			this.AddToCart_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.AddToCart_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.AddToCart_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.AddToCart_btn.BorderRadius = 5;
			this.AddToCart_btn.BorderSize = 0;
			this.AddToCart_btn.FlatAppearance.BorderSize = 0;
			this.AddToCart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddToCart_btn.ForeColor = System.Drawing.Color.White;
			this.AddToCart_btn.Location = new System.Drawing.Point(506, 420);
			this.AddToCart_btn.Name = "AddToCart_btn";
			this.AddToCart_btn.Size = new System.Drawing.Size(107, 40);
			this.AddToCart_btn.TabIndex = 11;
			this.AddToCart_btn.Text = "Add to Cart";
			this.AddToCart_btn.TextColor = System.Drawing.Color.White;
			this.AddToCart_btn.UseVisualStyleBackColor = false;
			this.AddToCart_btn.Click += new System.EventHandler(this.AddToCart_btn_Click);
			// 
			// DisplayProduct_pnl
			// 
			this.DisplayProduct_pnl.Controls.Add(this.rjDelete_btn);
			this.DisplayProduct_pnl.Controls.Add(this.rjEdit_btn);
			this.DisplayProduct_pnl.Controls.Add(this.rjDiscription_lbx);
			this.DisplayProduct_pnl.Controls.Add(this.label1);
			this.DisplayProduct_pnl.Controls.Add(this.rjNumberOfIems_tbx);
			this.DisplayProduct_pnl.Controls.Add(this.AddToCart_btn);
			this.DisplayProduct_pnl.Controls.Add(this.Back_btn);
			this.DisplayProduct_pnl.Controls.Add(this.viewDress_pbx);
			this.DisplayProduct_pnl.Controls.Add(this.Price_lbl);
			this.DisplayProduct_pnl.Controls.Add(this.S_rbn);
			this.DisplayProduct_pnl.Controls.Add(this.M_rbn);
			this.DisplayProduct_pnl.Controls.Add(this.L_rbn);
			this.DisplayProduct_pnl.Controls.Add(this.XL_rbn);
			this.DisplayProduct_pnl.Controls.Add(this.SubTitle_lbl);
			this.DisplayProduct_pnl.Controls.Add(this.Title_lbl);
			this.DisplayProduct_pnl.Location = new System.Drawing.Point(-1, -2);
			this.DisplayProduct_pnl.Name = "DisplayProduct_pnl";
			this.DisplayProduct_pnl.Size = new System.Drawing.Size(1058, 566);
			this.DisplayProduct_pnl.TabIndex = 12;
			// 
			// rjDiscription_lbx
			// 
			this.rjDiscription_lbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjDiscription_lbx.BorderColor = System.Drawing.Color.White;
			this.rjDiscription_lbx.BorderFocusColor = System.Drawing.Color.HotPink;
			this.rjDiscription_lbx.BorderRadius = 0;
			this.rjDiscription_lbx.BorderSize = 2;
			this.rjDiscription_lbx.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjDiscription_lbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjDiscription_lbx.Location = new System.Drawing.Point(373, 144);
			this.rjDiscription_lbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjDiscription_lbx.Multiline = true;
			this.rjDiscription_lbx.Name = "rjDiscription_lbx";
			this.rjDiscription_lbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjDiscription_lbx.PasswordChar = false;
			this.rjDiscription_lbx.PlaceholderColor = System.Drawing.Color.Black;
			this.rjDiscription_lbx.PlaceholderText = "No Discription";
			this.rjDiscription_lbx.Size = new System.Drawing.Size(227, 115);
			this.rjDiscription_lbx.TabIndex = 14;
			this.rjDiscription_lbx.Texts = "";
			this.rjDiscription_lbx.UnderlinedStyle = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.label1.Location = new System.Drawing.Point(369, 374);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Quantity";
			// 
			// rjNumberOfIems_tbx
			// 
			this.rjNumberOfIems_tbx.BackColor = System.Drawing.SystemColors.Window;
			this.rjNumberOfIems_tbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjNumberOfIems_tbx.BorderFocusColor = System.Drawing.Color.HotPink;
			this.rjNumberOfIems_tbx.BorderRadius = 5;
			this.rjNumberOfIems_tbx.BorderSize = 2;
			this.rjNumberOfIems_tbx.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjNumberOfIems_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjNumberOfIems_tbx.Location = new System.Drawing.Point(534, 369);
			this.rjNumberOfIems_tbx.Margin = new System.Windows.Forms.Padding(4);
			this.rjNumberOfIems_tbx.Multiline = false;
			this.rjNumberOfIems_tbx.Name = "rjNumberOfIems_tbx";
			this.rjNumberOfIems_tbx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjNumberOfIems_tbx.PasswordChar = false;
			this.rjNumberOfIems_tbx.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjNumberOfIems_tbx.PlaceholderText = "0";
			this.rjNumberOfIems_tbx.Size = new System.Drawing.Size(53, 36);
			this.rjNumberOfIems_tbx.TabIndex = 12;
			this.rjNumberOfIems_tbx.Texts = "";
			this.rjNumberOfIems_tbx.UnderlinedStyle = false;
			// 
			// viewDress_pbx
			// 
			this.viewDress_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.viewDress_pbx.Location = new System.Drawing.Point(190, 139);
			this.viewDress_pbx.Name = "viewDress_pbx";
			this.viewDress_pbx.Size = new System.Drawing.Size(165, 320);
			this.viewDress_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.viewDress_pbx.TabIndex = 8;
			this.viewDress_pbx.TabStop = false;
			// 
			// dressImage_lst
			// 
			this.dressImage_lst.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.dressImage_lst.ImageSize = new System.Drawing.Size(165, 256);
			this.dressImage_lst.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// DisplayImage_tmr
			// 
			this.DisplayImage_tmr.Enabled = true;
			this.DisplayImage_tmr.Interval = 1500;
			this.DisplayImage_tmr.Tick += new System.EventHandler(this.DisplayImage_tmr_Tick);
			// 
			// rjEdit_btn
			// 
			this.rjEdit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjEdit_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjEdit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjEdit_btn.BorderRadius = 5;
			this.rjEdit_btn.BorderSize = 0;
			this.rjEdit_btn.FlatAppearance.BorderSize = 0;
			this.rjEdit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjEdit_btn.ForeColor = System.Drawing.Color.White;
			this.rjEdit_btn.Location = new System.Drawing.Point(695, 355);
			this.rjEdit_btn.Name = "rjEdit_btn";
			this.rjEdit_btn.Size = new System.Drawing.Size(67, 40);
			this.rjEdit_btn.TabIndex = 15;
			this.rjEdit_btn.Text = "Edit";
			this.rjEdit_btn.TextColor = System.Drawing.Color.White;
			this.rjEdit_btn.UseVisualStyleBackColor = false;
			this.rjEdit_btn.Click += new System.EventHandler(this.rjEdit_btn_Click);
			// 
			// rjDelete_btn
			// 
			this.rjDelete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjDelete_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjDelete_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.rjDelete_btn.BorderRadius = 5;
			this.rjDelete_btn.BorderSize = 0;
			this.rjDelete_btn.FlatAppearance.BorderSize = 0;
			this.rjDelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjDelete_btn.ForeColor = System.Drawing.Color.White;
			this.rjDelete_btn.Location = new System.Drawing.Point(695, 420);
			this.rjDelete_btn.Name = "rjDelete_btn";
			this.rjDelete_btn.Size = new System.Drawing.Size(67, 40);
			this.rjDelete_btn.TabIndex = 16;
			this.rjDelete_btn.Text = "Delete";
			this.rjDelete_btn.TextColor = System.Drawing.Color.White;
			this.rjDelete_btn.UseVisualStyleBackColor = false;
			this.rjDelete_btn.Click += new System.EventHandler(this.rjDelete_btn_Click);
			// 
			// DisplayProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1058, 563);
			this.Controls.Add(this.DisplayProduct_pnl);
			this.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DisplayProductForm";
			this.Text = "DisplayProductForm";
			this.Load += new System.EventHandler(this.DisplayProductForm_Load);
			this.DisplayProduct_pnl.ResumeLayout(false);
			this.DisplayProduct_pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewDress_pbx)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Title_lbl;
		private System.Windows.Forms.Label SubTitle_lbl;
		private RJCodeAdvance.RJControls.RJRadioButton XL_rbn;
		private RJCodeAdvance.RJControls.RJRadioButton L_rbn;
		private RJCodeAdvance.RJControls.RJRadioButton M_rbn;
		private RJCodeAdvance.RJControls.RJRadioButton S_rbn;
		private System.Windows.Forms.Label Price_lbl;
		private System.Windows.Forms.PictureBox viewDress_pbx;
		private RJCodeAdvance.RJControls.RJButton Back_btn;
		private RJCodeAdvance.RJControls.RJButton AddToCart_btn;
		private System.Windows.Forms.Panel DisplayProduct_pnl;
		private System.Windows.Forms.ImageList dressImage_lst;
		private System.Windows.Forms.Timer DisplayImage_tmr;
		private RJCodeAdvance.RJControls.RJTextBox rjNumberOfIems_tbx;
		private System.Windows.Forms.Label label1;
		private RJCodeAdvance.RJControls.RJTextBox rjDiscription_lbx;
		private RJCodeAdvance.RJControls.RJButton rjDelete_btn;
		private RJCodeAdvance.RJControls.RJButton rjEdit_btn;
	}
}