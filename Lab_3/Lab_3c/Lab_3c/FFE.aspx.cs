using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_3c
{
    public partial class FFE : System.Web.UI.Page
    {
        private string[] keywords = { "", "b1", "b2" };

        private int CuurentAdRotatorPosition
        {
            set
            {
                ViewState["AdRotatorPosition"] = value;
            }
            get
            {
                object value = ViewState["AdRotatorPosition"];
                if (value == null)
                    ViewState["AdRotatorPosition"] = 0;
                return (int)ViewState["AdRotatorPosition"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "TextBox1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "TextBox2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = "TextBox3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = (MultiView1.ActiveViewIndex + 1) % 3;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int newPosition = ++CuurentAdRotatorPosition % keywords.Length;
            AdRotator1.KeywordFilter = keywords[newPosition];
            Button5.Text = keywords[newPosition];
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (e.CurrentStepIndex == 3)
            {
                Label1.Text = TextBox4.Text + " ";
                Label1.Text += TextBox5.Text + " ";
                
                Label1.Text += ListBox1.SelectedValue + " ";

                foreach (ListItem li in CheckBoxList1.Items)
                {
                    if (li.Selected)
                    {
                        Label1.Text += li.Value + ", ";
                    }
                }
                Label1.Text += " ";
                
                Label1.Text += Calendar1.SelectedDate.ToString();
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Label1.Text = TextBox4.Text + " " + TextBox5.Text;
        }

        protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
        {
            Wizard1.ActiveStepIndex = 0;
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            if(TreeView1.SelectedNode == null)
            {
                return;
            }
            Label2.Text = "Вы выбрали элемент " + TreeView1.SelectedNode.Value; ;
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            Label3.Text = "Вы выбрали элемент " + Menu1.SelectedItem.Value;
        }
    }
}