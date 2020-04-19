using System;


namespace Csharpbeginner
{
   
    class Program
    {
        /* section <6> Arrays and Lists*/

        static void Main(string[] args)
        {
            
            int[] numbrss = new int[6] { 5, 8, 1, 4, 3, 1 };

            Console.WriteLine("Length of the array is " + numbrss.Length);
            foreach (int a in numbrss)
                Console.WriteLine(a);
            Console.WriteLine("Sorted arrey is here :");
            Array.Sort(numbrss);
            foreach (int a in numbrss)
                Console.WriteLine(a);
            int indx = Array.IndexOf(numbrss,3);
            Console.WriteLine("Length of the array is " + numbrss.Length);
            Console.WriteLine("Index of 3 is: " + indx);

            Array.Clear(numbrss, 0, 2);
            Console.WriteLine("Length of the array is " + numbrss.Length);
            foreach (int a in numbrss)
                Console.WriteLine(a);

            int[] another_arrey = new int[5];
            Array.Copy(numbrss, another_arrey, 4);
            foreach (int a in another_arrey)
                Console.WriteLine(a);


            

            /* */


            /* section <6> Jagged Array*/

        }


    }


}
