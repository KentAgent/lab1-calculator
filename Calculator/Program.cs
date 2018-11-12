using System;

namespace Calculator
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            CalculatorObject calculator = new CalculatorObject();
            Console.WriteLine("Welcome to your brand new calculator");

            while(true) 
            {
                int option = startMenu();
                options(calculator, option);
            }
        }

        private static void options(CalculatorObject calculator, int option)
        {
            switch (option)
            {
                case 1:
                    inputTwoNumbers(calculator);
                    Console.WriteLine("The sum is: " + calculator.sum());
                    break;
                case 2:
                    inputTwoNumbers(calculator);
                    Console.WriteLine("The product is: " + calculator.multiply());
                    break;
                case 3:
                    inputTwoNumbers(calculator);
                    Console.WriteLine("The sum is : " + calculator.sumInBetweenNumbers());
                    break;
                case 4:
                    string s = Console.ReadLine();
                    calculator.storeNumber(Convert.ToInt32(s));
                    Console.WriteLine("Successfully added number to memory");
                    break;
                case 5:
                    calculator.removeFromMemory();
                    Console.WriteLine("Successfully removed number from memory");
                    break;
                case 6:
                    Console.WriteLine(calculator.printToString());
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        private static void inputTwoNumbers(CalculatorObject calculator)
        {
            string firstInput = null;
            string secondInput = null;

            do
            {
                Console.WriteLine("Give me two numbers");

                firstInput = Console.ReadLine();
                secondInput = Console.ReadLine();
            } while (firstInput == "" || secondInput == "");

            calculator.setNumbers(Convert.ToInt32(firstInput), Convert.ToInt32(secondInput));
        }

        private static int startMenu() 
        {
            string menuOptions = @"
            ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                1. Sum two numbers together
                2. Multiply two numbers together
                3. Sum the numbers between two numbers
                4. Save number to calculator memory
                5. Clear calculator memory
                6. Print calculator content
                7. Exit
            ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                ";
            Console.WriteLine(menuOptions);
            var userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
    }
}
