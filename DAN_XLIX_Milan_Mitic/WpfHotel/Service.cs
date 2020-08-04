using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        internal bool IsManager(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
