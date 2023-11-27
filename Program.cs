using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1ArithmeticOperation
{
    
    delegate int ArithmeticOperation(int a, int b);
    internal class Program
    {
      
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }

        static void Main(string[] args)
        {
           
            ArithmeticOperation addDelegate = new ArithmeticOperation(Add);
            ArithmeticOperation subtractDelegate = new ArithmeticOperation(Subtract);
            ArithmeticOperation multiplyDelegate = new ArithmeticOperation(Multiply);
            ArithmeticOperation divideDelegate = new ArithmeticOperation(Divide);

           
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

          
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

          
            //Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    break;
                case 4:
                    result = divideDelegate(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
       
    }

}


     
