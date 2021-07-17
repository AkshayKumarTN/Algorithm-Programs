using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class BubbleSort
    {
        public static int[] numberList;
        public void ReadInput()
        {
            int i, user;
            Console.Write("Enter Number of Strings you wish to enter : ");
            int len = Convert.ToInt32(Console.ReadLine());
            numberList = new int[len];
            for (i = 0; i < len; i++)
            {
                Console.Write("Enter String[" + i + "] : ");
                user = Convert.ToInt32(Console.ReadLine());
                numberList[i] = user;
            }

            Sort(len);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < len; i++)
            {
                Console.Write(numberList[i] + " ");
            }
        }
        public void Sort(int len)
        {
            bool flag = true;
            int temp;

            // Sorting an Array..........
            for (int i = 1; (i <= (len - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (len - 1); j++)
                {
                    if (numberList[j + 1] < numberList[j])
                    {
                        temp = numberList[j];
                        numberList[j] = numberList[j + 1];
                        numberList[j + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
    }
}
