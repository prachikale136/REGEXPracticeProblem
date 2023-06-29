using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegestration
{
    internal class Validatestring
    {
        public string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public void validateFirstName(string fName)
        {
            if (Regex.IsMatch(fName, FirstName))
            {
                Console.WriteLine("First Name : " + fName);
            }
            else
            {
                Console.WriteLine("First alphabet should be capital");
            }
        }

        public void validateLastName(string lName)
        {
            if (Regex.IsMatch(lName, LastName))
            {
                Console.WriteLine("Last Name : " + lName);
            }
            else
            {
                Console.WriteLine("First alphabet must be capital");
            }
        }
    }
}
