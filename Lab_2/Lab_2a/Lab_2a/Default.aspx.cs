using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace Lab_2a
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGet_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create("http://172.16.193.174:45001/Lab_2a/test.sda?ParmA=1&ParmB=2");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Label1.Text = reader.ReadToEnd();
        }

        protected void ButtonPost_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://172.16.193.174:45001/Lab_2a/test.sda");
            request.Method = "POST";
            
            byte[] parameters = System.Text.Encoding.ASCII.GetBytes("ParmA=3&ParmB=4");
            request.ContentLength = parameters.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream outputStream = request.GetRequestStream())
            {
                outputStream.Write(parameters, 0, parameters.Length);
            }
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Label1.Text = reader.ReadToEnd();
        }

        protected void ButtonPut_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://172.16.193.174:45001/Lab_2a/test.sda");
            request.Method = "PUT";

            byte[] parameters = System.Text.Encoding.ASCII.GetBytes("ParmA=5&ParmB=6");
            request.ContentLength = parameters.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream outputStream = request.GetRequestStream())
            {
                outputStream.Write(parameters, 0, parameters.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Label1.Text = reader.ReadToEnd();
        }

        protected void ButtonGetDeny_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://172.16.193.174:45001/Lab_2a/test.deny");
                request.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Label1.Text = reader.ReadToEnd();
            }
            catch(WebException ex)
            {
                Label1.Text = "Message: " + ex.Message + "<br />";
            }
        }
    }
}