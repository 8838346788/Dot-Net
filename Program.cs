using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oprators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int mark1, mark2, sum;
            Console.WriteLine("Enter Your Mark1 :");
            mark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your MArk2 :");
            mark2 = int.Parse(Console.ReadLine());

            sum = mark1 + mark2;
            Console.WriteLine();
            Console.WriteLine("sum :" + sum);
            Console.ReadLine();

            int difference;
            difference = mark1 - mark2;
            Console.WriteLine();
            Console.WriteLine("difference of Mark1 and Mark2 " + difference);
            Console.ReadLine();

            int product;
            product = mark1 * mark2;
            Console.WriteLine();
            Console.WriteLine("product :" + product);
            Console.ReadLine();

            int quotient;
            quotient = mark1 / mark2;
            Console.WriteLine();
            Console.WriteLine("quotient :" + quotient);
            Console.ReadLine();

            int remainder;
            remainder = mark1 % mark2;
            Console.WriteLine();
            Console.WriteLine("Remainder :" + remainder);*/


            int mark1, mark2;

            Console.Write("Enter Your Mark1 :");
            mark1=int.Parse(Console.ReadLine());

            Console.Write("Enter Your Mark2 :");
            mark2=int.Parse(Console.ReadLine());

            Console.WriteLine("Mark1 equle to  Mark2 :" +(mark1==mark2));
            Console.ReadLine();

            Console.WriteLine("Mark1 not equle to  Mark2 :" + (mark1 != mark2));
            Console.ReadLine();

            Console.WriteLine("Mark1 is less than  Mark2 :" + (mark1 < mark2));
            Console.ReadLine();

            Console.WriteLine("Mark1 is lessthan or equle to Mark2 :" + (mark1 <= mark2));
            Console.ReadLine();

            Console.WriteLine("Mark1 is greater than  Mark2 :" + (mark1 > mark2));
            Console.ReadLine();


            Console.WriteLine("Mark1is greaterthan or equle to  Mark2 :" + (mark1 >= mark2));
            Console.ReadLine();


           








            Console.ReadLine();

        }
    }
}
