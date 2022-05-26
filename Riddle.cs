using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Разбери_паролата
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial Numbers For Combination

            List<int> lockNumbers = new List<int>();

            // Invalid Numbers For Combination

            List<int> invalidSet = new List<int>();

            // Numbers To Solve Riddle

            int firstNumber = 0;

            int secondNumber = 0;

            int thirdNumber = 0;

            // The Valid Combination

            List<int> trueCombination = new List<int>();

            Console.WriteLine("Hello To Find The Password Challenge");
            
            Console.WriteLine("There are 3 correct numbers based on the input you put in the combination will appear on the screen");

            Console.WriteLine("Please input  all the numbers one by one");
            while(lockNumbers.Count <= 14)
            {
                int numbers = int.Parse(Console.ReadLine());
                lockNumbers.Add(numbers);

                // Invalid Numbers Added For Riddle

                if (lockNumbers.Count >= 10 && lockNumbers.Count < 13)
                {
                    invalidSet.Add(numbers);
                }
            }

            // Remove And Store Remaining Numbers Using LINQ Hack

            List<int> invalidNumbersRemoved = lockNumbers.Except(invalidSet).ToList();

            // Based On The Riddle We Find Out In The Last Snippet There Is Only One Number Left

            firstNumber = invalidNumbersRemoved.Last();

            // Based On The Riddle We Find Out That In The First Snippet The Third Number Is Corect

            thirdNumber = invalidNumbersRemoved.IndexOf(1);

        
            // We Clear All Occurences Since We Know The First Number

            invalidNumbersRemoved.RemoveAll(item => item == firstNumber);

            // We Clear All Occurences Since We Know The Third Number

            invalidNumbersRemoved.RemoveAll(item => item == thirdNumber);

            // Based On The Fact We Have The Two First Numbers We Find Out The Last Number

            secondNumber = invalidNumbersRemoved.Last();

            trueCombination.Add(firstNumber);

            trueCombination.Add(secondNumber);

            trueCombination.Add(thirdNumber);

            Console.WriteLine("The Numbers Are:");

            foreach (var numbers in trueCombination)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
