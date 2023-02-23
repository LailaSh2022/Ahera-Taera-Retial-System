using RJCodeAdvance.RJControls;
using SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects;
using SWD604_Task2_RetialCustomerManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem
{
	public partial class SignUpForm : Form
	{
		IValidateCustomer validateCustomer_Obj;
		ICreateCustomer createCustomer_Obj;
		IValidateInput validateInput_Obj;
		OpenChildForm childForm = new OpenChildForm();
		public SignUpForm()
		{
			InitializeComponent();
		}

		private void rjShowPassword_btn_Click(object sender, EventArgs e)
		{
			rjPassword_tbx.PasswordChar = false;
		}

		private void rjSignUp_btn_Click(object sender, EventArgs e)
		{
			DateTime dateOfBirth;
			validateCustomer_Obj = new FactoryMethod_ValidateNewCustomer().CreateCustomerInst();
			createCustomer_Obj = new FactoryMethod_CreateNewCustomer().GetCustomerInst();
			validateInput_Obj = new FactoryMethod_ValidateInput().CreateValidateInputInst();
			bool validInput = validateInput_Obj.ValidateInput(rjFirstName_tbx);
			validInput = validateInput_Obj.ValidateInput(rjLastName_tbx);
			validInput = validateInput_Obj.ValidateInput(rjDateOfBirth_tbx);
			validInput = validateInput_Obj.ValidateInput(rjEmail_tbx);
			validInput = validateInput_Obj.ValidateInput(rjPhoneNum_tbx);
			validInput = validateInput_Obj.ValidateInput(rjAddress_tbx);
			validInput = validateInput_Obj.ValidateInput(rjSuburb_tbx);
			validInput = validateInput_Obj.ValidateInput(rjZipcode_tbx);
			validInput = validateInput_Obj.ValidateInput(rjCity_tbx);
			validInput = validateInput_Obj.ValidateInput(rjUserName_tbx);
			validInput = validateInput_Obj.ValidateInput(rjPassword_tbx);
			if (validInput)
			{
				bool validDateOfBirth = validateInput_Obj.validateInputDate(rjDateOfBirth_tbx.Texts);
				bool validEmail = validateInput_Obj.validateInputEmail(rjEmail_tbx.Texts);
				if ((validDateOfBirth) && (validEmail))
				{
					dateOfBirth = Convert.ToDateTime(rjDateOfBirth_tbx.Texts);
					bool AddNewCustomer = createCustomer_Obj.CreateNew_Customer(rjFirstName_tbx.Texts, rjLastName_tbx.Texts,
						dateOfBirth, rjEmail_tbx.Texts, rjPhoneNum_tbx.Texts, rjAddress_tbx.Texts, rjSuburb_tbx.Texts,
						rjZipcode_tbx.Texts, rjCity_tbx.Texts, rjUserName_tbx.Texts, rjPassword_tbx.Texts);

					LoginForm LF = new LoginForm() { TopLevel = false, TopMost = true };
					singUpForm_pnl.Controls.Add(LF);
					childForm.openChildForm(LF);
				}
			}
			else
			{
				MessageBox.Show("Please enter the missing information", "Missing Input");
			}
		}
	}
}
