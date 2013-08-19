using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class realTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
            Timer myTimer = new Timer();

            string day = DateTime.Now.ToString(@"dd-MM-yy");
            LinkedList<string> list = new bl().getShiftsInDay(day);
            if (list != null)
            {
                foreach (string s in list)
                {
                    string[] splited = s.Split(';');
                    if (splited[3] == "")
                    {
                        Button b = new Button();
                        b.BorderWidth = Unit.Pixel(20);
                        b.BorderColor = System.Drawing.Color.White;
                        b.Width = Unit.Pixel(190);
                        b.Height = Unit.Pixel(190);

                        b.Text = "name : " + splited[0] + "\nid : " + splited[1] + "\nstarted : " + splited[2] + " " + splited[4];

                        DateTime d1;
                        DateTime.TryParseExact(splited[4] + " " + splited[2], new string[] { "dd-MM-yy HH-mm" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d1);

                        DateTime d2;
                        DateTime.TryParseExact(day + " " + DateTime.Now.ToString(@"HH-mm"), new string[] { "dd-MM-yy HH-mm" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d2);

                        double range = (d2 - d1).TotalHours;

                        if (range <= 8)
                        {
                            b.BackColor = System.Drawing.Color.Lime;
                        }
                        else if (range > 8 && range <= 12)
                        {
                            b.BackColor = System.Drawing.Color.Yellow;
                        }
                        else
                        {
                            b.BackColor = System.Drawing.Color.Red;
                        }
                        b.Click += new System.EventHandler(this.myHandler);
                        b.Attributes.Add("onclick", "javascript:if(confirm('you select worker, do you want to stop his shift ?')== false) return false;");
                        form1.Controls.Add(b);

                    }

                }

            }

        }

        private void myHandler(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
            string text = (sender as Button).Text;
            string[] spliter = text.Split(':');
            string id = getId(spliter[2]);
            new bl().endShift(id, DateTime.Now.ToString(@"HH-mm"), DateTime.Now.ToString(@"dd-MM-yy"));
        }

        private string getId(string p)
        {
            string ret = "";
            foreach (char c in p)
            {
                if (Char.IsNumber(c))
                {
                    ret += c;
                }
            }
            return ret;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }




    }
}