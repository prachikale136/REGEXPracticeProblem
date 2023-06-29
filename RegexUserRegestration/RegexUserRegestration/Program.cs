using System;
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
                Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last NAme \n3.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
