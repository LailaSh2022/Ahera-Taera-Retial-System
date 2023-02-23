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
	public class AddToShoppingCart : IAddToShoppingCart
	{
		public bool addProductToCart(int productId, int customerId, string size, int quantity)
		{
			string sqlQuiry = "insert into [dbo].[Shopping_Cart] values("+ customerId + ","+ productId +","+ quantity +",'"+ size + "','Unpaid')";
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;           // Error.
			
		}

		public int Feed_ListView(ListView shoppingItems_lst, DataTable dt)
		{
			shoppingItems_lst.View = View.Details;

			shoppingItems_lst.Columns.Add("Shopping Items", 250);
			//ShoppingCart_lsv.CheckBoxes = true;
			shoppingItems_lst.Columns.Add("ID", 50);
			ImageList Imagelist = new ImageList();
			Imagelist.ImageSize = new Size(100, 150);
			int counter = 0;
			foreach (DataRow dr in dt.Rows)
			{
				string id = " ID: " + dr["PR_Id"].ToString() + "@@  Name: " +
					dr["PR_Name"].ToString() + "@  Size: " + dr["Size"].ToString()+
					"@  Price: $" + dr["PR_Price"].ToString() + "@  Quantity: " + dr["Quantitiy"].ToString();
				id = id.Replace("@", System.Environment.NewLine);       // Replace @ by new line.
				ListViewItem carItem = new ListViewItem();

				byte[] img = (byte[])(dr["PR_Main_Image"]);     // Handel the image using byte array
																//SHOULD BE DECLARED AT FORM LEVEL
				MemoryStream ms = new MemoryStream(img);        // Encapsulates data stored in img array
				Image image = Image.FromStream(ms);

				Imagelist.Images.Add(image);                // Store image into an image list to display it.

				//ShoppingCart_lsv.Items.Add(dr["PR_Id"].ToString());
				shoppingItems_lst.SmallImageList = Imagelist;       // Display the image as a small size in the list view.
				shoppingItems_lst.Items.Add(id, counter);



				counter++;

			}

			return counter;
			
		}

		public DataTable GetSelectedProductDetails(int customerId)		// Return selected products by user.
		{
            string sqlQuiry = "select Products.PR_Id, Products.PR_Name,Products.PR_Price,Products.PR_Discription," +
                "Products.PR_Main_Image,Shopping_Cart.Size,Shopping_Cart.Quantitiy from Products, Shopping_Cart " +
                "where Products.PR_Id = [dbo].[Shopping_Cart].[PR_Id] and[dbo].[Shopping_Cart].[CU_Id] = " + customerId+" And [Status] = 'Unpaid'";
            DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
            databaseConnection.Open();
            DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
            return dt;           // Return the data table
        }

		public bool UpdateCartStatus(int customerId)		// After complete the payment update status to paid for given customer
		{
			string sqlQuiry = "update  [dbo].[Shopping_Cart] set [Status]='Paid' where [CU_Id] = " + customerId;
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			int result = databaseConnection.ExecuteNonQuery(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			if (result > 0)
				return true;            // Insert new record.
			else
				return false;
		}

		public bool validateQuantity(string quantity, int productId)    // Validate the quantity enterd by the user
		{
			string sqlQuiry = "select [PR_Stock_Qantity] from Products where Products.PR_Id = " + productId;		// return the number of stock for given product Id.
			DatabaseConnection databaseConnection = new DatabaseConnection();   // Create Database Connection Using DatabaseConnection object
			databaseConnection.Open();
			DataTable dt = databaseConnection.ExecuteDataTable(sqlQuiry);    // Execute the sql query.
			databaseConnection.Close();
			int availableStock = Convert.ToInt32(dt.Rows[0]["PR_Stock_Qantity"]);
			int numOfItems;
						
            if ((quantity == "0") || (quantity ==""))		// Check if the user enter correct input of quantity.
            {
                MessageBox.Show("Please enter how may item you want to add.", "Item's number");
                return false;
            }
            else
            {
                if (quantity.Length < 3)		// Check if the user enter a number of two digits.
                {
                    if (Int32.TryParse(quantity, out numOfItems))
                    {
							if (numOfItems < availableStock)		// Check the available stock.
							{
								if (numOfItems > 10)			// If the user enter number greater than ten.
								{
									MessageBoxButtons buttons = MessageBoxButtons.YesNo;
									DialogResult dialogResult = MessageBox.Show("Are you shure you want to add " + numOfItems + " items into your chart?.",
										"Validate Quntity Number", buttons);
									if (dialogResult == DialogResult.Yes)
										return true;
									else
										return false;
								}
								return true;
							}
							else
							{
								if (availableStock == 0)				// Out of stock.
									MessageBox.Show("Sorry! Out of Stock", "Out of Stock");
								else
									MessageBox.Show("Please enter a valid Quantity number.", "Invalid Quantity number");
								return false;
							}
							
					}
                    else
                    {
                        MessageBox.Show("Please enter a valid Quantity number.", "Invalid Quantity number");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Quantity number.", "Invalid Quantity number");
                    return false;
                }
            }
        }
	}
}
