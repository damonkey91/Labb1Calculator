using System;
using System.Collections.Generic;

namespace Labb1Calculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public List<int> NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = new List<int>();
        }

        public override string ToString(){
            return "First number: " + FirstNumber + "\nSecond number: " + SecondNumber + "\nNumber in memory: " + NumberInMemory;
        }

        public int SumNumbers(){
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers(){
            return FirstNumber * SecondNumber;
        }
    }
}
