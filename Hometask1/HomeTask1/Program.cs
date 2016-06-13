11:50 20.05.2016using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
                                

            Console.WriteLine("The program allows you to enter 2 numbers and check if the second value is divider of the first one.");
            
            int parsedNember1 = 0, parsedNumber2 = 0, sum = 0;

            bool checkFirstNumber = int.TryParse(Console.ReadLine(), out parsedNember1);

            if (checkFirstNumber)
            {

                bool checkSecondNumber = int.TryParse(Console.ReadLine(), out parsedNumber2);

                if (checkSecondNumber)
                {

                    if (parsedNumber2 != 0)
                    {

                        float isTheModuleEdualZero = parsedNember1 % parsedNumber2;

                        if (isTheModuleEdualZero == 0)
                        {
                            Console.WriteLine("{0} is divider of {1}!", parsedNumber2, parsedNember1);
                            Console.WriteLine("Press any key to quit.");
                        }

                        else
                        {
                            Console.WriteLine("{0} is NOT a divider of {1}", parsedNumber2, parsedNember1);
                            Console.WriteLine("Press any key to quit.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You cannot divide by {0}. Restart the program and try again.", parsedNumber2);
                        Console.WriteLine("Press any key to quit.");
                    }                                       
                }
                else
                {
                    Console.WriteLine("It was not a number. Restart the program and try again.");
                    Console.WriteLine("Press any key to quit.");
                }                               
            }
            else
            {
                Console.WriteLine("It was not a number. Restart the program and try again.");
                Console.WriteLine("Press any key to quit.");
            }
                        
            Console.ReadKey();

        }
    }
}
