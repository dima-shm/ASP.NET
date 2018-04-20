using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Lab_3a
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                select1.Items.Add("111111");
                select1.Items.Add("222222");
                select1.Items.Add("333333");

                HtmlTable table = new HtmlTable();
                table.Border = 1;
                table.CellPadding = 3;
                table.CellSpacing = 3;
                table.Align = "center";
                table.BorderColor = "red";
                table.ID = "HtmlTable";

                HtmlTableRow row = new HtmlTableRow();
                HtmlTableCell cell;
                cell = new HtmlTableCell(); cell.InnerHtml = "Html Control"; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = "onserverclick"; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = "onserverchange"; row.Cells.Add(cell);
                table.Rows.Add(row);

                row = new HtmlTableRow();
                cell = new HtmlTableCell(); cell.InnerHtml = "HtmlInputReset"; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = "NO"; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = "NO"; row.Cells.Add(cell);
                table.Rows.Add(row);

                row = new HtmlTableRow();
                cell = new HtmlTableCell(); cell.InnerHtml = "HTMLInputFile"; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = "NO"; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = "NO"; row.Cells.Add(cell);
                table.Rows.Add(row);

                Controls.Add(table);

                Session["HtmlTable"] = table;
            }
        }


        protected void Button_Click(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlInputButton", "YES", "NO");
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlInputSubmit", "YES", "NO");
        }

        protected void Text_Change(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlInputText", "NO", "YES");
        }

        protected void Password_Click(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlInputPassword", "YES", "NO");
        }

        protected void Password_Change(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlInputPassword", "NO", "YES");
        }

        protected void CheckBox_Change(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlInputCheckbox", "NO", "YES");
        }

        protected void Radio1_Change(object sender, EventArgs e)
        {
            AddRowToHtmlTable("Radio1", "NO", "YES");
        }

        protected void Radio2_Change(object sender, EventArgs e)
        {
            AddRowToHtmlTable("Radio2", "NO", "YES");
        }

        protected void TextArea_Change(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlTextArea", "NO", "YES");
        }

        protected void Select_Change(object sender, EventArgs e)
        {
            AddRowToHtmlTable("HtmlSelect", "NO", "YES");
        }


        private void AddRowToHtmlTable(string elementName, string onServerClick, string onServerChange)
        {
            HtmlTable table = Session["HtmlTable"] as HtmlTable;

            if (table != null)
            {
                HtmlTableRow row = new HtmlTableRow();
                HtmlTableCell cell;

                cell = new HtmlTableCell(); cell.InnerHtml = elementName; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = onServerClick; row.Cells.Add(cell);
                cell = new HtmlTableCell(); cell.InnerHtml = onServerChange; row.Cells.Add(cell);
                table.Rows.Add(row);

                Controls.Add(table);
            }
        }
    }
}