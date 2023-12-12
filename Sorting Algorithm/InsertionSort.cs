using System.Configuration;
using System.IO.Pipes;

namespace DSAndAlgo.Sorting_Algorithm
{
    public class InsertionSort
    {
        public static int [] InsertionSortAlgorithm(int[] array,int n)
        {
            int j;
            for (int i = 1; i < n; i++)
            {
                int temp = array[i];
                j = i - 1;
                while (j > -1 && array[j] > array[j + 1]) 
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j+1] = temp;
            }
            return array;
        }
    }
}
