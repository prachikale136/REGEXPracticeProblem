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

        public void validateUperCasePassword(string ucPassword)
        {
            string UCPassword = "^[A-Z]+.{8,}?";
            if (Regex.IsMatch(ucPassword, UCPassword))
                Console.WriteLine(ucPassword + " is Valid");
            else
                Console.WriteLine(ucPassword + " is Invalid");
        }
        //For Numeric Password
        public void validateNumericPassword(string NumericPassword)
        {
            string numericPassword = "^.{8,}?";
            if (Regex.IsMatch(NumericPassword, numericPassword))
                Console.WriteLine(NumericPassword + " is Valid");
            else
                Console.WriteLine(NumericPassword + " is Invalid");
        }
        //For Special  Password
        public void validateSpecialcarPassword(string specialCarPassword)
        {
            string SpecialPassword = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";
            if (Regex.IsMatch(specialCarPassword, SpecialPassword))
                Console.WriteLine(specialCarPassword + " is Valid");
            else
                Console.WriteLine(specialCarPassword + " is Invalid");
        }

        //For all email

        public static string EMAIL_REGEXOne = "^[a-z0-9]+([._+-][0-9a-z]+)@+[a-z0-9]+.[a-z]{2,4}([.][a-z]{2}$)";
        public static string EMAIL_REGEXTwo = "^[a-z0-9]+([._+-][0-9a-z]+)@+[a-z0-9]+.[a-z]{2,4}$";
        public static string EMAIL_REGEXThree = "(^[a-z0-9]+)@+[a-z0-9]+.[a-z]{2,4}([.][a-z]{2}$)";
        public static string EMAIL_REGEXFour = "(^[a-z0-9]+)@+[a-z0-9]+.[a-z]{2,4}$";
        public void validateAllTypeEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL_REGEXOne) || Regex.IsMatch(email, EMAIL_REGEXTwo) || Regex.IsMatch(email, EMAIL_REGEXThree) || Regex.IsMatch(email, EMAIL_REGEXFour))
                Console.WriteLine(email + " is Valid");
            else
                Console.WriteLine(email + " is Invalid");
        }
    }
}
