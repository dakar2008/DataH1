using System;
using System.Collections.Generic;
using System.Linq;

namespace GPOpgaver
{
    public static class Opgaver
    {
        /*
        * Introduktion til Algoritmer
        * Exercise 1. 
        * Make an algorithm that interchanges the values of the variables x and y, using only assignment statements.
        * What is the minimum number of assignment statements needed to do so?
        */
        public static void Interchange(ref int x, ref int y)
        {
            int tempx = x;
            x = y;
            y = tempx;
        }
        /*
        * Introduktion til Algoritmer
        * Exercise 2. 
        * Make an algorithm that uses only assignment statements to replace thevalues of the triple(x, y, z) with (z, x, y).
        * What is the minimum number of assignment statements needed?
        */
        public static void InterchangeTriple(ref int x, ref int y, ref int z)
        {
            int tempz = z;
            z = y;
            y = x;
            x = tempz;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 3.
         * A palindrome is a string that reads the same forward and backward.
         * Make an algorithm for determining whether a string of n characters is a palindrome and output true or false.
         */
        public static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.a.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4A
         * The solution should return the number of steps that it goes through to complete the unit test
         */
        public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
        {
            int steps = 0;
            for (int i = 0; i < intergerArray.Length; i++)
            {
                steps++;
                if (intergerArray[i] == searchFor)
                {
                    return steps;
                }
            }
            return steps;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.b.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4B
         * The solution should return the number of steps that it goes through complete the unit test
         */
        public static int StepsInBinarySearch(int[] integerArray, int arrayStart, int arrayEnd, int searchFor)
        {
            int steps = 0;
            while (arrayStart <= arrayEnd)
            {
                steps++;
                int mid = (arrayStart + arrayEnd) / 2;
                if (integerArray[mid] == searchFor)
                {
                    return steps;
                }
                else if (integerArray[mid] > searchFor)
                {
                    arrayEnd = mid - 1;
                }
                else
                {
                    arrayStart = mid + 1;
                }
            }
            return steps;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 5.
         * Describe an algorithm based on the linear search for de-termining the correct position in which to insert a new element in an already sorted list.
         */
        public static int InsertSortedList(List<int> sortedList, int insert)
        {
            int steps = 0;
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (sortedList[i] > insert)
                {
                    sortedList.Insert(i, insert);
                    return steps;
                }
                steps++;
            }
            return steps;
        }
        /*
         * Exercise 6.
         * Arrays
         * Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
         * Notice that num is also included in the returned array.
         */
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = num * (i + 1);
            }
            return array;
        }
        /*
         * Exercise 7.
         * Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
         * Remember that the range is inclusive. a < b will always be true.
         */
        public static int PowerRanger(int power, int min, int max)
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (Math.Pow(i, power) >= min && Math.Pow(i, power) <= max)
                {
                    count++;
                }
            }
            return count;
        }
        /*
         * Exercise 8.
         * Create a Fact method that receives a non-negative integer and returns the factorial of that number.
         * Consider that 0! = 1.
         * You should return a long data type number.
         * https://www.mathsisfun.com/numbers/factorial.html
         */
        public static long Factorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        /*
         * Exercise 9.
         * Write a function which increments a string to create a new string.
         * If the string ends with a number, the number should be incremented by 1.
         * If the string doesn't end with a number, 1 should be added to the new string.
         * If the number has leading zeros, the amount of digits should be considered.
         * exampel: 
         * wow0849 -> wow0850
         * test99 -> test100
         */
        public static string IncrementString(string txt)
        {
            if (txt.Any(x => char.IsDigit(x)))
            {
                string textPart = "";
                string numberPart = "";
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!char.IsLetter(txt[i]))
                    {
                        textPart = txt.Substring(0, i);
                        numberPart = txt.Substring(i, txt.Length - i);

                        if (numberPart.StartsWith("0"))
                        {
                            int numberPartLength = numberPart.Length;
                            int numberPartInt = int.Parse(numberPart);
                            numberPartInt++;
                            numberPart = numberPartInt.ToString();
                            numberPart = numberPart.PadLeft(numberPartLength, '0');
                        }
                        else
                        {
                            int numberPartInt = int.Parse(numberPart);
                            numberPartInt++;
                            numberPart = numberPartInt.ToString();
                        }
                        break;
                    }
                }
                return textPart + numberPart;
            }
            else
            {
                return txt + "1";
            }
        }
        /*
         * Exercise 10.
         * Write a method to validate a sercure password.
         *     The password must contain at least one uppercase character.
         *     The password must contain at least one lowercase character.
         *     The password must contain at least one number.
         *     The password must contain at least one special character 
         *     The password must not contain other special characters then ! @ # $ % ^ & * ( ) + = - { } [ ] : ; " ' ? < > , . _
         *     The password must be at least 8 characters in length.
         *     The password must not be 25 characters or over in length.
         */
        public static bool ValidatePassword(string password)
        {
            const int minPasswordLength = 8;
            const int maxPasswordLength = 25;
            const string specialCharacters = "!@#$%^&*()+=-{}[]:;\"'?<>,._";
            if (password.Length < minPasswordLength)
            {
                return false;
            }
            else if (password.Length >= maxPasswordLength)
            {
                return false;
            }
            else if (!password.Any(x => char.IsUpper(x)))
            {
                return false;
            }
            else if (!password.Any(x => char.IsLower(x)))
            {
                return false;
            }
            else if (!password.Any(x => char.IsDigit(x)))
            {
                return false;
            }
            else if (!password.Any(x => specialCharacters.Contains(x)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}