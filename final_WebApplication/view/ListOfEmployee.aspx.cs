using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class ListOfEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
            Page.MaintainScrollPositionOnPostBack = true;
            LinkedList<user> uList = new bl().getAllusers();
            foreach (user u in uList)
            {
                Button b = new Button();
                b.BackColor = System.Drawing.Color.Gainsboro;
                b.Text = u.Name + ", id: " + u.Id;
                b.BorderWidth = Unit.Pixel(10);
                b.BorderColor = System.Drawing.Color.White;
                b.CssClass = "dinButton";
                
                b.Width = Unit.Percentage(80);
                b.Height = Unit.Pixel(60);
                b.Click += new System.EventHandler(this.myHandler);
                form1.Controls.Add(b);
                Session[u.Id] = u.print();
            }

        }

        private void myHandler(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Page.MaintainScrollPositionOnPostBack = true;
           
                Session["sOld"] = b.Text;
                string idSOld = (Session["sOld"] as string).Split(',')[1].Split(':')[1].Trim();
                b.Text = Session[idSOld] as string;
                b.BorderWidth = Unit.Pixel(10);
                b.BorderColor = System.Drawing.Color.White;
                b.CssClass = "dinButton";
                b.Height = Unit.Pixel(120);
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }





    }
}