using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class FactoryMethod_ValidateInput : ValidateInputFactory
	{
		protected override IValidateInput MakeValidateInputInstance()
		{
			IValidateInput ValidateInput_Obj = new ValidateInput();
			return ValidateInput_Obj;
		}
	}
}
