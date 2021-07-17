using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BinarySearchTheWordInWordList
    {
        public String[] wordList;
        public void ReadInput()
        {
            String userString;
            String text = "Read in a list of words from File";
            wordList = text.Split(' ');
            Array.Sort(wordList);
            
            Console.Write("Enter the Word to be Searched : ");
            userString = Convert.ToString(Console.ReadLine());
            int result = Search(wordList, userString);
            if (result == -1)
                Console.WriteLine(" The Word "+userString+" not present");
            else
                Console.WriteLine(" The Word \"" + userString + "\" found at index : " + result);
        }
        public int Search(String[] wordList, String userString)
        {
            int start = 0, end = wordList.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                int value = userString.CompareTo(wordList[mid]);

                if (value == 0)
                    return mid;

                if (value > 0)
                    start = mid + 1;

                else
                    end = mid - 1;
            }

            return -1;
        }
        
    }
}
