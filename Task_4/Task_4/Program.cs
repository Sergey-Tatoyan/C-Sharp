using System;
using System.Linq;

namespace Task_4
{
    class Program
    {
        static void User(string name, string surName, int age = default, int height = default)
        {

            Console.WriteLine("Name: " +  name);
                Console.WriteLine("Surname: " + surName);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Height: " + height);
        }

        static void PrintMaxNumber(params int[] arr)
        {
            Console.WriteLine(arr.Max());
        }
        static void Main(string[] args)
        {
            User( "valod", "gogo");
            
            PrintMaxNumber(45, 5, 8, 9, 1, 0, 34, 12);
            
            PrintMaxNumber(new int[] {45, 5, 8, 9, 1, 0, 34, 12});
        }
    }
}