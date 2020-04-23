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
            Signature of Methods
            Method Overloading
            Params Modifier
            Ref Modifier
            Out Modifier
             */

            Person person2 = new Person();
            Person person = new Person("ULLU");
            var person1 = new Person("ULLU ka patha" , 12345);

           
            //Calling introduce method for three different types of objects
            person.Introduce();

            Console.WriteLine("I am object 2 i.e. person 1");
            person1.Introduce();
            Console.WriteLine("I am object 3 i.e. person 2");
            person2.Introduce();

            Console.WriteLine(" Calling Methods by different ways method overloading");
            person1.Introduce(57, "Pakpattan");

            /*Completed Lesson 10 Methods */
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

            public void Introduce(int weight)
            {
                Console.WriteLine("Hi Your Name is : " + Name);
                Console.WriteLine("Hi Your ID Is  : " + Id);
                Console.WriteLine("Hi Your Weight is  : " + weight);
            }

            public void Introduce(int weight, string location)
            {
                Console.WriteLine("Hi Your Name is : " + Name);
                Console.WriteLine("Hi Your ID Is  : " + Id);
                Console.WriteLine("Hi Your Weight is  : " + weight);
                Console.WriteLine("Hi Your Location is  : " + location);

            }
        }
    }
}
