using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class defultSetting : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
            Table1.BackColor = System.Drawing.Color.AliceBlue;
            Table1.BorderWidth = Unit.Pixel(2);

            TableRow tRow1 = new TableRow();
            Table1.Rows.Add(tRow1);
            TableCell tCell1 = new TableCell();
            tCell1.Text = "Date";
            tCell1.BorderColor = System.Drawing.Color.Black;
            tCell1.BorderWidth = Unit.Pixel(1);
            tRow1.Cells.Add(tCell1);
            TableCell tCell2 = new TableCell();
            tCell2.Text = "Time";
            tCell2.BorderColor = System.Drawing.Color.Black;
            tCell2.BorderWidth = Unit.Pixel(1);
            tRow1.Cells.Add(tCell2);
            TableCell tCell3 = new TableCell();
            tCell3.Text = "Details";
            tCell3.BorderColor = System.Drawing.Color.Black;
            tCell3.BorderWidth = Unit.Pixel(1);
            tRow1.Cells.Add(tCell3);
           

            bl sys = new bl();
            LinkedList<string> l = sys.readFromLog();
            foreach (string s in l)
            {
                string[] spliter = s.Split(';');
                tRow1 = new TableRow();
                tRow1.BorderColor = System.Drawing.Color.Black;
                Table1.Rows.Add(tRow1);
                tCell1 = new TableCell();
                tCell1.Text = spliter[1].Split(' ')[0];
                tCell1.BorderColor = System.Drawing.Color.Black;
                tCell1.BorderWidth = Unit.Pixel(1);
                tRow1.Cells.Add(tCell1);
                tCell2 = new TableCell();
                tCell2.Text = spliter[0];
                tCell2.BorderColor = System.Drawing.Color.Black;
                tCell2.BorderWidth = Unit.Pixel(1);
                tRow1.Cells.Add(tCell2);
                tCell3 = new TableCell();
                tCell3.Text = spliter[2];
                tCell3.BorderColor = System.Drawing.Color.Black;
                tCell3.BorderWidth = Unit.Pixel(1);
                tRow1.Cells.Add(tCell3);
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }






    }
}