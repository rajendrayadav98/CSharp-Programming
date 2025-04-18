// Create a class Student (Business Logic Class)
// Instance Variables:
// private int Rollno 
// private string Sname 
// private int Marks
// genereate properties for the above variables.
// Create string ToString() to Print the Person details 
// Create a class Main (Executable Logic Class) which contains main method to print Student
// class details and pass the values through properties.

using System;

namespace RajendraConsoleApp.Day_24_Properties_
{
    internal class Student
    {
        private int Rollno;
        private string Sname;
        private int Marks;
        public int _Rollno
        {
            get
            {
                return _Rollno;
            }
            set
            {
                Rollno = value;
            }
        }
        public string _Sname
        {
            get
            {
             return Sname;
            }
            set
            {
                Sname = value;
            }
        }
        public int _Marks
        {
            get
            {

                return Marks;
            }
            set
            {
                Marks = value;
            }
        }
        public override string ToString()
        {
            return $" Roll Number: {Rollno}\n SName: {Sname}\n Smarks: {Marks}";
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student._Rollno = 101;
            student.Sname = "Rajendra Yadav";
            student.Marks = 50;
            Console.WriteLine(student);
            Console.ReadLine();
        }
    }
}