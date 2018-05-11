using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Lab_5
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        public override string GetVaryByCustomString(HttpContext context, string arg)
        {
            // Проверить запрашиваемый тип кэширования
            if (arg == "browser")
            {
                // Определить текущий браузер
                string browserName;
                browserName = Context.Request.Browser.Browser;
                browserName += Context.Request.Browser.MajorVersion.ToString();

                // Указать, что эта строка должна применяться для варьирования кэша
                return browserName;
            }
            else
            {
                return base.GetVaryByCustomString(context, arg);
            }
        }
    }
}