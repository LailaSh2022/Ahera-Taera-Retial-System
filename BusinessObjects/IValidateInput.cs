using AP4_2.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP4_2.RJControls;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public interface IValidateInput
	{
		bool ValidateInput(RJCodeAdvance.RJControls.RJTextBox textBox);
		bool validateInputDate(string date);
		bool validateInputEmail(string email);
		bool ValidateInput(RJTextBox rjCardNumber_tbx);
	}
}
