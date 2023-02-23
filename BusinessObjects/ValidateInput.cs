using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP4_2.RJControls;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class ValidateInput : IValidateInput
	{
		public bool validateInputDate(string date)			// Validate Date input
		{
			DateTime Date;
			if (DateTime.TryParse(date, out Date))
			{
				return true;
			}
			else
			{
				MessageBox.Show("Please enter a valid Date", "Invalid Date");
				return false;
			}
		}

		public bool validateInputEmail(string email)		// Validate Email Address
		{
			var trimmedEmail = email.Trim();

			if (trimmedEmail.EndsWith("."))
			{
				return false;
			}
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == trimmedEmail;
			}
			catch
			{
				MessageBox.Show("Please enter a valid email address", "Invalid Email Address");
				return false;
			}
		}

		bool IValidateInput.ValidateInput(RJCodeAdvance.RJControls.RJTextBox textBox)		// Validate Text box.
		{
			if ((textBox.Texts == "")&&(textBox.PlaceholderText == ""))		// Empty text box.
			{
				textBox.BorderColor = Color.Gray;
				return false;
			}
			else                         // Text box with some data.
			{
				textBox.BorderColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				return true;
			}
		}

		bool IValidateInput.ValidateInput(AP4_2.RJControls.RJTextBox textBox)
		{
			if (textBox.Texts == "")
			{
				textBox.BorderColor = Color.Gray;
				return false;
			}
			else
			{
				textBox.BorderColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
				return true;
			}
		}
	}
}
