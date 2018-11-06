using System;

namespace Labb1Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Add two numbers \n2.Multiply two numbers \n3.Sum the numbers between two numbers. \n4.Add number to memory \n5.Clear memory \n6.Print calculator contents. \n7.Quit");
            Console.WriteLine("Välj ett alternativ: ");
            Calculator calc = new Calculator();
            String answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.WriteLine("Skriv första numret: ");
                    calc.FirstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv andra numret: ");
                    calc.SecondNumber = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                default:
                    break;
            }
        }
    }
}
