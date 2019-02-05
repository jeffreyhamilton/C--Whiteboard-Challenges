using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallanges
{
    class Program
    {
        static void Main(string[] args)
        {
            //White Board Challanges

            //FIZZ BUZZ
            for(int i = 0; i <=  100; i++)
            {
                if(i%15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            // 2.Reverse a string

            String str = "Hello";
            Console.WriteLine("Original string is: " + str);

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            Console.Write("Reversed string is:");
            Console.WriteLine(charArray);

            // 3.Reverse a sentence

            Console.WriteLine("Reverse the sentence 'This is the interview question.'");
            String[] words = "This is the interview question".Split(' ');
            String rev = "";
            
            for (int i = words.Length - 1; i >= 0; i--)
            {
                rev = rev + words[i] + " ";
            }
            Console.WriteLine(rev);


           // 4.Find the minimum value in a list
            int[] theArray = { 3, 200, 300, 400, 1000, 600, 700, 800, 200, 5};
            int min = 10000;
            for (int i = theArray.Length - 1; i >= 0; i--)
            {
                if (min > theArray[i])
                {
                    min = theArray[i];
                }
            }
            Console.WriteLine(min);


            // 5.Find the maximum value in a list
            int[] maxArray = { 100, 200, 300, 400, 5000, 600, 700, 800, 900, 1000 };
            int max = -1;
            for (int i = maxArray.Length - 1; i >= 0; i--)
            {
                if (max < maxArray[i])
                {
                    max = maxArray[i];
                }
            }
            Console.WriteLine(max);
            

            // 6. Calculate a remainder (given a numerator and denominator)
            int numerator = 3;
            int denominator = 1;
            Console.WriteLine(numerator % denominator);


            /*
             * 7. Return distinct values from a list including duplicates (i.e.
             * "1 3 5 3 7 3 1 1 5" -> "1 3 5 7")
             * 
             */
            int[] someArray = { 1, 3, 5, 3, 7, 3, 1, 1, 5 };
            int numberToTest;

            for (int i = someArray.Length - 1; i >= 0; i--)
            {
                numberToTest = someArray[i];
                int trigger = 1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (numberToTest == someArray[j])
                    {
                        trigger = -1;
                    }
                }

                if(trigger == 1)
                {
                    Console.Write(numberToTest);
                }
            }


            Console.WriteLine("");


            /*
             * 8. Return distinct values and their counts (i.e. the list above becomes
             * "1(3) 3(3) 5(2) 7(1)")
             */

            int[] someArrayTwo = { 1, 3, 5, 3, 7, 3, 1, 1, 5 };
            int numberToTestTwo;
           

            for (int i = someArrayTwo.Length - 1; i >= 0; i--)
            {
                numberToTestTwo = someArrayTwo[i];
                int trigger = 1;
                int howManyTimes = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (numberToTestTwo == someArrayTwo[j])
                    {
                        trigger = -1;
                    }
                }

                if (trigger == 1)
                {

                    for(int k = someArrayTwo.Length - 1; k >= 0; k--)
                    {
                        if(numberToTestTwo == someArrayTwo[k])
                        {
                            howManyTimes += 1;
                        }
                        
                    }

                    Console.Write(numberToTestTwo + "(" + howManyTimes + ")");
                }
            }

            /*
             * 9. Given a string of expressions (only variables, +, and -) and a set of
             * variable/value pairs (i.e. a=1, b=7, c=3, d=14) return the result of the
             * expression ("a + b+c -d" would be -3).
             */
            Console.WriteLine("");

            // 10. Test if a string is an palindrome

            Console.WriteLine("Type a word to check if its a palindrome");
            String A = Console.ReadLine();
            int someNum = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] != A[someNum])
                {
                    Console.WriteLine("No it is not.");
                    break;
                }
                someNum++;
            }
            if (someNum == A.Length)
            {
                Console.WriteLine("Yes it is.");
            }

            

        }
    }
}
