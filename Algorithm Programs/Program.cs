using System;

namespace Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs\n");
            Console.WriteLine("Select the options:");
            Console.WriteLine("1.Permutations");
            Console.WriteLine("2.Binary Search the Word in the WordList");
            Console.WriteLine("3.Insertion Sort");
            Console.WriteLine("4.Bubble Sort");
            Console.WriteLine("5.Merge Sort");
            Console.WriteLine("6.Anagram Detection");

            Console.Write("\nEnter the Option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Permutations permutation = new Permutations();
                    permutation.ReadInput();
                    break;
                case 2:
                    BinarySearchTheWordInWordList binarySearch = new BinarySearchTheWordInWordList();
                    binarySearch.ReadInput();
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.ReadInput();
                    break;
                case 4:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.ReadInput();
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.ReadInput();
                    break;
                case 6:
                    Anagram anagram = new Anagram();
                    anagram.ReadInput();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }

        }
    }
}
