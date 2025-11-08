// See https://aka.ms/new-console-template for more information
// Prints out whatever is inside of ()
Console.WriteLine("Hello");



// declare a variable

string myFriendsName;
myFriendsName = "Jannick";

// int age = 23;
// Console.WriteLine(myFriendsName);
// Console.WriteLine(age);


// use/access the variable
myFriendsName = "Frank";
// Console.WriteLine(myFriendsName);


// takes the user input and stores it
// string userInput = Console.ReadLine();
// adding 2 strings together and writing them into the console
// Console.WriteLine("You entered " + userInput);
// Console.ReadKey();



// Data types  11-08-2025

// Reference Types are objects, strings, dynamic
// string myName = "Denis";

// setting up a variable
// string petsName;
// initialize variable
// petsName = "Daisy";
// Console.WriteLine($"my pet is {petsName}");
// can be reassigned
// petsName = "Barky";
// Console.WriteLine($"my pet is {petsName}");


// Value Types
// int myAge = -35;  // int can go into negatives
// uint myAge2 = 35;  // can't go into negatives
// double pi = 3.14; // double can also go into negatives
// float pi2 = 3.14f;
// Bytes
// byte age = 15;  // can go up to 255;
// signed bytes -128 to 127
// sbyte age2 = -15;

// 2short myNum = 3200; // can store -32k - 32k



// Lets create a calculator
// Console.WriteLine("Enter something! ");

// int myNumber = 0;

// Parasing

// myNumber = int.Parse(Console.ReadLine());   int.Parse() <- changes string to an integer

// takes the user input and stores it
Console.WriteLine("Enter a number: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int result = num1 + num2;

Console.WriteLine($"Your total is: {result}");


// string userInput = Console.ReadLine();
// myNumber = int.Parse(userInput);

// Console.WriteLine("myNumber = " + userInput);
Console.ReadKey();