
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace username
{
    public class un
    {
        static void Main(string[] args) { }
        static public bool Login(string un, string pw)
        {
            string registeredUsername = "stephaniepalma";
            string registeredPassword = "palma123";

            return un == registeredUsername && pw == registeredPassword;
        }
    }
}
