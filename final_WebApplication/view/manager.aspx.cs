using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm_example.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewEmployee.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AttendenceChanging.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("changeDetailsForEmployee.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("monthlySumery.aspx");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("realTime.aspx");

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOfEmployee.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("statistic.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogFile.aspx");
        }
    }
}