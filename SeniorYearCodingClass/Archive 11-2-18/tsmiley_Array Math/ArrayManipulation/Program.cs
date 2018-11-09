using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }
          
            //The following can be used to test your implementations. Uncomment each line as you go to test.
            //NOTE: You don't have to do each line sequentially. For example, implementing the FindMin and FindMax methods
            //will be very useful for your FindRange method. Hint... Hint...

            Console.WriteLine("UNSORTED: ");
            PrintArray(array);
            Console.WriteLine("BUBBLE SORTED: ");
            PrintArray(BubbleSort(array));
            Console.WriteLine("SELECTION SORTED: ");
            PrintArray(SelectionSort(array));
            Console.WriteLine("MEAN: " + FindMean(array));
            Console.WriteLine("MEDIAN: " + FindMedian(SelectionSort(array)));
            Console.WriteLine("RANGE: " + FindRange(array));
            Console.WriteLine("MODE: " + FindMode(array));
            Console.WriteLine("MAX: " + FindMax(array));
            Console.WriteLine("MIN: " + FindMin(array));

            Console.ReadKey();
        }

        /// <summary>
        /// Prints the array in | x | y | z | a | b | c | format
        /// </summary>
        /// <param name="array">The array to be printed</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i] + " ");
            }
            Console.WriteLine("|");
        }

        /// <summary>
        /// Implements a bubble sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            bool swapped;
            do
            {
                swapped = false;
                for(int i = 1; i < mutatedArray.Length; i++)

                {
                    if(mutatedArray[i-1] > mutatedArray[i])
                    {
                        int temp = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[i - 1];
                        mutatedArray[i - 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);

            return mutatedArray;
        }

        /// <summary>
        /// Implements a selection sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            for (int i = 0; i < mutatedArray.Length; i++)
            {
                for (int j = 0; j < mutatedArray.Length; j++)
                {
                    if (mutatedArray[i] < mutatedArray[j])
                    {
                        int temp = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[j];
                        mutatedArray[j] = temp;
                    }
                }
            }
            return mutatedArray;
        } 

        /// <summary>
        /// Finds the mean (average) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mean</returns>
        public static float FindMean(int[] array)
        {
            float sum = 0;

            for(int i =0;i<array.Length; i++)
            {
                sum += array[i];
            }
            sum /= 10;
            return sum;
        }

        /// <summary>
        /// Finds the median (middle element of sorted array) of the array
        /// In the case that the array is an even length, average the two middle elements
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The median</returns>
        public static float FindMedian(int[] array)
        {
            float median = 0;
            array = BubbleSort(array);
            median = array[4] + array[5];
            median /= 2;

            return median;
        }

        /// <summary>
        /// Finds the range (highest value - lowest value) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The range</returns>
        public static int FindRange(int[] array)
        {
            int range;
            array = BubbleSort(array);
            range = array[9] - array[0];
            return range;
        }

        /// <summary>
        /// Finds the mode (most common occuring element) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mode</returns>
        public static int FindMode(int[] array)
        {
            int count1 = 0;
            int count2 = 0;
            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                num1 = array[i];
                count1 = 0;   

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (num1 == array[j])
                    {
                        count1++;
                    }
                }

                if (count1 > count2)
                {
                    num2 = num1;
                    count2 = count1;
                }

                else if (count1 == count2)
                {
                    num2 = Math.Min(num2, num1);
                }
            }

            return num2;
        }

        /// <summary>
        /// Finds the maximum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(int[] array)
        {
            int max = array.Max();
            return max;
        }

        /// <summary>
        /// Finds the minimum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The minimum value</returns>
        public static int FindMin(int[] array)
        {
            int min = array.Min();
            return min;
        }
    }
}
