using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 1;
            int divideBy15 = 0;

            while (counter <= 100)            
            {

                divideBy15 = ModuleBy15(counter);

                //divideBy15 = Convert.ToInt32(counter % 15);

                //Console.Write("{0} - {1} - ", counter, divideBy15);

                switch (divideBy15)
                {
                    case 3:
                        WriteFizz();
                        break;
                    case 6:
                        WriteFizz();
                        break;
                    case 9:
                        WriteFizz();
                        break;
                    case 12:
                        WriteFizz();
                        break;
                    case 5:
                        WriteBuzz();
                        break;
                    case 10:
                        WriteBuzz();
                        break;
                    case 0:
                        WriteFizzBuzz();
                        break;
                    default:
                        Console.WriteLine(counter);
                        break;
                }

                counter++;

            }
                        
            Console.ReadKey();

        }

        public static int ModuleBy15 (int needsToBeDivided)
        {
            int moduleBy15 = Convert.ToInt32(needsToBeDivided % 15);

            return moduleBy15;
        }

        public static void WriteFizz()
        {
            Console.WriteLine("Fizz");
        }

        public static void WriteBuzz()
        {
            Console.WriteLine("Buzz");
        }

        public static void WriteFizzBuzz()
        {
            Console.WriteLine("FizzBuzz");
        }
               

    }
}
