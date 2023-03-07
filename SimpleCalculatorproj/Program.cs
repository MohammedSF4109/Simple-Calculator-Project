using System;
namespace SimpleCalculator
{
    public static class Calculator 
    {
        static double number1;
        static double number2;
        public static void Main(string[] args)
        {
            //prompting user to select a operation
            System.Console.WriteLine("Select a operation to perform(1/2/3/4):\n 1. Addition\n 2. Subtraction\n 3. Multiplication\n 4. Division\n");
            int userChoice = int.Parse(Console.ReadLine());


            switch (userChoice)
            {
                case 1:
                    {
                        //prompting user to enter inputs 
                        System.Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Addition: {Addition(number1, number2)}");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                         //prompting user to enter inputs 
                        System.Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Subtraction: {Subtraction(number1, number2)}");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                         //prompting user to enter inputs 
                        System.Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Multiplication: {Multiplication(number1, number2)}");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                         //prompting user to enter inputs 
                        System.Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Division: {Division(number1, number2)}");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid input, please entet a valid input");
                        Console.ReadLine();
                        break;
                    }
            }
        }
        //method for addition
        public static double Addition(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        //method for subtraction 
        public static double Subtraction(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }

        //method for multiplicaiton 
        public static double Multiplication(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }

        //method for division
        public static double Division(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }
    }
}