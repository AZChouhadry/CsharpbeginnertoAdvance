using System;


namespace Csharpbeginner
{
   
    class Program
    {
        /* section <8> Strings*/

        static void Main(string[] args)
        {



            /*Procedural Programming*/
            Console.WriteLine("Kindly Enter My name");
            var my_name = Console.ReadLine();

            Console.WriteLine("Your Name is: " + my_name);
            var arrey = new char[my_name.Length];
            foreach (var a in arrey)
                Console.WriteLine(a);
            for (var i = my_name.Length; i > 0; i--)

            {
                Console.WriteLine(" I has value" + i);
                arrey[my_name.Length - i] = my_name[i - 1]; }
            
        


        }


    }


}
