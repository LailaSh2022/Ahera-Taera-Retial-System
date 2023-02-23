using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem.Interfaces
{
	public class OpenChildForm
	{
		private Form currentChildForm { get; set; }

		public void openChildForm(Form childform)		// Display subform on passed child form.
		{
			currentChildForm = childform;
			childform.TopLevel = false;
			childform.FormBorderStyle = FormBorderStyle.None;
			childform.Dock = DockStyle.Fill;
			childform.BringToFront();
			childform.Show();
		}
	}
}
