using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lab_2a_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            label1.Text = reader.ReadToEnd();
        }
    }
}
