using System;
using System.Collections.Generic;

namespace Iteration_Statements_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3 }; //An example List<int> (a list of integers) to play around with using Loops

            //for loop example ---> type (for) and hit Tab twice
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            //foreach loop example ---> type (foreach) and hit Tab twice
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //while loop example ---> type (while) and hit Tab twice
            var index1 = 0;
            while (index1 < list.Count)
            {
                Console.WriteLine(list[index1]);
                index1++;
            }


            //do-while loop example ---> type (do) and hit Tab twice
            var index2 = 0;
            do
            {
                Console.WriteLine(list[index2]);
                index2++;
            } while (index2 < list.Count);


            //--------------------------------------------------------------------------------------------------------------------------------

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//An example int[] (an array of integers) to play around with using Loops

            //TODO --> Use a foreach loop to print each number to the console
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }


            //TODO --> Use a for loop to print only the EVEN numbers
            for (int i = 1; i < arr.Length; i+=2)
            {
                Console.WriteLine(arr[i]);
            }


            //TODO --> Using a while loop, print out to the console "This is not the number you're looking for" 10 times

            //Create an integer variable and initialize it to 0
            int x = 0;

            while (x < 10)
            {
                Console.WriteLine("This is not the number you're looking for");
                x++; //we need to increment x otherwise we will have an infinite loop because the condition (x < 10) will always be true
            }


            //TODO --> Using a do-while loop, ask the user for their favorite number then print out that number 10 times

            //Create an integer variable and initialize it to 0;
            int y = 0;

            Console.WriteLine("What is your favorite number?");
            var favoriteNumber = Console.ReadLine();

            do
            {
                Console.WriteLine(favoriteNumber);
                y++;
            } while (y < 10);
        }
    }
}
