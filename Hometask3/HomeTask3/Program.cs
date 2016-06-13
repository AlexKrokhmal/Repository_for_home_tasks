using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    class Program
    {

        static void Main(string[] args)
        {            
                                                                            //The purpose of the programm
            Console.WriteLine("The program allows you to enter a range of integer values and find min and max values \nPlease, specify the amount of values you would like to enter");

            bool checkIfArraySizeIsInteger;                                                     //Variable to check that user entered valid size for future array (only positive integer is supported)
            int parsedArraySize;                                                                //Variable for recognized size of future array
            String enteredArraySize;                                                            //Value that user entered for array size
            
                                                                            //Read the entered value for future array and verify it is valid (only positive integer is supported)
            do
            {
                enteredArraySize = Console.ReadLine();
                checkIfArraySizeIsInteger = int.TryParse(enteredArraySize, out parsedArraySize);

                                                                            //If array size is valid, allow user to enter the array elements
                if (checkIfArraySizeIsInteger & (parsedArraySize > 0))
                    
                {
                    Console.WriteLine("Please, enter {0} integer number(s) you want to check for min and max values", parsedArraySize);

                                                                            //Declare the int arrey of user's size, and variables for array min and max values
                    int[] parsedConsoleArray = new int[parsedArraySize];
                    int minArrayValue, maxArrayValue;
                    
                                                                            //Read the array from console
                    for (int i = 0; i < parsedArraySize; i++)
                    {
                        bool checkIfEnteredElementIsInteger;                                    //Variable to check that userentered valid (integer) elemnt
                        String enteredArrayElement;                                             //Value user entered for element

                                                                            //Check if entered value is valid
                        do
                        {
                            enteredArrayElement = Console.ReadLine();
                            checkIfEnteredElementIsInteger = int.TryParse(enteredArrayElement, out parsedConsoleArray[i]);

                                                                            //is entered value is not valid, ask to try again
                            if (!checkIfEnteredElementIsInteger)
                            {
                                Console.WriteLine("The {0} is not an integer value. Try again.", enteredArrayElement);
                            }
                        }
                        while (!checkIfEnteredElementIsInteger);                         
                    }
                    
                                                                            //Set the first array value as a max and min
                    minArrayValue = maxArrayValue = parsedConsoleArray[0];                                     
                    
                                                                            //Go over the array (starting from 2nd element) and check if each next value is smaller than current min or greather than current max
                    for (int i = 1; i < parsedArraySize; i++)
                    {

                                                                            //If current value is smaller than min, use it as a new min
                        if (minArrayValue > parsedConsoleArray[i])
                        {
                            minArrayValue = parsedConsoleArray[i];                            
                        }

                                                                            //otherwise check check if current value is bigger than max. If true, use current value as a new max
                        else if (maxArrayValue < parsedConsoleArray[i])
                        {
                            maxArrayValue = parsedConsoleArray[i];                            
                        }                        
                    }                      

                                                                            //print min and max values
                    Console.WriteLine("min is {0}\nmax is {1}", minArrayValue, maxArrayValue);



                    //An alternative solution to find and show min and max
                    /*************************************************                                     

                    Array.Sort(parsedConsoleArray);
                    Console.WriteLine("min is {0}\nmax is {1}", parsedConsoleArray[0], parsedConsoleArray[parsedArraySize-1]);
                    
                    *************************************************/



                }
                else
                                                                            //If array size is NOT valid, ask user to try again
                {
                    Console.WriteLine("The {0} is not a positive integer value in range. Try Again.", enteredArraySize);
                }                
            }
            while (!checkIfArraySizeIsInteger | !(parsedArraySize > 0));
            //while (!(checkIfInteger & (parsedArraySize > 0))) ;
            

            Console.ReadKey();
        }             

    }
}
