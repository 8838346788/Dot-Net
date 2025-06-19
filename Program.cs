using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_FUNCTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AGE;
            Console.WriteLine("Enter your age: ");  
            AGE=int.Parse(Console.ReadLine());

            string NAME;
            Console.WriteLine("Enter your name: ");
            NAME = Console.ReadLine();
            Console.WriteLine("Hello " + NAME + ", you are " + AGE + " years old.");
        }
    }
}
