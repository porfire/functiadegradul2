using System;
using System.Collections.Generic;

namespace functiadegradul2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti ecuatia de gradul 2:");
            Console.ReadLine();

            float a, b, c, delta;
         
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Ecuatie nedeterminata");
                    }
                    else
                    {
                        Console.WriteLine("Ecuatie imposibila");
                    }
                }
                else
                {
                    Console.WriteLine("Ecuatie de gradul 1 cu x1 = {0}", -c/b);
                }
            }

            else
            {
                Console.WriteLine("Ec de gradul II");
                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Ecuatie cu valori complexe");
                }
                else
                {
                    if (delta == 0)
                    {
                        Console.WriteLine("Ecuatia are solutii egale, x1 = x2 = {0}", -b / (2 * a));

                    }

                    else {
                        Console.WriteLine("Ecuatia are doua solutii diferite");
                        Console.WriteLine("x1 = {0}", (-b  + Math.Sqrt(delta))/(2*a));
                        Console.WriteLine("x1 = {0}", (-b  - Math.Sqrt(delta))/(2*a));
                    }
                }
            }

            Console.Read();
        }
    }
}
