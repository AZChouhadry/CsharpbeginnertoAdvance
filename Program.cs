using System;


namespace Csharpbeginner
{
   
    class Program
    {
        /* section <8> Strings*/

        static void Main(string[] args)
        {
            var my_sentence = " Punjab Polce is not professional to their duty";

            Console.WriteLine(my_sentence);

            var words = my_sentence.Split(' ');
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }

            const int maxLenght = 10;

            if(my_sentence.Length< maxLenght)
            { Console.WriteLine(my_sentence); }
            else
            {
                var totalCharacters = 0;
                var summaryWords = new List<string>();

            }

        

            /*Completed Lesson 65 Summarizing Text */


        }


    }


}
