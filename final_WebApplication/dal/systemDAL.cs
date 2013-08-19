using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Configuration.Internal;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace final_WebApplication
{
    public class systemDAL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public systemDAL()
        {
            server = "localhost";
            database = "finaldb";
            uid = "eli";
            password = "eli";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlDataReader excQuery(string q)
        {
            MySqlCommand cmd = new MySqlCommand(q, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        public user getUser(string id)
        {
            connection.Open();
            user u = new user();
            MySqlDataReader dataReader = excQuery("SELECT * FROM workerlist WHERE id='" + id + "'");
            if (!dataReader.HasRows)
            {
                connection.Close();
                return null;
            }
            if (dataReader.Read())
            {
                u = new user(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), false, dataReader[5].ToString());
            }
            connection.Close();
            connection.Open();
            dataReader = excQuery("SELECT start, finish, date, dateEnd FROM  shifts WHERE id='" + id + "'");
            shift s;
            while (dataReader.Read())
            {
                s = new shift(dataReader[2].ToString(), dataReader[0].ToString(), dataReader[1].ToString(), dataReader[3].ToString());
                u.addShift(s);
            }
            connection.Close();
            return u;
        }

        public void startShift(string id, shift s)
        {
            user u = getUser(id);
            u.addShift(s);
            u.Online = true;
            connection.Open();
            excQuery("INSERT INTO `finaldb`.`shifts` (`id`, `start`, `finish`, `date`) VALUES ('" + id + "', '" + s.Begin + "', '" + s.End + "', '" + s.Date + "')");
            connection.Close();
        }

        public void endShift(string id, string timeEnd, string dateEnd)
        {

            user u = getUser(id);
            shift open = u.returnTheOpenShift();

            u.closeShift(open, timeEnd, dateEnd);
            connection.Open();
            excQuery("UPDATE `finaldb`.`shifts` SET `finish` = '" + timeEnd + "', `dateEnd` = '" + dateEnd + "' WHERE `shifts`.`id` = '" + id + "' AND `shifts`.`start` = '" + open.Begin + "' AND `shifts`.`finish` = '' AND `shifts`.`date` = '" + open.Date + "' AND `shifts`.`dateEnd` = '';");
            connection.Close();
        }

        public void insertNewUser(string name, string id, string hourlyWage, string pass, string type)
        {
            string q = "INSERT INTO `finaldb`.`workerlist` (`id`, `name`, `type`, `email`, `hourly_wage`, `pass`) VALUES ('" + id + "', '" + name + "', '" + type + "', NULL, '" + hourlyWage + "', '" + pass + "');";
            connection.Open();
            excQuery(q);
            connection.Close();

        }

        public void UpdateUserDetails(user u, string id)
        {
            connection.Open();
            excQuery("UPDATE  `finaldb`.`workerlist` SET  `id` =  '" + u.Id + "',`name` =  '" + u.Name + "',`hourly_wage` =  '" + u.HourlyWage + "',`pass` =  '" + u.Pass + "' WHERE  `workerlist`.`id` =  '" + id + "';");
            connection.Close();
        }


        

        public LinkedList<user> getAllusers()
        {
            LinkedList<user> l = new LinkedList<user>();
            user u;
            string q = "SELECT * FROM `workerlist`";
            connection.Open();
            MySqlDataReader dataReader = excQuery(q);
            while (dataReader.Read())
            {
                u = new user();
                u.Id = dataReader[0].ToString();
                u.Name = dataReader[1].ToString();
                u.HourlyWage = dataReader[4].ToString();
                u.Pass = dataReader[5].ToString();

                l.AddFirst(u);
            }
            connection.Close();
            return l;
        }

        public LinkedList<string> getAllUsersNameAndId()
        {
            LinkedList<string> l = new LinkedList<string>();
            string s = "";
            string q = "SELECT id,name FROM  `workerlist`";
            connection.Open();
            MySqlDataReader dataReader = excQuery(q);
            while (dataReader.Read())
            {
                s = dataReader[1].ToString() + " (" + dataReader[0].ToString() + " )";
                l.AddFirst(s);
            }
            connection.Close();
            return l;
        }


        internal void UpdateUserWithDelete(user u, user uOld)
        {
            foreach (shift s in u.Shifts)
            {
                connection.Open();
                excQuery("INSERT INTO  `finaldb`.`shifts` (`id` ,`start` ,`finish` ,`date`,`dateEnd`) VALUES ('" + u.Id + "',  '" + s.Begin + "',  '" + s.End + "',  '" + s.Date + "',  '" + s.DateEnd + "');");
                connection.Close();
            }
        }

        public void DeleteShift(string userId, shift s)
        {
            connection.Open();
            excQuery("DELETE FROM `finaldb`.`shifts` WHERE `shifts`.`id` = '" + userId + "' AND `shifts`.`start` = '" + s.Begin + "' AND `shifts`.`finish` = '" + s.End + "' AND `shifts`.`date` = '" + s.Date + "' AND `shifts`.`dateEnd` = '" + s.DateEnd + "';");
            connection.Close();
        }

 

        public LinkedList<string> getShiftsInDay(string date)
        {
            string q = "SELECT w.name, s.id, s.start, s.finish, s.date, s.dateEnd FROM shifts AS s, workerlist AS w WHERE s.id = w.id AND (s.date <=  '" + date + "' AND ( s.dateEnd >= '" + date + "' OR s.dateEnd = ''))";

            connection.Open();
            LinkedList<string> ret = new LinkedList<string>();
            MySqlDataReader dataReader = excQuery(q);
            if (!dataReader.HasRows)
            {
                connection.Close();
                return null;
            }
            while (dataReader.Read())
            {
                string insert = dataReader[0].ToString() + ";" + dataReader[1].ToString() + ";" + dataReader[2].ToString() + ";" + dataReader[3].ToString() + ";" + dataReader[4].ToString() + ";" + dataReader[5].ToString();
                ret.AddFirst(insert);
            }
            connection.Close();
            return ret;
        }


        internal double getTotalPayForMounth(int i, string y)
        {
            DateTime Dnow;
            if (i < 10)
                Dnow = Convert.ToDateTime("01-0" + i + "-" + y);
            else
                Dnow = Convert.ToDateTime("01-" + i + "-" + y);
            double ret = 0;
            string d_now1 = Dnow.ToString("dd-MM-yy");
            string d_now = d_now1.Split('-')[1] + "-" + d_now1.Split('-')[2];
            string q = "SELECT w.hourly_wage, s.start, s.finish, s.date, s.dateEnd FROM shifts AS s, workerlist AS w WHERE s.id = w.id ";
            connection.Open();
            MySqlDataReader dataReader = excQuery(q);
            if (!dataReader.HasRows)
            {
                connection.Close();
                return 0;
            }
            while (dataReader.Read())
            {
                string hourlyWages = dataReader[0].ToString();
                string start = dataReader[1].ToString();
                string end = dataReader[2].ToString();
                string dStart = dataReader[3].ToString();
                string dEnd = dataReader[4].ToString();
                if (bl.isThisMounth(d_now, dStart, dEnd))
                {
                    ret += new shift(dStart, start, end, dEnd).calcPayment(Convert.ToInt16(hourlyWages));
                }
            }
            connection.Close();
            return ret;
        }

       

        public void writeToLog(string message)
        {
            string q = "INSERT INTO `finaldb`.`logfile` (`id`, `time`, `date`, `details`) VALUES (NULL, '" + DateTime.Now.ToString("HH:mm:ss") + "', '" + DateTime.Now.ToString(@"yyyy-MM-dd") + "', '" + message + "');";
            connection.Open();
            excQuery(q);
            connection.Close();
        }


        public LinkedList<string> readFromLog()
        {
            LinkedList<string> ret = new LinkedList<string>();
            string q = "SELECT * FROM logfile ORDER BY DATE(date) DESC , time DESC";
            connection.Open();
            MySqlDataReader dataReader = excQuery(q);
            while (dataReader.Read())
            {
                ret.AddLast(dataReader[1].ToString() + ";" + dataReader[2].ToString() + ";" + dataReader[3].ToString());
            }
            connection.Close();
            return ret;
        }









    }


}