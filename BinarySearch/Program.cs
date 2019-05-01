using System;
using System.Diagnostics;

//C# .NET Core example of a simple binary search using O(logn) runtime methods for both recursion and iterative approaches
//Written by Ivan Smith

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive search for O(logn) runtime complexity and O(logn) memory complexity
            int[] arr1 = { 1, 2, 4, 7, 8, 12, 15, 19, 24, 50, 69, 80, 100 };
            Debug.WriteLine("Recursive: Key(12) found at: " + BinarySearchRecursive(arr1, 12));
            Debug.WriteLine("Recursive: Key(44) found at: " + BinarySearchRecursive(arr1, 44));
            Debug.WriteLine("Recursive: Key(80) found at: " + BinarySearchRecursive(arr1, 80));

            //Iterative search for O(logn) runtime complexity and O(1) memory complexity
            int[] arr2 = { 1, 2, 4, 7, 8, 12, 15, 19, 24, 50, 69, 80, 100 };
            Debug.WriteLine("Iterative: Key(12) found at: " + BinarySearchIterative(arr2, 12));
            Debug.WriteLine("Iterative: Key(44) found at: " + BinarySearchIterative(arr2, 44));
            Debug.WriteLine("Iterative: Key(80) found at: " + BinarySearchIterative(arr2, 80));
        }
        static int BinarySearchRecursive(int[] array, int key)
        {
            return BinarySearchRecMethod(array, key, 0, array.Length - 1);

        }
        static int BinarySearchIterative(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {

                int mid = low + ((high - low) / 2);

                if (array[mid] == key)
                {
                    return mid;
                }

                if (key < array[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
        static int BinarySearchRecMethod(int[] array, int key, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = low + ((high - low) / 2);

            if (array[mid] == key)
            {
                return mid;
            }
            else if (key < array[mid])
            {
                return BinarySearchRecMethod(array, key, low, mid - 1);
            }
            else
            {
                return BinarySearchRecMethod(array, key, mid + 1, high);
            }
        }
       
    }
}
