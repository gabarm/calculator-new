using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calculator_new
{
    public class Calculator
    {


        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Addition(double[] numbers)
        {
            numbers = new double[] { 1, -2, 3, 4, 5 };
            double sum = numbers.Sum();

            return sum;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Subtraction(double[] numbers)
        {
            numbers = new double[] { 15, 2, -1, -4, 5 };
            double sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum -= numbers[i];
            }
            return sum;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("You cant divide by 0");
            }
        }

        static void Main(string[] args)
        {
            int userInput;
            double num1 = 0.0;
            double num2 =0.0;    
            do
            {
                double result = 0;

                Console.WriteLine("-----Calculation Menu-----");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("0 - Exit the program!");
                userInput = MenuSelection(); 

                switch (userInput)
                {
                   
                    case 1:
                       Addition(num1 = numberInput("first"), num2 = numberInput("second"));
                        result = num1 + num2;
                        CalcAnswer(num1, num2, result,"+");
                        break;

                    case 2:
                        Subtraction(num1 = numberInput("first"), num2 = numberInput("second"));
                        result = num1 - num2;
                        CalcAnswer(num1, num2, result,"-");
                        break;

                    case 3:
                        Multiply(num1 = numberInput("first"), num2 = numberInput("second"));
                        result = num1 * num2;
                        CalcAnswer(num1, num2, result,"*");
                        break;

                    case 4:
                        try
                        {
                            Divide(num1 = numberInput("first"), num2 = numberInput("second")) ;
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e);
                        }
                        result = num1 / num2;
                        CalcAnswer(num1, num2, result, "/");
                        break;

                    case 0:
                        Console.WriteLine("Press any key to quit!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Not valid, Try again:");
                        break;


                }
            } while (userInput != 0);

        }
        static int MenuSelection()
        {

            int number;
            string inputFromUser = Console.ReadLine();


            while (!int.TryParse(inputFromUser, out number))
            {
                Console.WriteLine("Sorry, Wrong input! Try again.");
                inputFromUser = Console.ReadLine();
                int.TryParse(inputFromUser, out number);
            }
            return number;
        }
        static double numberInput(string firstSecond)
        {

            Console.WriteLine("Enter " + firstSecond + " number:");
            string userUserInputNum = Console.ReadLine();
            double num;
            double.TryParse(userUserInputNum, out num);

            while (!double.TryParse(userUserInputNum, out num))
            {
                Console.WriteLine("Wrong input; try again");
                userUserInputNum = Console.ReadLine();

                double.TryParse(userUserInputNum, out num);

            }

            return num;
        }
        static void CalcAnswer(double num1, double num2, double result, string mathEq)
        {
            Console.WriteLine("\n\n" + num1 + mathEq + num2 + " = " + result + "\n\n");
        }
    }
}
