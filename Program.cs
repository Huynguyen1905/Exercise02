using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex01();
           //Ex02();
        // Ex03();
        }
        static void Ex01()
        {
            Console.WriteLine("Enter a number");
            string s = Console.ReadLine();
            double number = 0;
            while (!double.TryParse(s, out number)) 
            {
                Console.WriteLine("Number!");
                s = Console.ReadLine();
            }
            Console.WriteLine($"K degree:{number + 273}");
            Console.WriteLine($"F degree:{number * 18 / 10 + 32}");
        }
        static void Ex02() {
            Console.WriteLine("Enter radius:");
            string r = Console.ReadLine();
            double number = 0;
            while(!double.TryParse(r, out number))
            {
                Console.WriteLine("Number!");
                r = Console.ReadLine();
            }
            Console.WriteLine($"S={4 * Math.PI * number * number}");
            Console.WriteLine($"V={4 / 3 * Math.PI * number * number * number}");
        }
        static void Ex03()
        {
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
            Console.WriteLine($"a mod b = {number % numb}");    
        }
    }
}
    

        

        

