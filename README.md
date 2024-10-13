# 🌟 Welcome to the CSharp Console Methods Repository! 🌟

## 📚 Overview
This repository contains a simple C# console application demonstrating basic console methods. You'll learn how to change console properties, handle user input, and display messages. Let's dive in! 🏊‍♂️

## 💻 Code Explanation

### Code Snippet
```csharp
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Set console properties
            Console.WriteLine(""); // Write an empty line
            Console.BackgroundColor = ConsoleColor.DarkBlue; // Set background color
            Console.ForegroundColor = ConsoleColor.Black; // Set text color
            Console.WindowHeight = 50; // Set the console window height
            Console.WindowWidth = 50; // Set the console window width
             
            // 2. Reset console colors
            Console.BackgroundColor = ConsoleColor.Black; // Reset background color
            Console.ForegroundColor = ConsoleColor.White; // Reset text color

            // 3. Output messages to the console
            Console.Write("Like the video"); // Output message without a new line
            Console.WriteLine("Subscribe to Code-By-Script"); // Output message with a new line
            
            // 4. Wait for user input
            Console.ReadKey(); // Wait for a key press
            Console.ReadLine(); // Wait for a line of text input

            // Task for you
            // Try to write something to the console 
            // Change the title of the console
            // Clear the console terminal

            // 5. Change console title and clear the console
            Console.WriteLine("Code-By-Script"); // Output a message
            Console.Title = "Code-By-Script-channel"; // Change the console title
            Console.ReadKey(); // Wait for a key press
            Console.Clear(); // Clear the console
        }
    }
}
