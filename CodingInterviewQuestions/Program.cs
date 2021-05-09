using System;
using System.Linq;

namespace CodingInterviewQuestions
{
    class Program : Questions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" +
                "Coding interview Questions:\n " +
                "1. How do you reverse a given string in place without using a loop only?\n " +
                "2. How do you check if a given string is a palindrome?  (e.g. “Taco cat”)\n " +
                "3. Write a program to display the multiplication table of a given integer.\n " +
                "4. Write a program  to find the maximum and minimum element in an array.\n " +
                "5. Write a program to find the largest of three given (input) numbers. (e.g. 8, 6, 10 → 10)\n " +
                "6. Write a program to calculate the sum of elements in an array. (e.g. 1234 → 1 + 2 + 3 + 4 → 10)\n " +
                "7. Write a program to output a pyramid-like pattern  with an asterisk.\n " +
                "8. Write a program to check if a given number is odd or even. Return “odd” if the number is odd, or “even” if the number is even.\n ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    FirstQuestion();
                    break;
                case "2":
                    SecondQuestion();
                    break;
                case "3":
                    ThirdQuestion();
                    break;
                case "4":
                    FourthQuestion();
                    break;
                case "5":
                    FifthQuestion();
                    break;
                case "6":
                    SixthQuestion();
                    break;
                case "7":
                    SeventhQuestion();
                    break;
                case "8":
                    EighthQuestion();
                    break;
                default:
                    break;
            }
        }
    }
}
