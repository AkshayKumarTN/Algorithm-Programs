using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Permutations
    {
        public void ReadInput()
        {
            String userString;
            int len;
            Console.Write("Enter a String : ");
            userString = Convert.ToString(Console.ReadLine());
            len = userString.Length;
            Permute(userString,0,len-1);

        }
        public void Permute(string userString,int start,int end)
        {
            if (start == end)
            {
                Console.WriteLine(userString);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    userString = swap(userString, start, i);
                    Permute(userString, start + 1, end);
                    userString = swap(userString, start, i);
                }
            }
        }
        public static String swap(String a,int index1, int index2)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[index1];
            charArray[index1] = charArray[index2];
            charArray[index2] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
