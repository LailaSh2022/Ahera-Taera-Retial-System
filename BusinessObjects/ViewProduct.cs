using SWD604_Task2_RetialCustomerManagementSystem.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	class ViewProduct :  IViewProduct
	{

		public bool addProductMainImage(string imageLocation, int productId)
		{
			byte[] img = null;
			FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			img = br.ReadBytes((int)fs.Length);
			string sqlQuiry = "Update [dbo].[Products] set [PR_Main_Image] = @img where [PR_Id] =" + productId; 
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.SaveImage_ExecuteNonQuery(sqlQuiry,img);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}

		public bool addProductSubImages(string imageLocation, int productId)			// Insert product's sub-images
		{
			byte[] img = null;
			FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			img = br.ReadBytes((int)fs.Length);
			string sqlQuiry = "Insert into [dbo].[Products_Images] values(" + productId + ", @img)";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.SaveImage_ExecuteNonQuery(sqlQuiry,img);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}

		public DataSet GetProducts(string user)			// ADM for Admin side and else section for customer side
		{
			string sqlQuiry;
			if (user == "ADM")				// This Code were added to re-use the GetProducts method.
			{
				sqlQuiry = "select [PR_Id], CONCAT(PR_Id,' ',PR_Name , ' size ' , PR_Size) as [PR_Name] from [dbo].[Products]";
			}
			else
			{
				sqlQuiry = "select [PR_Id],[PR_Main_Image] from [dbo].[Products] where PR_Display = 'Y'";   // Select the product Id and main image.
			}
			
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataSet ds = databaseConnection.ExecuteDataSet(sqlQuiry);    // Execute the sql query.
			return ds;           // Return the data set
		}
		public void LoadDressImages(DataTable image_dt, ImageList dressImage_lst)        // Feed the image list with images from the data table.
		{
			int i = 0;
			foreach (DataRow dr in image_dt.Rows)
			{
				byte[] img = (byte[])dr["Image"];         // Save the image into bynary array.
				MemoryStream ms = new MemoryStream(img);
				dressImage_lst.Images.Add(i.ToString(), new Bitmap(ms));
				i++;
			}
		}

		public bool displayProduct(string productName)			// Display the given product on the customer's dashboard.
		{
			string sqlQuiry = "Update [dbo].[Products] set [PR_Display] ='Y' where [PR_Name] Like '" + productName + "'";  
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
		public bool HideProduct(string productName)            // Hide the given product on the customer's dashboard.
		{
			string sqlQuiry = "Update [dbo].[Products] set [PR_Display] ='N' where [PR_Name] Like '" + productName +"'";   
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
		public bool DeleteProduct(int productId)            // Delete selected product and it's images using the Cascade FK relationship
		{
			string sqlQuiry = "Delete from [dbo].[Products] where [PR_Id] = " + productId ;        // (select PR_Name from Products where PR_Id = " + productId + ")";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
		}
	}
}
