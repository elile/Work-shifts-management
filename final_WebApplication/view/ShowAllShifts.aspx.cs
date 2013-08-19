using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_WebApplication
{
    public partial class ShowAllShifts : System.Web.UI.Page
    {

        private user u;
        private string user_id;
        private bl SystemDAL;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIde"] == null)
                Response.Redirect("EnterYourId.aspx");
            user_id = (string)Session["userIde"];
            SystemDAL = new bl();
            u = SystemDAL.getUser(user_id);

            Label1.Text ="hello "+ u.Name+", your shifts:";
            LinkedList<shift> shifts = u.Shifts;

            TableRow tRow1 = new TableRow();
            Table1.Rows.Add(tRow1);
            TableCell tCell1 = new TableCell();
            tCell1.Text = "Starting time";
            tRow1.Cells.Add(tCell1);
            TableCell tCell2 = new TableCell();
            tCell2.Text = "End time";
            tRow1.Cells.Add(tCell2);
            TableCell tCell3 = new TableCell();
            tCell3.Text = "Date";
            tRow1.Cells.Add(tCell3);


            foreach (shift Shift in shifts)
            {
                TableRow tRow = new TableRow();
                Table1.Rows.Add(tRow);

                TableCell tCell11 = new TableCell();
                tCell11.Text = Shift.Begin;

                tRow.Cells.Add(tCell11);

                TableCell tCell22 = new TableCell();
                tCell22.Text = Shift.End;

                tRow.Cells.Add(tCell22);

                TableCell tCell33 = new TableCell();
                tCell33.Text = Shift.Date;

                tRow.Cells.Add(tCell33);
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("employee.aspx");
        }
    }
}