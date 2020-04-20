using System;


namespace Csharpbeginner
{
   
    class Program
    {
        /* section <7> Working with Dates*/

        static void Main(string[] args)
        {


            /*Lesson 58 Date Time*/



            /*Date*/
            var dateTime = new DateTime(2016, 5, 3);
            var now = DateTime.Now;

            /*Time*/
            Console.WriteLine("Hour:" + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);


        }


    }


}
