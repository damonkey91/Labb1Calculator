using System;
using System.Collections.Generic;

namespace Labb1Calculator
{
    public class Calculator
    {
        int FirstNumber { get; set; }
        int SecondNumber { get; set; }
        List<int> NumberInMemory { get; set; }

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

        public int SumInbetween()
        {
            int First = 0;
            int Last = 0;
            int Sum = 0;

            if (FirstNumber > SecondNumber)
            {
                First = FirstNumber;
                Last = SecondNumber;
            } else 
            {
                First = SecondNumber;
                Last = FirstNumber;
            }

            for (int i = First ; i == Last; i++)
            {
                Sum = Sum + i;
            }

            return Sum;
        }
    }
}
