using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_WebApplication
{
    public class user
    {
        private string id;
        private string email;
        private string name;
        private string type;
        private string hourlyWage;
        private string pass;
        private Boolean online;
        private LinkedList<shift> shifts;

        public user(user u)
        {
            id = u.Id;
            email = u.Email;
            name = u.Name;
            type = u.Type;
            hourlyWage = u.HourlyWage;
            pass = u.Pass;
            online = u.Online;
            shifts = new LinkedList<shift>(u.Shifts);
        }

        public user(string id, string name, string type, string email, string hourlyWage, Boolean online, string pass)
        {
            shifts = new LinkedList<shift>();
            this.id = id;
            this.email = email;
            this.name = name;
            this.type = type;
            this.hourlyWage = hourlyWage;
            this.online = online;
            this.pass = pass;
        }

        public user()
        {
        }

        public string Id { get { return id; } set { id = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }
        public string HourlyWage { get { return hourlyWage; } set { hourlyWage = value; } }
        public Boolean Online { get { return online; } set { online = value; } }
        public LinkedList<shift> Shifts { get { return shifts; } set { shifts = value; } }
        public string Pass { get { return pass; } set { pass = value; } }



        public void addShift(shift Shift)
        {
            shifts.AddFirst(Shift);
        }

        public void deleteShift(shift Shift)
        {
            foreach (shift s in shifts)
            {
                if (s.Begin == Shift.Begin && s.End == Shift.End && s.Date == Shift.Date && s.DateEnd == Shift.DateEnd)
                {
                    shifts.Remove(s);
                }
            }
        }



        public shift returnTheOpenShift()
        {

            foreach (shift s in shifts)
            {
                if (s.End == null || s.End == "")
                {
                    return s;
                }
            }
            return null;
        }

        public void closeShift(shift Shift, string time, string dateEnd)
        {
            foreach (shift s in shifts)
            {
                if (s.Begin == Shift.Begin && (s.End == null || s.End == ""))
                {
                    s.End = time;
                    s.DateEnd = dateEnd;
                }
            }
        }




        internal bool containShift(shift s1)
        {
            foreach (shift s in shifts)
            {
                if (s.IsEqwalShits(s, s1))
                {
                    return true;
                }
            }
            return false;

        }

        internal string print()
        {
            return "User name: " + name + ", id: " + id + ", type(e= employee, m= manager) : " + type + ", password: " + pass;
        }
    }
}