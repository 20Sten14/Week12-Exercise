using System;
using System.IO;

namespace RandomQoute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("49 Wise Quotes That Will Inspire You to Success in Life");
        Console.WriteLine(GetRandomJoke());
        }
            

        public static string GetRandomJoke()
        {
            string fullfilepath = @"C:\Users\opilane\samples\quotes-file.txt

";
            string[] jokeAboutchuck = File.ReadAllLines(fullfilepath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokeAboutchuck.Length);

            return (jokeAboutchuck[randomIndex]);

        }


    }
}