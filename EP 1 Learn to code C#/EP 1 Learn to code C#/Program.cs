using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 50;
            Console.WindowWidth = 50;
             
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

           
            Console.Write("Like the video"); // 

            Console.WriteLine("Subscribe to Code-By-Script");
            Console.ReadKey();
            Console.ReadLine();



            // task for you

            // try to write something to the console 
            // change the title of the console
            // on the next line clear the console terminal

            
            Console.WriteLine("Code-By-Script");
            Console.Title = "Code-By-Script-channel";
            Console.ReadKey();
            Console.Clear();


        }
    }
}
