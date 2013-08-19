using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;


namespace final_WebApplication.view
{
    public partial class EnterYourId : System.Web.UI.Page
    {
        private string IsManager;
        private bl SystemDAL;
        private user u;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
            date.Text = DateTime.Now.ToString(@"dd-MM-yy");
            IsManager = Request.QueryString["manager"];
            SystemDAL = new bl();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string id = TextBox1.Text;
            string pass = TextBox2.Text;
            if (id == "" || pass == "")
            {
                Label4.Visible = true;
                return;
            }
            u = SystemDAL.getUser(id);
            if (u == null)
            {
                Label4.Visible = true;
                return;
            }
            else if (u.Pass != pass)
            {
                Label4.Visible = true;
                return;
            }
            else
            {
                if (IsManager == "1")
                {
                    if (u.Type == "m")
                    {
                        Session.Add("userIdm", id);
                        //FormsAuthentication.SetAuthCookie(id+"m", false);
                        //Session["ok1"] = true;
                        Response.Redirect("manager.aspx");
                    }
                    else
                    {
                        Label4.Visible = true;
                        return;
                    }
                }
                else
                {
                    Session.Add("userIde", id);
                    //FormsAuthentication.SetAuthCookie(id+"e", false);
                    //Session["ok2"] = true;
                    Response.Redirect("employee.aspx");

                }
            }
        }



    }
}