using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Lab_6b_WinForms_Host
{
    public partial class Form1 : Form
    {
        ServiceHost serviceHost;

        public Form1()
        {
            InitializeComponent();
            serviceHost = new ServiceHost(typeof(WcfServiceLibraryX.Service1));
            serviceHost.Open();
        }
    }
}
