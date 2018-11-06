using System;
using System.Collections.Generic;

namespace Labb1Calculator
{
    public class Calculator
    {
        int firstNumber { get; set; }
        int secondNumber { get; set; }
        List<int> NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = new List<int>();
        }

        public override string ToString(){
            Console.WriteLine("First number: {0} \nSecond number: {1} \nNumber in memory: {2} ", FirstNumber, SecondNumber, NumberInMemory);
        }
    }
}
