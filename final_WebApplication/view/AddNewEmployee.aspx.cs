using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class AddNewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
            ErrLabel.Visible = false;
            ErrLabel2.Visible = false;
            Label1.Visible = false;
            Button2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
            {
                ErrLabel.Visible = true;
            }
            else
            {
                bl s = new bl();
                user u = s.getUser(TextBox2.Text);
                if (u != null)
                {
                    ErrLabel2.Visible = true;
                }
                else
                {
                    if (DropDownList1.SelectedIndex == 0)
                    {
                        s.insertNewUser(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, "e");
                        s.writeToLog("user inserted. name: " + TextBox1.Text + ", id : " + TextBox2.Text + ", Hourly wage : " + TextBox3.Text + ", Password : " + TextBox4.Text + ", type: employee.");

                        Label1.Visible = true;
                        Button2.Visible = true;
                    }
                    else
                    {
                        s.insertNewUser(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, "m");
                        s.writeToLog("user inserted. name: " + TextBox1.Text + ", id : " + TextBox2.Text + ", Hourly wage : " + TextBox3.Text + ", Password : " + TextBox4.Text + ", type: manager.");

                        Label1.Visible = true;
                        Button2.Visible = true;

                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }
    }
}