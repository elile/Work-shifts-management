using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace final_WebApplication
{
    public partial class statistic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userIdm"] == null)
                Response.Redirect("EnterYourId.aspx");
            bl dal = new bl();
            LinkedList<double> y = new LinkedList<double>();
            LinkedList<int> x = new LinkedList<int>();


            for (int i = DateTime.Now.Month; i > 0; i--)
            {
                x.AddFirst(i);
                double d = dal.getTotalPayForMounth(i, DateTime.Now.Year.ToString());
                y.AddFirst(d);
            }
            Chart2.Series[0].Points.DataBindXY(x, y);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }

        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month)).Select(day => new DateTime(year, month, day)).ToList();
        }

        protected void Chart2_Load(object sender, EventArgs e)
        {

        }








    }
}