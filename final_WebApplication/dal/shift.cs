using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_WebApplication
{
    public class shift
    {
        private string date;
        private string begin;
        private string end;
        private string dateEnd;


        public shift(string date, string begin, string end, string dateEnd)
        {
            this.date = date;
            this.begin = begin;
            this.end = end;
            this.dateEnd = dateEnd;

        }

        public shift()
        {
        }

        public string Date { get { return date; } set { date = value; } }
        public string DateEnd { get { return dateEnd; } set { dateEnd = value; } }
        public string Begin { get { return begin; } set { begin = value; } }
        public string End { get { return end; } set { end = value; } }

        public Boolean isIn()
        {
            if (end == null)
            {
                return true;
            }
            return false;
        }

        public double calcPayment(int hourlyWage)
        {
            DateTime d1;
            DateTime.TryParseExact(begin + " " + date, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d1);

            DateTime d2;
            DateTime.TryParseExact(end + " " + dateEnd, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d2);

            TimeSpan t = d2 - d1;
            return t.TotalHours * hourlyWage;
        }

        public Double convertMyTimeToInt(string time)
        {
            if (time != null)
            {
                string[] token = time.Split('-');
                Double beginHour = Convert.ToDouble(token[0]) + (Convert.ToDouble(token[1]) / 60);
                return beginHour;
            }
            else return -1;
        }


        /* public Boolean IsCoincidentShifts(string s, string e, string s2, string e2)
         {
             Double ds = convertMyTimeToInt(s);
             Double de = convertMyTimeToInt(e);
             Double ds2 = convertMyTimeToInt(s2);
             Double de2 = convertMyTimeToInt(e2);
             if (ds < ds2 && de < de2)
             {
                 return false;
             }
             else if (ds < ds2 && de > ds2 && de < de2)
             {
                 return false;
             }
             else if (ds > ds2 && ds < de2 && de > de2)
             {
                 return false;
             }
             else return true;
         }*/


        public Boolean IsEqwalShits(shift a, shift b)
        {
            if (a.Begin == b.Begin && a.End == b.End && a.Date == b.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        internal bool IsCoincidentShifts(string start, string end, string date, string dateEnd, shift other)
        {
            DateTime d1;
            DateTime.TryParseExact(start + " " + date, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d1);

            DateTime d2;
            DateTime.TryParseExact(end + " " + dateEnd, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d2);

            DateTime d3;
            DateTime.TryParseExact(other.Begin + " " + other.Date, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d3);

            DateTime d4;
            DateTime.TryParseExact(other.End + " " + other.DateEnd, new string[] { "HH-mm dd-MM-yy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d4);

            return ((d3 >= d1 && d3 < d2) || (d4 <= d2 && d4 > d1) || (d3 <= d1 && d4 >= d2));
        }



        internal string print()
        {
            return "started : " + date + " " + begin + ", finish : " + dateEnd + " " + end + " .";
        }
    }
}