using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1
{
    public partial class PageEvents : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Lable1.Text += "Page_Init<br/>";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Lable1.Text += "Page_Load<br/>";

            if (!Page.IsPostBack)
            {
                Lable1.Text += "<i>Первичная загрузка страницы</i><br/>";
            }
            else
            {
                Lable1.Text += "<i>Вторичная загрузка страницы</i><br/>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Lable1.Text += "Button1_Click<br/>";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Lable1.Text += "Page_PreRender<br/>";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            Lable1.Text += "Page_Unload<br/>";
        }
    }
}