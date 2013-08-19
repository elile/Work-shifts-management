using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class changeDetailsForEmployee : System.Web.UI.Page
    {
        private bl SystemDAL;
        private LinkedList<string> usersStrings;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
            SystemDAL = new bl();
            usersStrings = SystemDAL.getAllUsersNameAndId();
            foreach (string s in usersStrings)
            {
                if (DropDownList1.Items.FindByText(s) == null)
                {
                    DropDownList1.Items.Add(s);
                }
            }
            Button2.Enabled = false;
        }

        private string getId(string selected)
        {
            return selected.Substring(selected.IndexOf("(") + 1, selected.IndexOf(")") - selected.IndexOf("(") - 2);
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            user u = SystemDAL.getUser(getId(DropDownList1.Text));
            Session["IdUpdate"] = u.Id;
            TextBox1.Text = u.Name;
            TextBox2.Text = u.Id;
            TextBox3.Text = u.HourlyWage;
            TextBox4.Text = u.Pass;
            Session["oldU"] = u.print();
            Button2.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                PrintErr("Please enter a ID, can not be empty.");
                return;
            }
            if (SystemDAL.getUser(TextBox2.Text) != null && (string)Session["IdUpdate"] != TextBox2.Text)
            {
                PrintErr("Edit details failed, maybe there is another user with the same ID number.");
                return;
            }
            if (DropDownList2.Text == "employee")
            {
                user u = new user(TextBox2.Text, TextBox1.Text, "e", "", TextBox3.Text, false, TextBox4.Text);
                SystemDAL.UpdateUserDetails(u, (string)Session["IdUpdate"]);
                SystemDAL.writeToLog("Update user: " + "old details: " + Session["oldU"] + ". new details: " + u.print());
                refreshDrop();
            }
            else
            {
                user u = new user(TextBox2.Text, TextBox1.Text, "m", "", TextBox3.Text, false, TextBox4.Text);
                SystemDAL.UpdateUserDetails(u, (string)Session["IdUpdate"]);
                SystemDAL.writeToLog("Update user: " + "old details: " + Session["oldU"] + ". new details: " + u.print());
                refreshDrop();
            }
            Button2.Enabled = false;
        }

        private void PrintErr(string err)
        {
            string myStringVariable = string.Empty;
            myStringVariable = err;
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);

        }

        public void refreshDrop()
        {
            DropDownList1.Items.Clear();
            SystemDAL = new bl();
            usersStrings = SystemDAL.getAllUsersNameAndId();
            foreach (string s in usersStrings)
            {
                if (DropDownList1.Items.FindByText(s) == null)
                {
                    DropDownList1.Items.Add(s);
                }
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }






    }
}