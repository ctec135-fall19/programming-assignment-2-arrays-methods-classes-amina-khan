/*

Author: Amina Khan
Date: 10/11/2019
CTEC 135: Microsoft Software Development with C#
Module 3, Programming Assignment 2, Prob 1
  Arrays
Working with int and string arrays.
Creating a multiplication table.

*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Array of strings

            //Initializing array
            string[] strArray = { "one", "two", "three", "four", "five", 
                "six", "seven", "eight", "nine", "ten"};
            
            Console.WriteLine("\nArray of Stings");
            
            //printing the array using foreach loop
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }
            #endregion

            #region 2 array of ints

            //creating an array
            int[] intArray = new int[10];

            Console.WriteLine("\nArray of Ints");
            //initializing and printing array using for loop
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 10;
                Console.WriteLine(intArray[i]);
            }
            #endregion

            #region 3: 2-D array

            //initializing array
            int[,] myTable = new int[12, 12];

            Console.WriteLine("\n 12 Times Table \n");

            //populating and printing the array
            for (int i = 0; i < 12; i++)
            {
                printHorizontal(100);
                
                Console.Write("|{0}", i+1);
                printVertical(i + 1);
                
                for (int j = 0; j < 12; j++)
                {
                    myTable[i, j] = (i + 1) * (j + 1);
                    Console.Write("\t{0}", myTable[i, j]);
                    printVertical(myTable[i, j]);

                }
                Console.WriteLine();
            }

            printHorizontal(100);
            Console.WriteLine();

            #endregion
        }
        // smiple method for printing a horizontal line
        private static void printHorizontal(int num)
        {
            Console.Write(" ");
            for (int i = 0; i < num; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        //method for printing a vertical bar/pipe after each number
        private static void printVertical(int val)
        {
            // val is any number being printed
            // length stores the length of digits of val
            
            int length = val.ToString().Length;
            string vline = ""; 
            
            // determining how many spaces to add after number
            if (length < 2)
            {
                vline = "   |";
            }
            else if(length < 3)
            {
                vline = "  |";
            }
            else
            {
                vline = " |";
            }
            
            Console.Write(vline);
        }
    }
}
