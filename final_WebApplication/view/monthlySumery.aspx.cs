using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication.view
{
    public partial class monthlySumery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
            Table1.Visible = false;

        }

        protected void celanderSel_change(object sender, EventArgs e)
        {
            Table1.Visible = false;
            string day = Calendar1.SelectedDate.ToString(@"dd-MM-yy");
            LinkedList<string> ret = new bl().getShiftsInDay(day);
            if (ret != null)
            {
                foreach (string s in ret)
                {
                    TableRow Row = new TableRow();
                    TableCell nCell = new TableCell();
                    string[] splited = s.Split(';');
                    TableCell Cell;
                    if (splited[3] != "")
                    {
                        nCell.Text = splited[0];
                        Row.Cells.Add(nCell);
                        for (int i = 0; i < 24; i++)
                        {
                            Cell = new TableCell();
                            Cell.BorderColor = System.Drawing.Color.Black;
                            Cell.BorderWidth = Unit.Pixel(1);
                            Cell.Width = Unit.Pixel(40);
                            if (Convert.ToInt16(splited[4].Split('-')[0]) < Convert.ToInt16(splited[5].Split('-')[0]))
                            {
                                if (Convert.ToInt16(splited[4].Split('-')[0]) < Convert.ToInt16(day.Split('-')[0]) && Convert.ToInt16(day.Split('-')[0]) < Convert.ToInt16(splited[5].Split('-')[0]))
                                {
                                    Cell.BackColor = System.Drawing.Color.Yellow;
                                }
                                if (Convert.ToInt16(new shift().convertMyTimeToInt(splited[2])) <= i && Convert.ToInt16(day.Split('-')[0]) <= Convert.ToInt16(splited[4].Split('-')[0]))
                                {
                                    Cell.BackColor = System.Drawing.Color.Yellow;
                                }
                                if (Convert.ToInt16(new shift().convertMyTimeToInt(splited[3])) >= i && Convert.ToInt16(day.Split('-')[0]) >= Convert.ToInt16(splited[5].Split('-')[0]))
                                {
                                    Cell.BackColor = System.Drawing.Color.Yellow;
                                }
                            }
                            if (Convert.ToInt16(new shift().convertMyTimeToInt(splited[2])) <= i && Convert.ToInt16(new shift().convertMyTimeToInt(splited[3])) >= i)
                            {
                                Cell.BackColor = System.Drawing.Color.Yellow;
                            }
                            Row.Cells.Add(Cell);
                        }
                    }

                    Table1.Rows.Add(Row);

                }
            }
            Table1.Visible = true;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");

        }
    }
}