using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Hello, world!\n");
            //Console.WriteLine("It is now: " + DateTime.Now.ToString() + "\n");

            //Console.Write("Please enter your First Name: ");
            //string fname = Console.ReadLine();
            //Console.Write("Last: ");
            //string lname = Console.ReadLine();

            //Console.WriteLine("Hello, " + (fname) + " " + lname + "\n");
            //Console.WriteLine("The name {0} {1} is a great name", fname, lname);



            /******************** App 2***********************/
            //Console.WriteLine("<PLEASE LOG IN>\n");

            //Console.Write("Enter your username: ");
            //string username = Console.ReadLine();
            //Console.Write("Enter your password: ");
            //string password = Console.ReadLine();

            //Console.WriteLine("\n" + username + " logged in at " + DateTime.Now.ToString() + ".");
            //Console.WriteLine("Login credentials: ");
            //Console.WriteLine("\tusername: {0}", username);
            //Console.WriteLine("\tpassword: {0}\n", password);



            /******************** App 3***********************/
            //Console.WriteLine("This program will add 2 numbers.");
            //Console.Write("Enter the first number: ");
            //string num1 = Console.ReadLine();
            //Console.Write("Enter the second number: ");
            //string num2 = Console.ReadLine();

            //int n1 = Convert.ToInt32(num1);
            //int n2 = Convert.ToInt32(num2);

            //Console.WriteLine("{0} + {1} = {2}", num1, num2, n1 + n2);



            /******************** App 4***********************/
            Console.Write("Enter a date: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(date.ToShortDateString() + " is a " + date.DayOfWeek + ", day #" + date.DayOfYear);


            /******************** App 5***********************/


        }
    }
}
