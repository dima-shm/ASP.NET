using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String x = "";
            foreach (String s in Request.QueryString)
                x += " " + s + " = " + Request[s];
            Label1.Text += x + ": " + DateTime.Now.ToString() + "<br />";
        }
    }
}