using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class MergeSort
    {
        public void ReadInput()
        {
            Console.Write(" Enter size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter elements of an array : ");
            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(" Enter element "+(i+1)+" : ");
               arr[i] = Console.ReadLine();
            }
            SortMethod(arr, 0, size - 1);
            Console.Write(" After performing Merge sort : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        private static void SortMethod(string[] arr, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(arr, left, mid);
                SortMethod(arr, mid + 1, right);
                MergeMethod(arr, left, mid + 1, right);
            }
        }
        private static void MergeMethod(string[] arr, int left, int mid, int right)
        {
            string[] temp = new string[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = mid - 1;
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if ((arr[left].CompareTo(arr[mid])) < 0)
                    temp[tmp_pos++] = arr[left++];
                else
                    temp[tmp_pos++] = arr[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = arr[left++];
            while (mid <= right)
                temp[tmp_pos++] = arr[mid++];
            for (i = 0; i < num_elements; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }
    }
}
