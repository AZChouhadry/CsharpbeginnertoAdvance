using System;
using System.Collections.Generic;
namespace CsharpBeginner
{

    class Program
    {
        static void Main(string[] args)
        {   
            /*Section 6 Arrays and Lists */

            var num = new [] {2,3,7,4,5 };
            var num = new List<int>() { 1,2,3,4};
            num.Add(1);
            num.AddRange(new int[4] {1, 5,6,7});

            Console.WriteLine("Length:" + num.Length);
            var index=Array.IndexOf(num, 9);
            Console.WriteLine(index);

            Array.Clear(num, 0, 2);
            Console.WriteLine("arr[0]:{0},arr[2]:{1}", num[0], num[1]);
            int [] num2 = new int [3];
            Array.Copy(num,num2,3);
            foreach(var a in  num2)
            {
                Console.WriteLine(a);
            }
            Array.Sort(num);
            foreach (var a in num)
            {
            foreach(var a in num)
                Console.WriteLine(a);
            }
          }
          }  
}