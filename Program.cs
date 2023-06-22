using System;
namespace Sum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Two Numbers");

            //get inputs from user

            Console.WriteLine("First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //add numbers
            int sum = num1 + num2;

            //print the sum
            Console.WriteLine("\nSum is: " + sum);
        }
    }
}