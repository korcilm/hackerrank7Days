using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace hackerrankDay1
{
    class Program
    {
        /// <summary>
        /// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.
        /// </summary>
        #region plusMinus
        /*                 
        public static void plusMinus(List<int> arr)
        {
            double positive = 0, negative = 0, notr = 0;
            foreach (var item in arr)
            {
                if (item>0)
                {
                    positive++;
                }
                else if (item == 0)
                {
                    notr++;
                }
                else
                {
                    negative++;
                }
            }
            double positivePosibility = Convert.ToDouble(Math.Round(Convert.ToDouble(positive) / Convert.ToDouble(arr.Count), 6));
            double negativePosibility = Convert.ToDouble(Math.Round(Convert.ToDouble(negative) / Convert.ToDouble(arr.Count), 6));
            double notrPosibility = Convert.ToDouble(Math.Round(Convert.ToDouble(notr) / Convert.ToDouble(arr.Count), 6));
            Console.WriteLine(positivePosibility +" "+negativePosibility+" "+ notrPosibility);


        }
        */
        #endregion
        /// <summary>
        /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        /// </summary>
        #region miniMaxSum
        /*
        public static void miniMaxSum(List<int> arr)
        {
            long total = 0;
            foreach (var item in arr)
            {
                total += item;
            }
            long temp = 0;
            long smallestNumber =long.MaxValue, biggestNumber=long.MinValue;
            for (int i = 0; i < arr.Count; i++)
            {
                temp = total - arr[i];
                if (temp<smallestNumber)
                {
                    smallestNumber = temp;
                }
                if (temp>biggestNumber)
                {
                    biggestNumber = temp;
                }
                temp = 0;
            }
            Console.WriteLine($"{smallestNumber} {biggestNumber}" );
        }
         */
        #endregion

    }
    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = new List<int> { 942381765, 627450398 ,954173620 ,583762094, 236817490 };
            //Program.plusMinus(arr);
            //Program.miniMaxSum(arr);
        }
    }

}



