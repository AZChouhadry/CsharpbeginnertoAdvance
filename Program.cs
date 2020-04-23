using System;
using System.IO;

namespace Csharpbeginner
{
   
    class Program
    {
        /* section <8> Strings*/

        static void Main(string[] args)
        {



            /*Section 9 Working with Files*/

            /*
             File, File Info
             */
            var path = @"e:\my_profile.jpg";
            File.Copy(@"e:\my_profile.jpg", @"d:\my_profile.jpg");
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("File was not deleted");
            }


            /*Completed Lesson 73 Demo File, File Info*/



        }


    }


}
