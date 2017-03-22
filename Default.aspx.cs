using System;
using System.Web;
using System.Web.UI;

namespace MyFirst
{

	public partial class Default : System.Web.UI.Page
	{
		public void button1Clicked(object sender, EventArgs args)
		{
			button1.Text = "You clicked me" + " do it!!!";
			string str = string.empty;
			str = "wxwang 003";

		}
	}
}
