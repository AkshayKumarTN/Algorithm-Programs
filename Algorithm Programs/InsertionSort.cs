using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    
    class InsertionSort
    {

        public static String[] wordList;
        public void ReadInput()
        {
            int i;
            string user;
            Console.Write("Enter Number of Strings you wish to enter : ");
            int len = Convert.ToInt32(Console.ReadLine());
            wordList = new string[len];
            for (i = 0; i < len; i++)
            {
                Console.Write("Enter String["+i+"] : ");
                user = Convert.ToString(Console.ReadLine());
                wordList[i] = user;
            }
                       
            Sort(len);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < len; i++)
            {
                Console.Write(wordList[i] + " ");
            }
        }
        public static void Sort( int len)
        {
            int i, j, flag;
            string val;
            for (i = 1; i < len; i++)
            {
                val = wordList[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo(wordList[j])<0)
                    {
                        wordList[j + 1] = wordList[j];
                        j--;
                        wordList[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
        }
    }
}
