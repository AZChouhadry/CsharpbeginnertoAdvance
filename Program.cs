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
            Demo Directory Directoryinfo
             */

            Directory.CreateDirectory(@"e:\my_folder");
            Directory.GetFiles(@"e:\AZ\my_files", "." ,SearchOption.AllDirectories);

            var files= Directory.GetFiles(@"e:\AZ\my_files", ".txt", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine("Files with .txt Extension are :" + file);

            var directories = Directory.GetDirectories(@"e:\AZ\my_files", ".", SearchOption.AllDirectories);
            foreach (var diretory in directories)
                Console.WriteLine("Directories are :" + diretory);


            /*Completed Lesson 74  Demo Directory Directoryinfo*/


            
        }


    }


}
