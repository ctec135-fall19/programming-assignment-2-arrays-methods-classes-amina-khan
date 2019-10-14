/*
Author: Amina Khan
Date: 10/11/2019
CTEC 135: Microsoft Software Development with C#
Module 3, Programming Assignment 2
Prob 2: Methods
-Create methods
-Demo call by reference
-Demo overloading
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1 : demo of call by value
            // initializing variables
            int myInt = 55;

            // printing value befor method call
            Console.WriteLine("\nThe value of my number is: {0}", myInt);

            // method call
            callVal(myInt);
                                          
            #endregion



            #region 2: demo call by reference
            // initializing array
            string[] myArray = new string[] {"one", "two", "three"};

            //printing values of array
            Console.WriteLine("\nValues of string Array before method call");
            foreach (string str in myArray)
            {
                Console.WriteLine(str);
            }

            //method call by reference
            CallRef(myArray);

            //printing values of array
            Console.WriteLine("\nValues of string Array after method call");
            foreach (string str in myArray)
            {
                Console.WriteLine(str);
            }

            #endregion

            #region 3: demo of overloading
            // initializing variable
            string myString = "Hello";

            // printing value befor method call
            Console.WriteLine("\nThe value of my string is: {0}", myString);

            // method call
            callVal(myString);
            Console.WriteLine();

            #endregion
        }
        // method demonstrating call by value
        public static void callVal(int val)
        {
            Console.WriteLine("\nValue in \"callVal\" method call: {0}", val);
        }

        // method demonstrating call by reference
        static void CallRef(string[] someArray)
        {
            someArray[0] = "tacos";
        }

        // method demonstrating overloading
        static void callVal(string val)
        {
            Console.WriteLine("\nValue in \"callVal\" method call: {0}", val);
        }
    }
}
