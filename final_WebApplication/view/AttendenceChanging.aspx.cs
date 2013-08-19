using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class AttendenceChanging : System.Web.UI.Page
    {
        bl SystemDAL;
        LinkedList<string> usersStrings;
        user u;

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
            Button3.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int j = 1; j < 128; j++)
            {
                (form1.FindControl("TextBox" + j) as TextBox).Text = "";
                (form1.FindControl("TextBox" + j) as TextBox).ForeColor = System.Drawing.Color.Black;
                (form1.FindControl("TextBox" + j) as TextBox).Visible = false;
            }
            string selected = DropDownList1.Text;
            string idSelected = getId(selected);
            Session["cId"] = idSelected;
            u = SystemDAL.getUser(idSelected);
            if (u != null)
                if (u.Shifts.Count() > 0)
                {
                    GenerateTable(4, u.Shifts.Count());
                    Button3.Enabled = true;
                }
        }

        private void GenerateTable(int p1, int p2)
        {
            u = SystemDAL.getUser((string)Session["cId"]);
            LinkedList<shift> currentMounth = SystemDAL.getMonthRangeShifts(u.Id, DateTime.Now.ToString(@"dd-MM-yy").Split('-')[1], DateTime.Now.ToString(@"dd-MM-yy").Split('-')[2]);
            int i = 2;

            if (currentMounth != null)
            {
                foreach (shift s in currentMounth)
                {
                    if (i < 126)
                    {
                        if (s.End != "")
                        {
                            (form1.FindControl("TextBox" + (i - 1)) as TextBox).Text = s.Begin;
                            (form1.FindControl("TextBox" + (i + 0)) as TextBox).Text = s.End;
                            (form1.FindControl("TextBox" + (i + 1)) as TextBox).Text = s.Date;
                            (form1.FindControl("TextBox" + (i + 2)) as TextBox).Text = s.DateEnd;
                            (form1.FindControl("TextBox" + (i - 1)) as TextBox).Visible = true;
                            (form1.FindControl("TextBox" + (i + 0)) as TextBox).Visible = true;
                            (form1.FindControl("TextBox" + (i + 1)) as TextBox).Visible = true;
                            (form1.FindControl("TextBox" + (i + 2)) as TextBox).Visible = true;
                        }
                    }
                    i += 4;
                }
            }
        }

        private string getId(string selected)
        {
            return selected.Substring(selected.IndexOf("(") + 1, selected.IndexOf(")") - selected.IndexOf("(") - 2);
        }





        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!checkAllValOk())
            {
                return;
            }
            u = SystemDAL.getUser((string)Session["cId"]);
            user uNew = new user(u);
            uNew.Shifts.Clear();
            uNew.Shifts = SystemDAL.addShiftsFromAnotherMonth(u.Shifts, DateTime.Now.ToString(@"dd-MM-yy").Split('-')[1]);
            for (int i = 2; i < 126; )
            {
                shift s = new shift();
                s.Begin = (form1.FindControl("TextBox" + (i - 1)) as TextBox).Text;
                s.End = (form1.FindControl("TextBox" + i) as TextBox).Text;
                s.Date = (form1.FindControl("TextBox" + (i + 1)) as TextBox).Text;
                s.DateEnd = (form1.FindControl("TextBox" + (i + 2)) as TextBox).Text;
                
                (form1.FindControl("TextBox" + (i - 1)) as TextBox).Visible = false;
                (form1.FindControl("TextBox" + (i + 0)) as TextBox).Visible = false;
                (form1.FindControl("TextBox" + (i + 1)) as TextBox).Visible = false;
                (form1.FindControl("TextBox" + (i + 2)) as TextBox).Visible = false;
                
                if (s.Begin != "" && s.End != "" && s.Date != "" && s.DateEnd != "")
                {
                    uNew.addShift(s);
                }
                i += 4;
            }
            SystemDAL.UpdateUserWithDelete(uNew, u);

            foreach (shift s1 in uNew.Shifts)
            {
                if (!u.containShift(s1))
                {
                   SystemDAL.writeToLog("shift edit, user: "+uNew.Name +", id : "+uNew.Id+". new shift: "+s1.print()); 
                }
            }
            
            Button3.Enabled = false;
        }

        private bool checkAllValOk()
        {

            for (int j = 2; j < 126; )
            {
                string s = (form1.FindControl("TextBox" + (j - 1)) as TextBox).Text;
                string e = (form1.FindControl("TextBox" + (j + 0)) as TextBox).Text;
                string d = (form1.FindControl("TextBox" + (j + 1)) as TextBox).Text;
                string dEnd = (form1.FindControl("TextBox" + (j + 2)) as TextBox).Text;

                if (s != "" && e != "" && d != "" && dEnd != "")
                {
                    if (!checkTimeOk(s))
                    {
                        (form1.FindControl("TextBox" + (j - 1)) as TextBox).ForeColor = System.Drawing.Color.Red;
                        PrintErr("Time inserted in wrong format.");
                        Button3.Enabled = true;
                        return false;
                    }
                    else if (!checkTimeOk(e))
                    {
                        (form1.FindControl("TextBox" + (j)) as TextBox).ForeColor = System.Drawing.Color.Red;
                        PrintErr("Time inserted in wrong format.");
                        Button3.Enabled = true;
                        return false;
                    }

                    else if (!checkDateOk(d))
                    {
                        (form1.FindControl("TextBox" + (j + 1)) as TextBox).ForeColor = System.Drawing.Color.Red;
                        PrintErr("Date inserted in wrong format, or invalid month.");
                        Button3.Enabled = true;
                        return false;
                    }
                    else if (!checkDateOk(dEnd))
                    {
                        (form1.FindControl("TextBox" + (j + 2)) as TextBox).ForeColor = System.Drawing.Color.Red;
                        PrintErr("Date inserted in wrong format, or invalid month.");
                        Button3.Enabled = true;
                        return false;
                    }
                    else if (!checkStartVsEnd(s, e, d, dEnd))
                    {
                        (form1.FindControl("TextBox" + (j)) as TextBox).ForeColor = System.Drawing.Color.Red;
                        PrintErr("Date inserted in wrong format.");
                        Button3.Enabled = true;
                        return false;
                    }

                }
                else if (!allOrNothing(s != "", e != "", d != "", dEnd != ""))
                {
                    PrintErr("Please fill three cells or Nothing.");
                    Button3.Enabled = true;
                    return false;
                }
                j += 4;
            }
            for (int j = 2; j < 126; )
            {
                string s = (form1.FindControl("TextBox" + (j - 1)) as TextBox).Text;
                string e = (form1.FindControl("TextBox" + (j + 0)) as TextBox).Text;
                string d = (form1.FindControl("TextBox" + (j + 1)) as TextBox).Text;
                string dEnd = (form1.FindControl("TextBox" + (j + 2)) as TextBox).Text;
                if (!checkForDuplicate(s, e, d, dEnd, j))
                {
                    PrintErr("Shift already exists");
                    Button3.Enabled = true;
                    return false;
                }
                j += 4;
            }
            return true;
        }

        private bool checkForDuplicate(string s, string e, string d, string dEnd, int j)
        {
            LinkedList<shift> uNew = new LinkedList<shift>();
            for (int i = 2; i < 126; )
            {
                if (i != j)
                {
                    shift sh = new shift();
                    sh.Begin = (form1.FindControl("TextBox" + (i - 1)) as TextBox).Text;
                    sh.End = (form1.FindControl("TextBox" + (i + 0)) as TextBox).Text;
                    sh.Date = (form1.FindControl("TextBox" + (i + 1)) as TextBox).Text;
                    sh.DateEnd = (form1.FindControl("TextBox" + (i + 2)) as TextBox).Text;

                    if (sh.Begin != "" && sh.End != "" && sh.Date != "" && sh.DateEnd != "")
                        uNew.AddFirst(sh);
                }
                i += 4;
            }
            foreach (shift sh in uNew)
            {
                if (s == sh.Begin && e == sh.End && d == sh.Date && sh.DateEnd == dEnd)
                {
                    return false;
                }
                else if (new shift().IsCoincidentShifts(s, e, d, dEnd, sh))
                {
                    return false;
                }
            }
            return true;
        }

        private bool allOrNothing(bool a, bool b, bool c, bool d)
        {
            return (a && b && c && d) || (!a && !b && !c && !d);

        }

        private bool checkStartVsEnd(string start, string end, string dateStart, string dateEnd)
        {
            DateTime d1;
            DateTime.TryParseExact(start + " " + dateStart, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d1);

            DateTime d2;
            DateTime.TryParseExact(end + " " + dateEnd, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d2);

            if (d1 <= d2)
            {
                return true;
            }
            else return false;

        }

        private bool checkDateOk(string tb)
        {
            if (tb.Count() != 8)
            {
                return false;
            }
            DateTime dateValue;
            string[] formats = { "dd-MM-yy" };
            if (DateTime.TryParseExact(tb, formats, new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
            {
                if (tb.Split('-')[1] == DateTime.Now.ToString(@"dd-MM-yy").Split('-')[1] && tb.Split('-')[2] == DateTime.Now.ToString(@"dd-MM-yy").Split('-')[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool checkTimeOk(string tb)
        {
            if (tb.Count() != 5)
            {
                return false;
            }
            DateTime dateValue;
            string[] formats = { "HH-mm" };
            return DateTime.TryParseExact(tb, formats, new CultureInfo("en-US"), DateTimeStyles.None, out dateValue);
        }

        private void PrintErr(string err)
        {
            string myStringVariable = string.Empty;
            myStringVariable = err;
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);

        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }

       

    }
}