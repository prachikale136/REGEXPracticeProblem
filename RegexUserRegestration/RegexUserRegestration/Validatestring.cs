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
        public void validateEmailId(string emailID)
        {
            string EmailId = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";
            if (Regex.IsMatch(emailID, EmailId))
                Console.WriteLine(emailID + " is Valid");
            else
                Console.WriteLine(emailID + " is Invalid");
        }

        public void validateMobileNumber(string mobileNumber)
        {
            string MobileNumber = "^[6-9]{1}[0-9]{9}";
            if (Regex.IsMatch(mobileNumber,MobileNumber))
                Console.WriteLine(mobileNumber + " is Valid");
            else
                Console.WriteLine(mobileNumber + " is Invalid");
        }

        //For Password
        public void validatePassword(string password)
        {
            string Password = "^.{8,}?";
            if (Regex.IsMatch(password, Password))
                Console.WriteLine(password + " is Valid");
            else
                Console.WriteLine(password + " is Invalid");
        }
    }
}
