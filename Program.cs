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
          Demo Path
             */
            var path = @"e:\AZ\my_files\az.txt";
            var dotindex = path.IndexOf(".");
            var extesion = path.Substring(dotindex);
            Console.WriteLine("Extension: " + path.GetExtension(path));
            Console.WriteLine("File Name is : " + path.GetFileName(path));
            Console.WriteLine("File Name is : " + path.GetFileNameWithoutExtension(path));

            

            /*Completed Lesson 75  Demo Path*/


            
        }


    }


}
