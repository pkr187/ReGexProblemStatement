using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class User
    {
        //UC 1 Checkig for First Name Validation
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public void FirstName(string firstname)
        {
            Regex regex = new Regex(FIRSTNAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine("UC-1: Entered First Name is " + result);
        }
    }
}
    

