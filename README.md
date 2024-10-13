# 🌟 Welcome to the CSharp Console Methods Repository! 🌟

## 📚 Overview
This repository contains a simple C# console application demonstrating basic console methods. You'll learn how to change console properties, handle user input, and display messages. Let's dive in! 🏊‍♂️

## 💻 Code Explanation 

 This section provides a detailed breakdown of the code. You can explore the material to understand the concepts before attempting the task at the end. The solution is hidden below, so you can try it without worrying about seeing the answer first.

## 🚀 Step 1: Main Method - Entry Point
  - 🚀 Purpose: The Main method is the entry point of the program where execution starts. The static modifier allows this method to be called without creating an instance of the class.
```csharp
static void Main(string[] args) // Step 4: Main Method - Entry Point
 ```
## 🎨 Step 2: Set Console Properties
  - 🎨 Purpose: This block of code customizes the appearance of the console
   - Empty Line: Provides a clean starting point.
   - Background Color: Sets a visually appealing dark blue background.
   - Foreground Color: Sets the text color to black for contrast.
   - Window Height & Width: Adjusts the console window size for better visibility
```csharp
 Console.WriteLine(""); // 📝 Write an empty line to start clean.
Console.BackgroundColor = ConsoleColor.DarkBlue; // 🎨 Set background color to Dark Blue.
Console.ForegroundColor = ConsoleColor.Black; // 🎨 Set text color to Black.
Console.WindowHeight = 50; // 📏 Set the console window height to 50.
Console.WindowWidth = 50; // 📏 Set the console window width to 50.
 ```
## 🎨 Step 3: Reset Console Colors
  - 🎨 Purpose: After setting initial colors, this resets the console to default colors for better readability during output
```csharp
Console.BackgroundColor = ConsoleColor.Black; // 🎨 Reset background color to Black.
Console.ForegroundColor = ConsoleColor.White; // 🎨 Reset text color to White.
 ```
## 💬 Step 4: Output Messages
  - 💬 Purpose: This outputs messages to the console, prompting user interaction and encouraging engagement with the content.
```csharp
Console.Write("Like the video"); // 💬 Prompt user engagement without a newline.
Console.WriteLine(" Subscribe to Code-By-Script"); // 💬 Continue with a new message on the next line.
 ```
## ⏳ Step 5: Wait for User Input
  - ⏳ Purpose: These commands pause program execution until the user provides input, allowing them to read the messages displayed.
```csharp
Console.ReadKey(); // ⏳ Wait for a key press from the user.
Console.ReadLine(); // ⏳ Wait for a line of text input from the user.
 ```
## Step 9: Task - Change Console Title and Clear Console 🔧

**Task Description**:  
Your task is to change the console title to "Code-By-Script-channel" and clear the console after displaying a message. This helps in branding and provides a fresh view for further outputs.

<details>
<summary>Click to see the solution! 👀</summary>

### Solution:
- **Output Message**: Displays "Code-By-Script" to indicate branding.
- **Change Title**: Sets the console window title to the channel's name for identification.
- **Wait for Input**: Pauses execution, allowing the user to read the message.
- **Clear Console**: Removes all previous text to give a fresh view for future operations.
```csharp
Console.WriteLine("Code-By-Script"); // 💬 Output a message to the console.
Console.Title = "Code-By-Script-channel"; // 🔖 Change the console title to Code-By-Script-channel.
Console.ReadKey(); // ⏳ Wait for a key press before clearing.
Console.Clear(); // 🧹 Clear the console of all previous outputs.
 ```
</details> </details> 

## Complete Code (Contains the Solution to the Task):
<details>
<summary>Show Complete Code 👀 </summary>

```csharp
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(""); // 💬 Print an empty line for spacing.

            Console.BackgroundColor = ConsoleColor.DarkBlue; // 🎨 Set background color to DarkBlue.
            Console.ForegroundColor = ConsoleColor.Black; // 🎨 Set text color to Black.
            Console.WindowHeight = 50; // 📏 Set console window height.
            Console.WindowWidth = 50; // 📏 Set console window width.

            Console.BackgroundColor = ConsoleColor.Black; // 🎨 Reset background color to Black.
            Console.ForegroundColor = ConsoleColor.White; // 🎨 Reset text color to White.

            Console.Write("Like the video"); // 💬 Prompt user to like the video.
            Console.WriteLine("Subscribe to Code-By-Script"); // 💬 Encourage users to subscribe.
            Console.ReadKey(); // ⏳ Wait for user to press a key.
            Console.ReadLine(); // ⏳ Wait for user to press Enter.

            // Task for you
            // Try to write something to the console 
            // Change the title of the console
            // On the next line, clear the console terminal

            Console.WriteLine("Code-By-Script"); // 💬 Output a message to the console.
            Console.Title = "Code-By-Script-channel"; // 🔖 Change the console title to Code-By-Script-channel.
            Console.ReadKey(); // ⏳ Wait for a key press before clearing.
            Console.Clear(); // 🧹 Clear the console of all previous outputs.
        }
    }

