// See https://aka.ms/new-console-template for more information
// Prints out whatever is inside of ()
// ---------------------------------------------
// Foundations Practice - Lab C#
// Date: 11-08-2025
// ---------------------------------------------
// Notes:
// - This file consolidates all lessons so far.
// - Each section is clearly labeled (Variables, Input, Data Types, Calculator, etc.)
// - Older experiments are commented and kept for reference.
// ---------------------------------------------

// Entry message
Console.WriteLine("Hello! Welcome to your C# practice file.");

// =============================================
// SECTION 1: Variables and Strings
// =============================================

string myFriendsName = "Jannick";
// Console.WriteLine(myFriendsName);

// Reassign variable
myFriendsName = "Frank";
// Console.WriteLine(myFriendsName);

// Example: Taking user input
// Console.WriteLine("Enter your name: ");
// string userInput = Console.ReadLine();
// Console.WriteLine("You entered " + userInput);

// Console.ReadKey(); // Waits for user to press a key

// =============================================
// SECTION 2: Data Types Overview
// =============================================

// Reference Types: objects, strings, dynamic
// string myName = "Denis";

// Value Types
// int myAge = -35;    // integers can go negative
// uint myAge2 = 35;   // unsigned integers (only positive)

// Floating point examples
// double pi = 3.14;
// float pi2 = 3.14f;

// Byte types
// byte age = 15;      // 0–255
// sbyte age2 = -15;   // -128–127

// short myNum = 3200; // -32,768 to 32,767

// Example initialized doubles (currently unused)
double myNumber1 = 0.0;
double myNumber2 = 0.0;

// =============================================
// SECTION 3: Calculator Example
// =============================================

Console.WriteLine("\n--- Simple Addition Calculator ---");

Console.Write("Enter a number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter another number: ");
int num2 = int.Parse(Console.ReadLine());

int result = num1 + num2;

// Output using string interpolation
Console.WriteLine($"Your total is: {result}");

// =============================================
// SECTION 4: Notes & Future Practice Ideas
// =============================================
// - Try changing `int` to `double` to handle decimals
// - Add subtraction, multiplication, division options
// - Wrap calculator logic inside a method later (e.g. Add(), Subtract())
// - Practice with TryParse() for safer user input
// =============================================

Console.ReadKey();