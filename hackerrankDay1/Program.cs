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
        /*
         *Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.
         
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
    }
    class Solution
    {
        public static void Main(string[] args)
        {
           
            List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };           

            //Program.plusMinus(arr);
        }
    }

}



