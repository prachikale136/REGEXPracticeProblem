﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegestration
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Regular Expression!");
            Validatestring validatestring= new Validatestring();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last NAme \n3. email id \n4. mobile number \n5. Password \n6.Password in upper Case \n7.  Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEnter First Name");
                        string fName = Console.ReadLine();
                        validatestring.validateFirstName(fName);
                        break;
                    case 2:
                        Console.WriteLine("\n enter the last name");
                        string lName = Console.ReadLine();
                        validatestring.validateLastName(lName);
                        break;
                    case 3:
                        Console.WriteLine("Enetr Email id");
                        string email = Console.ReadLine();
                        validatestring.validateEmailId(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter mobile number");
                        string mobileno = Console.ReadLine();
                        validatestring.validateMobileNumber(mobileno);
                        break;
                    case 5:
                        Console.WriteLine("Enter the password");
                        string  pass = Console.ReadLine();
                        validatestring.validatePassword(pass);
                        break;
                    case 6:
                        Console.WriteLine("Enter password");
                        string upperPass = Console.ReadLine();
                        validatestring.validateUperCasePassword(upperPass); 
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
