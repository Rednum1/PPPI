﻿class Program
{
    // Field to store the initial text from the file
    private static string text;
    // Method to display the number of words specified by the user in the "Lorem ipsum" text
    private static void LoremSplit()
    {
        
        Console.WriteLine("Enter the number of words you want to display:");
        int numberOfWords = int.Parse(Console.ReadLine());

        string path = @"D:\text.txt";
        text = File.ReadAllText(path);

        string[] words = text.Split(' ');
        for (int i = 0; i < numberOfWords; i++)
        {
            Console.Write(words[i] + " ");
        }
        Console.WriteLine('\n');
    }
    // Method to display Mathematic Operations

    private static void MathOperation()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            int operation = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    result = a / b;
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
            Console.WriteLine("Result: " + result);
        }
    }

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            // Display the selection menu
            Console.WriteLine("1) Display number of words from text");
            Console.WriteLine("2) Perform mathematical operation");
            Console.WriteLine("3) Exit");

            // Handle user input
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    LoremSplit();
                    break;
                case 2:
                    MathOperation();
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}
