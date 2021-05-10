using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewQuestions
{
    class Questions
    {
        static public void FirstQuestion()
        {
            Console.WriteLine("Please enter the string you want to reverse: ");
            char[] text = Console.ReadLine().ToCharArray();
            Array.Reverse(text);
            Console.WriteLine(text);
        }
        static public void SecondQuestion()
        {
            bool abort = true;
            Console.WriteLine("Please enter a string that you want to check: ");
            string text = Console.ReadLine();
            text = String.Concat(text.Where(c => !Char.IsWhiteSpace(c))).ToLower();
            char[] textAr = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                textAr[i] = text[i];
            }
            char[] chkArray = (char[])textAr.Clone();
            Array.Reverse(textAr);
            for (int i = 0; i < textAr.Length; i++)
            {
                if (textAr[i] != chkArray[i])
                {
                    Console.WriteLine($"{text} isn't a palindrome.");
                    abort = false;
                    break;
                }
            }
            if (abort) { Console.WriteLine($"{text} is a palindrome."); }
        }
        static public void ThirdQuestion()
        {
            Console.WriteLine("The multiplication table of what number do you need?: ");
            string number = Console.ReadLine();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{number} * {i} = {Convert.ToInt32(number) * i}");
            }
        }
        static public void FourthQuestion()
        {
            Console.WriteLine("Please enter 3 numbers: ");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            int[] numbers = { first, second, third };
            Array.Sort(numbers);
            Console.WriteLine($"Maximum element is: {numbers[2]} and the minimum is: {numbers[0]}");
        }
        static public void FifthQuestion()
        {
            Console.WriteLine("Please enter 3 numbers: ");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            int[] numbers = { first, second, third };
            Array.Sort(numbers);
            Console.WriteLine($"The largest number of these three is: {numbers[2]}");
        }
        static public void SixthQuestion()
        {
            Console.WriteLine("Please enter 3 numbers: ");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"All three added numbers together total to: {first+second+third}");
        }
        static public void SeventhQuestion()
        {
            string[,] pyramid = new string[3, 5];
            pyramid[0, 2] = "*";
            pyramid[1, 1] = "*";
            pyramid[1, 2] = "*";
            pyramid[1, 3] = "*";
            pyramid[2, 0] = "*";
            pyramid[2, 1] = "*";
            pyramid[2, 2] = "*";
            pyramid[2, 3] = "*";
            pyramid[2, 4] = "*";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (pyramid[i,j] != "*") { pyramid[i, j] = " "; }
                    Console.Write(pyramid[i, j]);
                }
                Console.WriteLine();
            }
        }
        static public void EighthQuestion()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0) { Console.WriteLine("The number is even."); }
            else { Console.WriteLine("The number is odd."); }
        }
    }
}
