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
        /// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
        /// Print the decimal value of each fraction on a new line with  places after the decimal.
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
        /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
        /// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
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

        /// <summary>
        /// Given a time in -hour AM/PM format, convert it to military(24-hour) time.
        /// Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        /// - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        /// </summary>
        #region timeConversion
        public static string timeConversion(string s)
        {
            var hourType = s.Substring(8);
            var time = s.Substring(0, 8);
            var hour = s.Substring(0, 2);
            DateTime date;
            string result, temp;
            if (hourType == "AM")
            {
                if (hour == "12")
                {
                    temp = "00";
                    result = time.Remove(0, 2);
                    result = temp + result;
                }
                else
                {
                    result = time;
                }

            }
            else
            {
                if (hour == "12")
                {
                    result = time;
                }
                else
                {
                    temp = Convert.ToString(Convert.ToInt32(hour) + 12);
                    result = time.Remove(0, 2);
                    result = temp + result;
                }

            }

            return result;
        }
        #endregion

    }
    class Solution
    {
        public static void Main(string[] args)
        {

            //List<int> arr = new List<int> { 942381765, 627450398 ,954173620 ,583762094, 236817490 };
            //Program.plusMinus(arr);
            //Program.miniMaxSum(arr);

            string s = "12:05:45PM";
            string result = Program.timeConversion(s);

           
        }
    }

}



