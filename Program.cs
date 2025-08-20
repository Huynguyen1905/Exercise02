using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2.H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex01();
            Ex02();
            Ex03();
            Ex04();
            Ex05();

        }
        static void Ex01()
        {
            //1.Write a C# Sharp program that takes two numbers as input and performs
            //an operation (+,-,*,/,%) on them and displays the result of that operation.
            Console.WriteLine("Enter a and b");
            Console.WriteLine("a=");
            string a = Console.ReadLine();
            double number = 0;
            while (!double.TryParse(a, out number))
            {
                Console.WriteLine("Number!");
                a = Console.ReadLine();
            }
            Console.WriteLine("b=");
            string b = Console.ReadLine();
            double numb = 0;
            while (!double.TryParse(b, out numb))
            {
                Console.WriteLine("Number!");
                b = Console.ReadLine();
            }
            Console.WriteLine($"a+b= {number + numb}");
            Console.WriteLine($"a-b= {number - numb}");
            Console.WriteLine($"a*b= {number * numb}");
            Console.WriteLine($"a/b= {number / numb}");
            Console.WriteLine($"a mod b = {number % numb}");

        }
        static void Ex02()
        {
            //2.Write a C# Sharp program to display certain values of the function
            //x = y2 + 2y + 1(using integer numbers for y, ranging from - 5 to + 5).
            Console.WriteLine("y\t|\tx");
            Console.WriteLine("------------------");
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"{y}\t|\t{x}");
            }
        }
        static void Ex03()
        {
            //3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as
            //input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
            Console.WriteLine("Enter distance in kilometers:");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in hours:");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in minutes:");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time in seconds:");
            double seconds = Convert.ToDouble(Console.ReadLine());
            double totalTimeInHours = hours + (minutes / 60) + (seconds / 3600);
            double distanceInMiles = distance * 0.621371; // 1 km = 0.621371 miles
            Console.WriteLine($"Speed in kmph = {distance / totalTimeInHours} Km/h");
            Console.WriteLine($"Speed in msph = {distanceInMiles / totalTimeInHours} miles/h");
        }
        static void Ex04()
        {
            //4.Write a C# Sharp program that takes the radius of a sphere as input and
            //calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
            Console.WriteLine("Enter radius:");
            string r = Console.ReadLine();
            double number = 0;
            while (!double.TryParse(r, out number))
            {
                Console.WriteLine("Number!");
                r = Console.ReadLine();
            }
            Console.WriteLine($"S={4 * Math.PI * number * number}");
            Console.WriteLine($"V={4 / 3 * Math.PI * number * number * number}");

        }
        static void Ex05()
        {
            //5.Write a C# Sharp program that takes a character as input
            //and checks if it is a vowel, a digit, or any other symbol.
            Console.WriteLine("Enter a character:");
            char ch = Console.ReadKey().KeyChar;
            if ("ueoaiUEOAI".IndexOf(ch) >= 0)
            {
                Console.WriteLine("\nThe character is a vowel.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("\nThe character is a digit.");
            }
            else
            {
                Console.WriteLine("\nThe character is another symbol.");
            }


        }
    }
}












