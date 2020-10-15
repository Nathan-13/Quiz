using System;

namespace Unit2Quiz2
{
    public class Question3
    {
        public static void Run()
        {
            /* Write a function that takes in a string as input, removes the vowels from the string (aeiou), 
            and then returns that new string as the output. 
            Example: I input "Hello World" - the result should be "Hll wrld".
            */
            
            // Prompt user for a string
            Console.WriteLine("Please enter a string!");
            string myString = Console.ReadLine();
            string newString = RemoveVowels(myString);
            Console.WriteLine("The result is: " + newString);
           
        }
        // Loop that
        public static string RemoveVowels(string text) {
            string vowelsRemoved = "";
           
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == 'a' || text[i] == 'e'|| text[i] == 'i' || text[i] == 'o' || text[i] == 'u' ||
                   text[i] == 'A' || text[i] == 'E'|| text[i] == 'I' || text[i] == 'O' || text[i] == 'U') {
                    vowelsRemoved += ""; 
                } else {
                    vowelsRemoved += text[i];
                } 
            }
            return vowelsRemoved;
        }
    }
}