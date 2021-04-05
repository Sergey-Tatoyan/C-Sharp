using System;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
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
            
            
            for (int j = 0; j <= numbers.Length - 2; j++)
            {
                for (int k = 0; k <= numbers.Length - 2; k++)
                {
                    if (numbers[k] > numbers[k + 1])
                    {
                        int a;
                        a = numbers[k + 1];
                        numbers[k + 1] = numbers[k];
                        numbers[k] = a;
                    }
                }
            }
            Console.WriteLine("Bubble sort");
            foreach (int p in numbers)
                Console.Write(p + " ");

        }
    }
}