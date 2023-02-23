using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public interface IViewProduct
	{
		DataSet GetProducts(string user);
		void LoadDressImages(DataTable image_dt, ImageList dressImage_lst);
		bool addProductSubImages(string imageLocation, int productId);

		bool addProductMainImage(string imageLocation, int productId);
		bool displayProduct(string productName);
		bool HideProduct(string productNamed);
		//bool DeleteProduct(int productId);
	}
}
