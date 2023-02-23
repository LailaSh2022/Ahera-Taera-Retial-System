
namespace SWD604_Task2_RetialCustomerManagementSystem.RJControls
{
	partial class CustomTextBox
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
			this.SuspendLayout();
			// 
			// rjTextBox1
			// 
			this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
			this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
			this.rjTextBox1.BorderRadius = 5;
			this.rjTextBox1.BorderSize = 2;
			this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rjTextBox1.Location = new System.Drawing.Point(0, 0);
			this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.rjTextBox1.Multiline = false;
			this.rjTextBox1.Name = "rjTextBox1";
			this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
			this.rjTextBox1.PasswordChar = false;
			this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.rjTextBox1.PlaceholderText = "";
			this.rjTextBox1.Size = new System.Drawing.Size(250, 30);
			this.rjTextBox1.TabIndex = 0;
			this.rjTextBox1.Texts = "";
			this.rjTextBox1.UnderlinedStyle = false;
			this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
	}
}
