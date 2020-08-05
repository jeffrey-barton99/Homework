using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Apply
//
//Classes and Objects
// 1-6 on bottom of code.
//
//7. Define a class with :
// One public field

// One private field

// A default constructor

// A 2-argument constructor which sets your fields

//A deconstructor

//8. Instantiate an instance of your class using the 2-argument constructor.Deconstruct the instantiated object into a tuple.
namespace HW6DReviewEnumsClassStructs
{
    public class Point
    {
        private int x, y;

        public void Deconstruct(out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }
        public Point()
        {
            this.x = 1;
            this.y = 1;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        // was trying to do the above with a made up student id info, I made up but ran out of time.
        // public string fName;
        // public string lName;
        //
        // public Student()
        //     : this("DefaultFullName", "DefaultStudentIDN")
        //
        // { 
        //
        // }
        //
        // public Student(string fName, lName)
        // {
        //     this.fName = fName;
        //     this.lName = lName;
        // }
        //
        // private string StudentIDN
        // private string v1;
        // private string v2;
    }
}

//Assignment
//Many of the following questions are answered by your textbook.Some questions are introduced as topics in the book but require additional
//research to answer.This is a great opportunity to improve your google-fu!
//Understand
//Provide short answers to the following questions:
//
//Enumerations and Structures
//
//1. What is the advantage of an enum over (for example) an int?
// Establishing a named constant with an enum makes readability easier in a self documenting kind of way, it is easier in this way to add
// additional values if/when necessary.

//2. When might you prefer a struct over a class?
// In the instance where you have a value that does not need to be changed, but referenced to then used to create a new different value w/o modding the original
// like with distance, weigh or time.

//3. What happens if you create a struct without using the new keyword?
// It will always create a default if you do not, where as a class will allow for null values.

//4. What is the purpose of CIL?
// To act as the inermediate language between source code, and machine code at the time of compilation.

//5. What does the CLR do?
// The Common Language Runtime converts the Common intermediate Language instructions into real machine instructions that the procesor understands
// and executes.

//6. What alternative to native code does the Universal Windows Platform provide for unmanaged applications?
// Windows Runtime (WinRT).  WinRT introduces a layer on top of the Win32 API and other select native Wnidows APIs that provides consistent
//functinality across different types of hardware.
