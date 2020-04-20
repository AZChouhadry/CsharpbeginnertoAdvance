using System;


namespace Csharpbeginner
{
   
    class Program
    {
        /* section <7> Working with Dates*/

        static void Main(string[] args)
        {


            /*Lesson 58 Date Time*/


            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var timeSpan1 = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(4);
            Console.WriteLine("Value of Timespan 1 is: " + timeSpan1);
            Console.WriteLine("Value of Timespan 2 is: " + timeSpan2);
            Console.WriteLine("Value of Timespan 3 is: " + timeSpan3);

            Console.WriteLine("Minutes of Timespan 1: " + timeSpan1.Minutes);
            Console.WriteLine("Total Minutes of Timespan 1: " + timeSpan1.TotalMinutes);
        }


    }


}
