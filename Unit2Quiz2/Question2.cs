using System;

namespace Unit2Quiz2
{
    public class Question2
    {
        // Main function
        public static void Run()
        {
            /* Write a function that takes in two numbers, and returns the sum of 
            all of the numbers between and including those two numbers. 
            Example: I enter 7 and 12 - the result should be 57 (7+8+9+10+11+12 = 57).
            */          
            
            // Prompt user for input of two numbers
            Console.WriteLine("Please enter a number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number: ");
            int endNum = int.Parse(Console.ReadLine());

            // Check if start number is grether than end number
            if (startNum > endNum) {
                Console.WriteLine("Invalid number. Please try again.");
                return;
            }
            // Print sum of all numbers 
            int sum = SumOfNumbers(startNum, endNum);
            Console.WriteLine("The sum is: " + sum);
                         
        }        
            
        // This function perform the sum of all numbers including start and end
        public static int SumOfNumbers(int start, int end) {
            int sum = 0;
            for (int i = start; i <= end; i++) {
                sum += i;
            }
            return sum;
       }
    }
}
