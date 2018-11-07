﻿using System;

namespace Labb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool Mrbool = true;

            do
            {
                Console.WriteLine("Choose one: \n1. Add two numbers \n2.Multiply two numbers \n3.Sum the numbers between two numbers. \n4.Add number to memory \n5.Clear memory \n6.Print memory. \n7.Quit");
                Calculator calc = new Calculator();
                String answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("You chose add two numbers");
                        Console.WriteLine("Write first number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Write second number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("The sum of your numbers were " + calc.SumNumbers());
                        Console.WriteLine("\nWelcome again");
                        break;
                    case "2":
                        Console.WriteLine("You chose multiply two numbers");
                        Console.WriteLine("Write first number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Write second number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("The sum of your numbers were " + calc.MultiplyNumbers());
                        Console.WriteLine("\nWelcome again");
                        break;
                    case "3":
                        Console.WriteLine("You chose sum all numbers between");
                        Console.WriteLine("Write first number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Write second number: ");
                        calc.SecondNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("The sum of your numbers were " + calc.SumInbetween());
                        Console.WriteLine("\nWelcome again");
                        break;
                    case "4":
                        Console.WriteLine("You chose add to memory");
                        Console.WriteLine("Write a number: ");
                        calc.FirstNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Number successfully added to memory");
                        break;
                    case "5":
                        Console.WriteLine("You chose clear memory \nMemory cleared");
                        break;
                    case "6":
                        Console.WriteLine("You chose print memory");
                        break;
                    case "7":
                        Console.WriteLine("You chose to quit \nBye bye!");
                        Mrbool = false;
                        break;
                    default:
                        Console.WriteLine("You chose wrong, try again");
                        break;
                }
            } while (Mrbool);
           
        }
    }
}
