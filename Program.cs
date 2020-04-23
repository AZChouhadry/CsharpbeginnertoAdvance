using System;
using System.Collections.Generic;

namespace Csharpbeginner
{

    class Program
    {
        /* section <8> Strings*/

        static void Main(string[] args)
        {
            /*Started Section 10 Debugging Applications*/

            /*
             F10: Step Over
             F11: Step Into
             */

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallest = GetSmallests(numbers, 3);
            foreach (var number in smallest)
            {
                Console.WriteLine(number);
            }

        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();
            while (smallests.Count < count)
            {

                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }


            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;

        }

        /*Completed Lesson 80  Removing Side Effects */
    }
}
