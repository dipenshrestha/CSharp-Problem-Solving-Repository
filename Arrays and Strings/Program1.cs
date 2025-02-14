
/* Given an integer array, write a C# program to determine whether the array contains any duplicate numbers. */

using System;
using System.Collections.Generic; //for using HashSet

namespace Basics
{
    internal class Program1
    {
        //time Complexity: O(n^2)
        public bool BruteForce(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //time Complexity: O(nlog(n))
        public bool SortingMethod(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    return true;
                }
            }

            return false;
        }

        //time Complexity: O(n)
        public bool HashSet(int[] arr)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in arr)
            {
                if (seenNumbers.Contains(num))
                {
                    return true;
                }
                seenNumbers.Add(num);
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 2, 1, 5 };
            int choice;
            Program1 p1 = new Program1();
        top:
            Console.WriteLine("Choices to Find Duplicate Number in array: \n 1. Brute Force \n 2. Sorting + Checking Adjacent Elements \n 3. Using HashSet");
            Console.Write("Enter your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (p1.BruteForce(arr))
                    {
                        Console.WriteLine("Duplicate number found.");
                    }
                    else
                    {
                        Console.WriteLine("No duplicate numbers.");
                    }
                    Console.ReadLine();
                    break;

                case 2:
                    if (p1.SortingMethod(arr))
                    {
                        Console.WriteLine("Duplicate number found.");
                    }
                    else
                    {
                        Console.WriteLine("No duplicate numbers.");
                    }
                    Console.ReadLine();
                    break;

                case 3:
                    if (p1.HashSet(arr))
                    {
                        Console.WriteLine("Duplicate number found.");
                    }
                    else
                    {
                        Console.WriteLine("No duplicate numbers.");
                    }
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Wrong Choice!!!");
                    goto top;
            }
        }
    }
}
