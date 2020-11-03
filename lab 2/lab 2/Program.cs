using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab 2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prob1........................
            Console.WriteLine("Input the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Even numbers are up to " + n + ": ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { Console.WriteLine(i); }

            }
            //prb02........................

            for (int i = 0; i <= 1; i++)
            {
                for (int x = 0; x <= 2; x++)
                {
                    Console.Write("X0");
                }
                Console.WriteLine(" ");
                for (int x = 0; x <= 2; x++)
                {
                    Console.Write("0X");

                }
                Console.WriteLine(" ");
            }
            //prob03..................
            for (int n = 1; n <= 5; n++)
            {
                int o = 0;
                for (int k = 1; k <= 5; k++)
                {

                    Console.Write(n + o);
                    o++;
                }
                Console.WriteLine("");
                o++;
            }
            //prob04...............
            int sum = 0;
            int sumx = 0;
            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 == 0)
                {
                    sum = sum + i;
                }

                if (i % 2 != 0)
                {
                    sumx = sumx + i;
                }

            }
            Console.WriteLine("The sum of Even number:");
            Console.WriteLine(sum);
            Console.WriteLine("The sum of odd number:");
            Console.WriteLine(sumx);
            //prb05
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

            }
            //prb06
            int i, f = 1, n = 5;
            for (i = 1; i <= n; i++)
            {
                f = f * i;

            }
            Console.Write(" Factorial of " + n + " is:  " + f);


            //prb07
            int i;
            for (i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(" \n");
            }
            for (i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(" \n");
            }
            //prb08
            Double p, c, b, m, cm, t, pr;
            Console.WriteLine("Enter your mark for Physics");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your mark for Chemistry");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your mark for Biology");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your mark for Mathematics");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your mark for Computer");
            cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark greater than or equal 90: Grade A+ \n Mark between 85 and 89: Grade A \n Mark between 80 and 85: Grade B + \n Mark between 75 and 79: Grade B \n Mark between 50 and 75: Grade C + \n Mark less than 50: Grade F");
            t = p + c + b + m + cm;
            pr = t / 5;
            Console.WriteLine("\nTotall mark " + t);
            Console.WriteLine("\nTotall percentage  " + pr);
            if (pr >= 90)
            { Console.WriteLine("\nGrade A+"); }
            else if (pr >= 85 && pr <= 89)
            { Console.WriteLine("\nGrade A"); }
            else if (pr >= 80 && pr <= 85)
            { Console.WriteLine("\nGrade B+"); }
            else if (pr >= 75 && pr <= 79)
            { Console.WriteLine("\nGrade B"); }
            else if (pr >= 50 && pr <= 75)
            { Console.WriteLine("\nGrade C+"); }
            else
            { Console.WriteLine("\nGrade F"); }



            Console.ReadLine();

        }


    }
}

