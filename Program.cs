using System;
using System.Collections.Generic;

namespace Csharpbeginner
{

    class Program
    {
        /* */

        static void Main(string[] args)
        {
            /*CSharp Intermediate Course*/

            /*
           Started Section 2 Classes
             */

            //two ways to create objects
            Person person = new Person();
            var person1 = new Person();
            person.Name = "ULLU";
            person.Introduce();


            /*Completed Lesson 7 Introduction to Classes */
        }
        public class Person
        {
            public string Name;
            public void Introduce()
            {
                Console.WriteLine("Hi Your Name is : " + Name);
            }
        }
    }
}
