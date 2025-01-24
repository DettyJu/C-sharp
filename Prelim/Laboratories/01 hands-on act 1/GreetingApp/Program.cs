using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            string name;
            int courses;
            decimal price;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses : ");
            courses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nName : " + name);
            Console.WriteLine("Total enrolled courses: " + courses);
            Console.WriteLine("Price of my favorite book: " + price);

            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();


        }
    }
}
