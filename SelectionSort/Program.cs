using System;
namespace SelectionSort
{
   class SelectionSort
    {
        public static bool binarySearch(int[] list, int item)
        {
            int low = 0;
            int high = list.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];
                if (guess == item)
                {
                    return true;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return false;
        }
        public static int findSmallest(int[] arr, int startIndex)
        {
            int smallestIndex = startIndex;
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[smallestIndex])
                {
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
        public static int findLargeest(int[] arr, int startIndex)
        {
            int smallestIndex = startIndex;
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[smallestIndex])
                {
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
        public static void selectionSortForSmall(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallestIndex = findSmallest(arr, i);
                int temp = arr[i];
                arr[i] = arr[smallestIndex];
                arr[smallestIndex] = temp;
            }
        }
        public static void selectionSortForMax(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallestIndex = findLargeest(arr, i);
                int temp = arr[i];
                arr[i] = arr[smallestIndex];
                arr[smallestIndex] = temp;
            }
        }
        public static void Main(string[] args)
        {
            int[] myArr = { 1, 3, 5, 7, 9 };
            Console.WriteLine("------------------------------------Find----------------------------------------------");
            bool result1 = binarySearch(myArr, 3);
            Console.WriteLine(result1);
            Console.WriteLine("------------------------------------Small----------------------------------------------");
            selectionSortForSmall(myArr);
            Console.WriteLine(string.Join(", ", myArr));
            Console.WriteLine("------------------------------------Large----------------------------------------------");
            selectionSortForMax(myArr);
            Console.WriteLine(string.Join(", ", myArr));

        }
    }
}

