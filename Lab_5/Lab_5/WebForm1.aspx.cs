using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "<h2>" + DateTime.Now.ToString() + "</h2>";
        }

        private static string GetDate(HttpContext context)
        {
            return "<h2> Substitution: " + DateTime.Now.ToString() + "<h2>";
        }
    }
}