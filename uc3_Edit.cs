using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9AdressBook
{
    class uc3_Edit
    {
         
        public static void Edit()
        {
                 Console.WriteLine("Press 1 if u want to edit the FirstName .");
                Console.WriteLine("Press 2 if u want to edit the LastName .");
                Console.WriteLine("Press 3 if u want to edit the Address .");
                Console.WriteLine("Press 4 if u want to edit the City .");
                Console.WriteLine("Press 5 if u want to edit the State .");
                Console.WriteLine("Press 6 if u want to edit the Zip Code .");
                Console.WriteLine("Press 7 if u want to edit the Phone Number .");
                Console.WriteLine("Press 8 if u want to edit the Email Id .");

                int Newcontact = int.Parse(Console.ReadLine());
            
                switch (Newcontact)
                {
                    case 1:
                        Console.WriteLine("Enter your new First Name :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Enter your new Last Name :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter your new address :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Enter your new city :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Enter your new state :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Enter your new zip :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Enter your new Phone number :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Enter your new Email :");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("click on next button :");
                        Console.WriteLine(Console.ReadLine());
                        break;

                }
        }
    }
}
