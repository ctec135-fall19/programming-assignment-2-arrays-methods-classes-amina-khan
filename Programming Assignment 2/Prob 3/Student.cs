using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_3
{
    class Student
    {
        //fields
        private string studentName;

        //get and set methods for student name
        // (accessor)
        public void SetName(string name)
        {
            studentName = name;
        }
        // (mutator)
        public string GetName()
        {
            return studentName;
        }

        // ID property
        private int studentID;
        public int studentIDproperty
        {
            get { return studentID; }
            set
            {
                if (value > 100000 && value < 999999)
                {
                    studentID = value;
                }
                else
                {
                    throw new Exception("Error. Value out of range");
                }
            }
        }

        // GPA property (automatic)
        public double studentGPA { get; set; }

        // master constructor
        public Student(string name, int id, double gpa)
        {
            studentName = name;
            studentID = id;
            studentGPA = gpa;
        }
        // default constructor
        public Student() : this("", 0 , 0.0) { }

        //constructor with parameters for name and ID 
        //and using chaining
        public Student(string name, int id) : this(name, id, 0.0) { }

        
        //method to print the state of object
        public void PrintState()
        {
            Console.WriteLine("Student Name:\t{0}", studentName);
            Console.WriteLine("Student ID:\t{0}", studentID);
            Console.WriteLine("GPA:\t{0}", studentGPA);
        }
    }
}
