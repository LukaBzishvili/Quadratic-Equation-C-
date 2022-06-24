using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadratuli_gantoleba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, d;

            double? x1, x2;

            bool hasRoots;


            Console.Write("A = ");

            a = Convert.ToDouble(Console.ReadLine());



            Console.Write("B = ");

            b = Convert.ToDouble(Console.ReadLine());



            Console.Write("C = ");

            c = Convert.ToDouble(Console.ReadLine());



            d = GetD(a, b, c);

            Console.WriteLine("D = " + d);



            hasRoots = GetRoots(a, b, c, out x1, out x2);


            if (hasRoots)
            {

                Console.WriteLine("X1 = " + x1);

                Console.WriteLine("X2 = " + x2);

            }
            else
            {

                Console.WriteLine("No roots found!");

            }


            Console.ReadKey();

        }



        static double GetD(double a, double b, double c)
        {

            return Math.Pow(b, 2) - 4 * a * c;

        }



        static bool GetRoots(double a, double b, double c, out double? x1, out double? x2)
        {

            double d = GetD(a, b, c);

            if (d >= 0)
            {

                x1 = (-b - Math.Sqrt(d)) / (2 * a);

                x2 = (-b + Math.Sqrt(d)) / (2 * a);

                return true;

            }

            x1 = x2 = null;

            return false;

        }

    }
}


