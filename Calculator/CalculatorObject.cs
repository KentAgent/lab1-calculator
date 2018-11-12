using System;

namespace Calculator
{
    internal class CalculatorObject
    {

        public int firstNumber{ get; set; }
        public int secondNumber{ get; set; }
        float numberInMemory;

        public CalculatorObject()
        {
            clean();
        }

        private void clean()
        {
            firstNumber = 0;
            secondNumber = 0;
            numberInMemory = 0;
        }

        internal int sum()
        {
            return firstNumber + secondNumber;
        }

        internal float multiply()
        {
            return firstNumber * secondNumber;
        }

        internal float sumInBetweenNumbers()
        {
            int n1 = firstNumber;
            int n2 = secondNumber;

            if (firstNumber > secondNumber) 
            {
                n1 = secondNumber;
                n2 = firstNumber;
            }

            int total = 0;

            for (int i = n1; i < n2 + 1; i++)
            {
                total += i;
            }

            return total;
        }

        internal void storeNumber(int number)
        {
            numberInMemory = number;
        }

        internal void removeFromMemory()
        {
            firstNumber = 0;
            secondNumber = 0;
            numberInMemory = 0;
        }

        internal string printToString()
        {
            string message = @"
                First number: {0}
                Second number: {1}
                Number in memory: {2}";
            return string.Format(message, firstNumber, secondNumber, numberInMemory);
        }

        internal void setNumbers(int n1, int n2)
        {
            firstNumber = n1;
            secondNumber = n2;
        }
    }
}