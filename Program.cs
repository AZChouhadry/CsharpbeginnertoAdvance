using System;


namespace Csharpbeginner
{
   
    class Program
    {
        /* section <8> Strings*/

        static void Main(string[] args)
        {



            /*String Builder*/
            var builder = new StringBuilder();
            builder.Append('a', 1);
            builder.Append('z', 1);
            builder.AppendLine();
            builder.Append('Y', 5);
            builder.Append("ULLU");
            builder.AppendLine();
            builder.Append('h', 10);
            Console.WriteLine(builder);

            builder.Replace('z', 'a');

            Console.WriteLine(builder);

        }


    }


}
