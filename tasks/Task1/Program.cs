using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Factorial f = new Factorial();
        Console.WriteLine("=== Factorial Calculator ===");

            int number;
            
            // 1. Input Validation Loop
            while (true)
            {
                Console.Write("Please enter a positive integer: ");
                string input = Console.ReadLine();

                // Check if it's a valid number AND if it's non-negative
                if (int.TryParse(input, out number) && number >= 0)
                {
                    break; // Exit the loop if input is valid
                }

                Console.WriteLine("Invalid input. Please enter a whole number 0 or greater.");
            }


            long result = f.calcFactorial(number);
            Console.WriteLine($"\nThe factorial of {number} ({number}!) is: {result}");
           
    }
}
class Factorial
{
    public long calcFactorial(int num)
    {
        if(num==0) return 1;
        return num*calcFactorial(num-1);
    }
}