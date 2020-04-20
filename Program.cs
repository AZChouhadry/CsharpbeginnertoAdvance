using System;


namespace Csharpbeginner
{
   
    class Program
    {
        /* section <8> Strings*/

        static void Main(string[] args)
        {
            var my_name = " Punjab Polce";
            Console.WriteLine("Trim: '{0}'", my_name.Trim());
            Console.WriteLine("Trim: '{0}'", my_name.Trim().ToUpper());

            var index = my_name.IndexOf(' ');
            var firstName = my_name.Substring(0, index);
            var lastName = my_name.Substring(index + 1);

            Console.WriteLine("First Name:{0}, Last Name:{1}", firstName, lastName);

            var names = my_name .Split(' ');
            Console.WriteLine("First:" + names[0]);
            Console.WriteLine("Second:" + names[1]);

            Console.WriteLine(my_name.Replace("Punjab", "Ullu"));


            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");

            }
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToSByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            Console.ReadLine();

            /*Completed Lesson 64 Strings */


        }


    }


}
