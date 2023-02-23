using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public interface IDressDetails
	{
		DataTable GetProductDetails(int productId, string user);
		DataTable GetProductImages(int productId);
		
	}
}
