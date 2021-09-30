using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9AdressBook
{
    class uc4_Delete
    {
        public static void Delete()
        {
            Console.WriteLine("Press 1 if u want to delete the FirstName .");
            Console.WriteLine("Press 2 if u want to delete the LastName .");
            Console.WriteLine("Press 3 if u want to delete the Address .");
            Console.WriteLine("Press 4 if u want to delete the City .");
            Console.WriteLine("Press 5 if u want to delete the State .");
            Console.WriteLine("Press 6 if u want to delete the Zip Code .");
            Console.WriteLine("Press 7 if u want to delete the Phone Number .");
            Console.WriteLine("Press 8 if u want to delete the Email Id .");

            int Newcontact = int.Parse(Console.ReadLine());

            switch (Newcontact)
            {
                case 1:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine("successfully delete your FirstName ! .");
                    break;
                case 2:
                    Console.WriteLine("click on delete button");
                    Console.WriteLine("successfully delete your LastName !");
                    break;
                case 3:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine("successfully delete your Address !");
                    break;
                case 4:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine("successfully delete your City !");
                    break;
                case 5:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine("successfully delete your state !");
                    break;
                case 6:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine("successfully delete your Zip code !");
                    break;
                case 7:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine("successfully delete your Phone Number !");
                    break;
                case 8:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine("successfully delete your Email !");
                    break;
                default:
                    Console.WriteLine("click on delete button .");
                    Console.WriteLine(Console.ReadLine());
                    break;

            }
        }
    }
}