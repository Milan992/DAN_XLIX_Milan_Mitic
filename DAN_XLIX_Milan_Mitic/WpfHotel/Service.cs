using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHotel.Model;

namespace WpfHotel
{
    class Service
    {
        internal bool IsOwner(string userName, string password)
        {
            string[] userPass = new string[2];
            int counter = 0;
            using (StreamReader sr = new StreamReader("../../OwnerAccess.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    userPass[counter] = line;
                    counter++;
                }
            }
            if (userName == userPass[0] && password == userPass[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsEmployee(string userName, string password)
        {
            try
            {
                using (HotelEntities context = new HotelEntities())
                {
                    tblAccount account = (from a in context.tblAccounts where a.UserName == userName && a.Pass == password select a).First();
                    tblEmployee employee = (from e in context.tblEmployees where e.AccountID == account.AccountID select e).First();
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        internal bool IsManager(string userName, string password)
        {
            try
            {
                using (HotelEntities context = new HotelEntities())
                {
                    tblAccount account = (from a in context.tblAccounts where a.UserName == userName && a.Pass == password select a).First();
                    tblManager manager = (from m in context.tblManagers where m.AccountID == account.AccountID select m).First();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
