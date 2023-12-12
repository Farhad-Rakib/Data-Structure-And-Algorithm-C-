using DSAndAlgo.Sorting_Algorithm;
using System;

namespace DSAndAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.Write("Enter The Number Of Elements in the Array : ");

            n = Convert.ToInt32(Console.ReadLine());
            int[] unsortedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsortedArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Unsorted Array is : ");
            PrintArray(unsortedArray);
            BubbleSortAlgorithm((int[])unsortedArray.Clone(), n);
            InsertionSortAlgorithm((int[])unsortedArray.Clone(), n);
            Console.WriteLine();
        }

        private static void BubbleSortAlgorithm(int[] unsortedArray, int n)
        {
            Console.Write("\nSorted Array Using Bubble Sort Algorithm [Brute Froce Approach] : ");
            PrintArray(BubbleSort.BubbleSortAlgorithmBruteForceApproach(unsortedArray, n));
            Console.Write("\nSorted Array Using Bubble Sort Algorithm [Optimal Approach] : ");
            PrintArray(BubbleSort.BubbleSortAlgorithmOptimalApproach(unsortedArray, n));
        }

        private static void InsertionSortAlgorithm(int[] unsortedArray, int n) 
        {
            Console.Write("\nSorted Array Using Insertion Sort Algorithm : ");
            PrintArray(InsertionSort.InsertionSortAlgorithm(unsortedArray,n));

        }

        private static void PrintArray(int[] array1) 
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
        }
    }


}
