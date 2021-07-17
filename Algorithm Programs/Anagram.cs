using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Anagram
    {
        public void ReadInput()
        {
            Console.Write("Enter First String : ");
            string string1 = Console.ReadLine();
            Console.Write("Enter Second String : ");
            string string2 = Console.ReadLine();
            if (DetectionOfAnagram(string1,string2))
                Console.WriteLine(" Both the Strings are Anagrams");
            else
                Console.WriteLine(" Both the Strings are Not Anagrams");

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
