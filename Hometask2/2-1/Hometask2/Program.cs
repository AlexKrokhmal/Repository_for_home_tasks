using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            for (int i = 1; i < 101; i++)
            {
                                
                if (i % 3 != 0)
                {
                    if (i % 5 != 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine("Buzz");
                    }
                }
                else if (i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
                       
            Console.ReadKey();
        }
    }
}
