using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_3b
{
    public partial class AAA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ServerValidate(object sender, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = (int.Parse(args.Value) % 2 != 0);
            }
            catch
            {
                args.IsValid = false;
            }
        }
    }
}