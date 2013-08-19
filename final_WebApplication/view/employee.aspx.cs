using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class employee : System.Web.UI.Page
    {
        private user u;
        private string user_id;
        private bl Bl;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIde"] == null)
                Response.Redirect("EnterYourId.aspx");
            Button1.Enabled = true;
            Button2.Enabled = true;
            user_id = (string)Session["userIde"];
            Bl = new bl();
            u = Bl.getUser(user_id);
            if (u.returnTheOpenShift() != null)
            {
                Button1.Visible = false;
            }
            else
            {
                Button2.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Bl.startShift(user_id, new shift(DateTime.Now.ToString(@"dd-MM-yy"), DateTime.Now.ToString(@"HH-mm"), null, null));
            Button1.Visible = false;
            Button2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Bl.endShift(user_id, DateTime.Now.ToString(@"HH-mm"), DateTime.Now.ToString(@"dd-MM-yy"));
            Button1.Visible = true;
            Button2.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAllShifts.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm_example.aspx");
        }



    }
}