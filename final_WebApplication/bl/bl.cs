using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_WebApplication
{
    public class bl
    {
        private systemDAL dal = new systemDAL();

        public user getUser(string id)
        {
            return dal.getUser(id);
        }

        public LinkedList<shift> getMonthRangeShifts(string id, string month, string year)
        {
            LinkedList<shift> ret = new LinkedList<shift>();
            LinkedList<shift> current = getUser(id).Shifts;
            foreach (shift s in current)
            {
                string temp = s.Date.Split('-')[1];
                string temp2 = s.Date.Split('-')[2];
                if (temp == month && temp2 == year && s.End != "")
                    ret.AddFirst(s);
            }
            if (ret.Count() > 0)
                return ret;
            else
                return null;
        }

        public void startShift(string id, shift s)
        {
            dal.startShift(id, s);
        }

        public void endShift(string id, string timeEnd, string dateEnd)
        {
            dal.endShift(id, timeEnd, dateEnd);
        }

        public void insertNewUser(string name, string id, string hourlyWage, string pass, string type)
        {
            dal.insertNewUser(name, id, hourlyWage, pass, type);

        }

        public void UpdateUserDetails(user u, string id)
        {
            dal.UpdateUserDetails(u, id);
        }


        

        public LinkedList<user> getAllusers()
        {
            return dal.getAllusers();

        }

        public LinkedList<string> getAllUsersNameAndId()
        {
            return dal.getAllUsersNameAndId();
        }


        internal void UpdateUserWithDelete(user u, user uOld)
        {
            DeleteAllShift(uOld);
            dal.UpdateUserWithDelete( u,  uOld);

        }

        public void DeleteShift(string userId, shift s)
        {
            dal.DeleteShift( userId,  s);
        }

        public void DeleteAllShift(user uOld)
        {
            foreach (shift s in uOld.Shifts)
            {
                dal.DeleteShift(uOld.Id, s);
            }
        }

        public LinkedList<shift> addShiftsFromAnotherMonth(LinkedList<shift> l, string month)
        {
            if (l != null)
            {
                LinkedList<shift> ret = new LinkedList<shift>();
                foreach (shift s in l)
                {
                    string temp = s.Date.Split('-')[1];
                    if (temp != month || s.End == "")
                        ret.AddFirst(s);
                }
                return ret;
            }
            else
                return null;
        }

        public LinkedList<string> getShiftsInDay(string date)
        {
            return dal.getShiftsInDay( date);
        }

        internal double getTotalPayForMounth(int i, string y)
        {
            return dal.getTotalPayForMounth(i,y);
        }

        internal static bool isThisMounth(string Dnow, string dStart, string dEnd)
        {
            if (dEnd != "")
            {
                string dS = dStart.Split('-')[1] + "-" + dStart.Split('-')[2];
                string dE = dEnd.Split('-')[1] + "-" + dEnd.Split('-')[2];
                if (Dnow == dS && Dnow == dE)
                    return true;
            }
            return false;
        }

        public void writeToLog(string message)
        {
            dal.writeToLog(message);
        }


        public LinkedList<string> readFromLog()
        {
            return dal.readFromLog();
        }





    }
}