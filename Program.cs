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
           Section 2 Classes

            Constructor 
            Constructor OverLoading

            Objects Initialization
             */

            //two ways to create objects

            //Constructor Overloading with three different kind of constructors
            Person person2 = new Person();
            Person person = new Person("ULLU");
            var person1 = new Person("ULLU ka patha" , 12345);
           
            //Calling introduce method for three different types of objects
            person.Introduce();

            Console.WriteLine("I am object 2 i.e. person 1");
            person1.Introduce();
            Console.WriteLine("I am object 3 i.e. person 2");
            person2.Introduce();


            /*Completed Lesson 9  Objects Initialization */
        }
        public class Person
        {
            public string Name;
            public int Id;

            public Person()
            { }

            public Person(string name)
            {
                this.Name = name;
            }


            public Person(string name, int id)
            {
                this.Name = name;
                this.Id = id;
            }
            public void Introduce()
            {
                Console.WriteLine("Hi Your Name is : " + Name);
                Console.WriteLine("Hi Your ID Is  : " + Id);

            }
        }
    }
}
