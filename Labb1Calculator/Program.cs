using System;

namespace Labb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool Mrbool = true;

            do
            {
                Console.WriteLine("Choose one: \n" +
                                  "1.Add two numbers \n" +
                                  "2.Multiply two numbers \n" +
                                  "3.Sum the numbers between two numbers. \n" +
                                  "4.Add number to memory \n" +
                                  "5.Clear memory \n" +
                                  "6.Print memory. \n" +
                                  "7.Quit");
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
                        calc.NumberInMemory.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Number successfully added to memory");
                        Console.WriteLine("\nWelcome again");
                        break;
                    case "5":
                        Console.WriteLine("You chose clear memory \nMemory cleared");
                        calc.NumberInMemory.Clear();
                        Console.WriteLine("\nWelcome again");
                        break;
                    case "6":
                        Console.WriteLine("You chose print memory");
                        Console.WriteLine("numbers in memory is/are");
                        calc.NumberInMemory.ForEach(Console.WriteLine);
                        Console.WriteLine("\nWelcome again");
                        break;
                    case "7":
                        Console.WriteLine("You chose to quit \nBye bye!");
                        Mrbool = false;
                        break;
                    default:
                        Console.WriteLine("You chose wrong, try again");
                        Console.WriteLine("\nWelcome again");
                        break;
                }
            } while (Mrbool);         
        }
    }
}
