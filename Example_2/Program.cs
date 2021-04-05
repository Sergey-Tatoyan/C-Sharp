using System;
using System.Collections.Generic;

namespace Example_2
{
    class Program
    {
        static void Count(int[] numbers)
        {
            // var arr = new Stack<int>();
            var arr = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    // arr.Push(numbers[i]);
                    arr.Add(numbers[i]);
                }
            }

            Console.Write("drakan tvern en: ");
            foreach (var item in arr)
                Console.Write(item + ", ");
            Console.WriteLine();
            Console.Write($"drakan tveri qanakn e: {arr.Count}");
        }

         static int[] ConsolArr()
        {
            int[] numbers = new int[10]; 
            int i;  
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");	
  
            Console.Write("Input 10 elements in the array :\n");  
            for(i=0; i<10; i++)  
            {  
                Console.Write("element - {0} : ",i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nElements in array are: ");  
            for(i=0; i<10; i++)  
            {  
                Console.Write( numbers[i] + ", ");  
            } 
            Console.Write("\n");

            return numbers;
        }

        static void Main(string[] args)
        {
            int[] numbers = ConsolArr();
            numbers ??= new[] {-4, -3, -2, -1, 0, 1, 2, 3, 4};
            Count( numbers);
        }
    }
}