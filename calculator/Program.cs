using System;

namespace Calculator
{
    class program
    {
        static void Main(string[] args)
        {

           // string operation;
            Console.WriteLine("Welcome to our calculator");

            Console.WriteLine("enter you 1st number");
            int num1;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number you entered is " + num1);

            Console.WriteLine("enter you 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number you entered is " + num2);

            Console.WriteLine("enter you operator");
            char operation = Convert.ToChar(Console.ReadLine());

            if (operation == '/' || operation == '-')
            {
                if (num2 > num1) 
                {
                    Console.WriteLine("For doing the operation number 1 must be greater than number 2");
                    
                 }
              
            } 
            else
            {
                switch (operation)
                {
                    case '+':
                        Console.WriteLine("the sum of the entered number is  " + Convert.ToDecimal(num1 + num2));
                        break;
                    case '-':
                        Console.WriteLine("the difference of the number is " + Convert.ToDecimal(num1 - num2));
                        break;
                    case '*':
                        Console.WriteLine("the product of the numbers is " + Convert.ToDecimal(num1 * num2));
                        break;
                    case '/':
                        Console.WriteLine("the difference of the number is " + Convert.ToDecimal(num1 / num2));
                        break;
                }
            }

            
        }
    }
}