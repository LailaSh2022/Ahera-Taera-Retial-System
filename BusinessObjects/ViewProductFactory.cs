using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_Task2_RetialCustomerManagementSystem.BusinessObjects
{
	public abstract class ViewProductFactory
	{
		protected abstract IViewProduct CreateViewProductInstant();
		public IViewProduct GetViewProductInstant()
		{
			return this.CreateViewProductInstant();
		}
	}
}
