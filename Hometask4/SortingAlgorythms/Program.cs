using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "The programm uses Bubble and Insertion sorting methods to sort the int arrays";

            //Array for sorting
            //int[] arrayForSorting = new int[11] { 3, 2, 5, 6, 7, 1, 4, 0, 8, 1, 9 }; //{ 1, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 } //{ 2, 3, 4, 5, 6, 1, 4, 3, 2, 1, 1 } // { 3, 2, 5, 6, 7, 1, 4, 0, 8, 1, 9 }
            
            int[] arrayForSorting = new int[10];
            Random random = new Random();
            for (int i = 0; i < arrayForSorting.Length; i++)
            {
                arrayForSorting[i] = random.Next(100);
            }            

            //Run bubble sorting
            BubbleArraySorting(arrayForSorting);

            //Run insertion sorting
            InsertionArraySorting(arrayForSorting);
                        
            Console.ReadKey();
        }

        
        /// <summary>
        /// Insertion sorting method for int arrays (finds correct place for each element and do swap(s))
        /// </summary>
        /// <param name="incomingArray"></param>
        static void InsertionArraySorting(int[] incomingArray)
        {            
            Console.WriteLine("Insertion sorting. \nIncoming array is:");
            PrintArrayToConsole(incomingArray);
            Console.WriteLine();

            for (int i = 1; i < incomingArray.Length; i++)
            {
                Console.WriteLine("Iteration #{0}", i);

                int j = i;

                while ((j > 0) && (incomingArray[j] < incomingArray[j - 1]))
                {
                    SwapArrayElements(incomingArray, j, j - 1);
                    j--;
                }

                PrintArrayToConsole(incomingArray);
            }

            Console.WriteLine("\nThe result of Bubble sorting is:");
            PrintArrayToConsole(incomingArray);
            Console.WriteLine();

        }


        /// <summary>
        /// Bubble sorting method for int arrays (Repeats iteration while you had some swap(s) during last iteration (swapCount > 0) that means sorting is not completed yet)
        /// </summary>
        /// <param name="incomingArray"></param>
        /// <returns></returns>
        static void BubbleArraySorting(int[] incomingArray)
        {
            Console.WriteLine("Bubble sorting. \nIncoming array is:");
            PrintArrayToConsole(incomingArray);
            Console.WriteLine();

            int swapCount;
            int iterationCounter = 1;

            do
            {
                swapCount = 0;

                Console.WriteLine("Iteration #{0}", iterationCounter);

                for (int i = 0; i < incomingArray.Length - 1; i++)
                {
                    if (incomingArray[i] > incomingArray[i + 1])
                    {
                        SwapArrayElements(incomingArray, i, i + 1);

                        swapCount++;
                    }
                }

                iterationCounter++;

                PrintArrayToConsole(incomingArray);

            } while (swapCount > 0);

            Console.WriteLine("\nThe result of Bubble sorting is:");
            PrintArrayToConsole(incomingArray);
            Console.WriteLine();            
        }


        //Method to do the swap of 2 numbers - not used
        static void SwapTwoElementsOfArray(int firstElement, int secondElement, out int firstElementAfterSwap, out int secondElementAfterSwap)
        {
            firstElement = firstElement + secondElement;
            secondElement = firstElement - secondElement;
            firstElement = firstElement - secondElement;

            firstElementAfterSwap = firstElement;
            secondElementAfterSwap = secondElement;            
        }


        //Method to do the swap of two array elements
        static int[] SwapArrayElements(int[] arrayToSwap, int firstElementIndex, int secondElementIndex)
        {
            arrayToSwap[firstElementIndex] = arrayToSwap[firstElementIndex] + arrayToSwap[secondElementIndex];
            arrayToSwap[secondElementIndex] = arrayToSwap[firstElementIndex] - arrayToSwap[secondElementIndex];
            arrayToSwap[firstElementIndex] = arrayToSwap[firstElementIndex] - arrayToSwap[secondElementIndex];
            
            return arrayToSwap;
        }        


        //Method to do the shift to right and swap - not used
        static int[] ShiftAndSwapArrayElements(int[] arrayToSwap, int firstElementIndex, int secondElementIndex)
        {            
            int valueToBeMovedLeft = arrayToSwap[secondElementIndex];                     

            for (int i = secondElementIndex; i > firstElementIndex; i--)
            {
                arrayToSwap[i] = arrayToSwap[i - 1];                
            }

            arrayToSwap[firstElementIndex] = valueToBeMovedLeft;            

            return arrayToSwap;
        }


        //Method to print an int array
        static void PrintArrayToConsole(int[] arrayForPrinting)
        {
            foreach (int arrayElement in arrayForPrinting)
            {
                Console.Write("{0} ", arrayElement);
            }
            Console.WriteLine();
        }

    }
}
