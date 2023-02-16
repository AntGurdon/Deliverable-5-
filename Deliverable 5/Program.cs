/*
Author: Anthony Gurdon
Date: 02/16/2023
Description: Mehods
*/

using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            //Ask user to enter the size of the array
            Console.Write("Enter an integer number between 5 and 15: ");
            string input = Console.ReadLine();

            try
            {
                size = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter an integer number.");
                return;
            }
            if (size < 5 || size > 15)
            {
                Console.WriteLine("Invalid input. The number must be between 5 and 15. ");
                return;
            }

            // Create the array
            int[] array = new int[size];

            //Populate the array with random numbers between 10 and 50
            PopulateArray(array);

            //Display the elements of the array
            Console.Write("The elements of the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //Sum the elements of the array
            int sum = SumArray(array);

            //Display the sum of the elements
            Console.WriteLine("The sum is: " + sum);

        }
        // Method to randomly populate an array with integers between 10 and 50
        static void PopulateArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 51);
            }
        }
        //Method to sum the elements of an array
        static int SumArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}