namespace DSAndAlgo.Sorting_Algorithm
{
    public static class BubbleSort
    {
        public static int[] BubbleSortAlgorithmBruteForceApproach(int[] array1, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {

                        int temp = array1[j + 1];
                        array1[j + 1] = array1[j];

                        array1[j] = temp;

                    }

                }

            }
            return array1;
        }

        public static int[] BubbleSortAlgorithmOptimalApproach(int[] array1, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int flag = 0;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {

                        int temp = array1[j + 1];
                        array1[j + 1] = array1[j];

                        array1[j] = temp;
                        flag = 1;

                    }

                }
                if (flag == 0) break;

            }
            return array1;
        }
    }
}
