/*Author: Amina Khan
Date: 10/11/2019
CTEC 135: Microsoft Software Development with C#
Module 3, Programming Assignment 2
Prob 3 : Class
-Create student class
-Demo construct, state
-use of acccessor and mutator
-use of properties
-try/catch/exception block

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1: Constructors

            Console.WriteLine("\n\nStudent 1 - Default constructor");
            // default constructor
            Student student1 = new Student();
            // using PrintState method to display values
            student1.PrintState();

            Console.WriteLine("\n\nStudent 2 - Master constructor - " +
                "\nspecifying values for name, id, and GPA\n");
            // master constructor
            Student student2 = new Student("amy", 900000, 3.0);
            student2.PrintState();

            Console.WriteLine("\n\nStudent 3 - Custom constructor - " +
                "\nspecifying values for name and id only\n");
            // custom constructor
            Student student3 = new Student("sam", 999900);
            student3.PrintState();

            #endregion

            #region 2: Accessor and mutators of Name field

            // Setting new name for student1

            student1.SetName("tim");
            // getting / displaying new name for student1
            Console.WriteLine("\n\nStudent1 new name: {0}", student1.GetName());
            student1.PrintState();

            #endregion

            #region 3: Using properties


            //the use of the both properties
            Console.WriteLine("\n\nUse of Student2 ID property");
            
            Console.WriteLine("Student2 ID: {0}", student2.studentIDproperty);

            // setting new value using studentIDproperty
            student2.studentIDproperty = 989898;

            Console.WriteLine("Student2 ID after : {0}", student2.studentIDproperty);

            #endregion

            #region 4: try/catch block to demo ID property exception
            Console.WriteLine("\n\nTry/catch/exeption, student3 id is set out of range\n");
            
            try
            {
                student3.studentIDproperty = 989888989;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error ***");
                Console.WriteLine("Method:\t\t{0}", e.TargetSite);
                Console.WriteLine("Message:\t\"{0}\"", e.Message);
                Console.WriteLine("Source:\t\t{0}", e.Source);
                Console.WriteLine("Trace:\t\t{0}", e.StackTrace);
            }

            Console.WriteLine("\nStudent 3 PrintState:");
            student3.PrintState();
            Console.WriteLine();

            #endregion
        }
    }
}
