using System;
using System.Collections.Generic;

namespace hackerrankDay2
{
    class Program
    {
        /// <summary>
        /// Given an array of integers, where all elements but one occur twice, find the unique element.
        /// </summary>
        #region lonelyinteger
        /*
        public static int lonelyinteger(List<int> a)
        {
            int itemCount = 0;
            int result = 0;
            foreach (var item in a)
            {
                itemCount = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (item == a[i])
                    {
                        itemCount++;
                    }
                }
                if (itemCount <= 1)
                {
                    result = item;
                    return result;
                }
            }
            return result;
        }
         */
        #endregion
        ///<summary >
        /// Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        /// </summary>
        #region diagonalDifference
        /*
        public static int diagonalDifference(List<List<int>> arr)
        {
            int rowCount = arr.Count;
            int temp = rowCount;
            int diagonal1 = 0, diagonal2 = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int k = 0; k < rowCount; k++)
                {
                    if (i == k)
                    {
                        diagonal1 += arr[i][k];
                        diagonal2 += arr[i][temp - 1];
                        temp--;
                    }
                }
            }

            return Math.Abs(diagonal1 - diagonal2);
        }
         */
        #endregion

        ///<summary >
        /// Another sorting method, the counting sort, does not require comparison. Instead, you create an integer array whose
        /// index range covers the entire range of values in your array to sort. Each time a value occurs in the original array,
        /// you increment the counter at that index. At the end, run through your counting array, printing the value of each non-zero valued index that number of times.
        /// </summary>
        #region countingSort
        public static List<int> countingSort(List<int> arr)
        {
            int biggestNumber = int.MinValue, smallestNumber = int.MaxValue;
            List<int> myArray = new List<int>();
            List<int> result = new List<int>();
            foreach (var item in arr)
            {
                if (item > biggestNumber)
                {
                    biggestNumber = item;
                }
                if (item < smallestNumber)
                {
                    smallestNumber = item;
                }
            }
            for (int i = 0; i <= biggestNumber; i++)
            {
                myArray.Add(0);
            }

            for (int i = 0; i < arr.Count; i++)
            {
                myArray[arr[i]]++;
            }

            for (int i = 0; i < myArray.Count; i++)
            {
                for (int k = 0; k < myArray[i]; k++)
                {
                    result.Add(i);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            return result;

        }
        #endregion




    }
    class Solution
    {
        static void Main(string[] args)
        {
            //List<int> arr = new List<int> { 1, 4, 2, 3, 1, 2, 4 };
            //int result = Program.lonelyinteger(arr);

            //List<List<int>> arr = new List<List<int>>();
            //int result = Program.diagonalDifference(arr);


            List<int> arr = new List<int> { 1, 4, 3, 1, 2 };
            List<int> result = Program.countingSort(arr);

        }
    }
}
