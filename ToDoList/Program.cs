using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {

            string directory = @"C:\Users\opilane\samples\titpe\ToDoList.txt";
            string filepath = directory + @"\ToDoList.txt";

            List<string> ToDo = new List<string>();
            bool fileExists = file.exists



            /*List<string> myWishes = new List<string>();
            string fullfilepath = @"C:\Users\opilane\samples\titpe\Chores";
            string[] dataFromFile = File.ReadAllLines(fullfilepath);
            Console.WriteLine("Enter your to do list!");
            string chore = Console.ReadLine();

            string filepath = fullfilepath + @"\MyFiles.txt";
            foreach (string line in dataFromFile)
            {
                File.Create($@"{fullfilepath}\{line}.txt");
            }*/



            /*myWishes.Add("fresh new cool mints");
            myWishes.Add("mercury");
            myWishes.Add("gaming chair");

            int listLenght = myWishes.Count;
            Console.WriteLine($"List lenght : {listLenght}");
            //Console.WriteLine(myWishes[0]);
            //Console.WriteLine(myWishes[1]);
            //Console.WriteLine(myWishes[2]);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"you wish for : {wish}");*/

        
        }
    }
}