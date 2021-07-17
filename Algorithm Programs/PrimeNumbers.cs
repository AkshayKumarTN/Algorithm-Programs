using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class PrimeNumbers
    {
        public void FindPrime()
        {
            int start = 0, end = 1000;
            int[] arr = new int[200];
            int k = 0;
            Console.WriteLine("\nThe prime numbers between the rang {0} - {1} : ", start, end);
            for (int i = start; i <= end; i++)
            {
                if (i == 0 || i == 1)
                    continue;
                int flag = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i + " ");
                    arr[k] = i;
                    k++;
                }
            }
            Palindromes(arr, k);
            Console.WriteLine();
            Anagrams(arr, k);
        }
        public static void Palindromes(int[] arr, int k)
        {
            Console.WriteLine("\n\nThe Prime Numbers that are Palindrome are : ");
            for (int i = 0; i < k; i++)
            {
                int reverse = Reverse(arr[i]);
                if (arr[i] == reverse && arr[i] > 10)
                    Console.Write(arr[i] + " ");
            }
        }
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                int remainder = num % 10;
                rev = rev * 10 + remainder;
                num /= 10;
            }
            return rev;
        }
        public static void Anagrams(int[] intArray, int k)
        {
            string[] strArray = Array.ConvertAll<int, string>(intArray, ele => ele.ToString());
            Console.WriteLine("\nThe Prime Numbers that are Anagram are : ");
            for (int i = 0; i < k; i++)
                for (int j = i + 1; j < k; j++)
                    if (DetectionOfAnagram(strArray[i], strArray[j]))
                        Console.WriteLine(strArray[i] +
                        " is anagram of " + strArray[j]);
        }
        public static bool DetectionOfAnagram(string string1, string string2)
        {
            char[] ch1 = string1.ToLower().ToCharArray();
            char[] ch2 = string2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string1 = new string(ch1);
            string2 = new string(ch2);
            if (string1 == string2)
                return true;
            else
                return false;
        }
    }
}
