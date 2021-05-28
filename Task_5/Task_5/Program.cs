using System;
using System.Collections.Generic;
using System.IO;

namespace Task_5
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Input Number");
            int number = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();
            for (int i = 0; i < number; i++)
            {
               persons.Add(new Person()); 
            }
            
            var path =Path.Combine(Environment.CurrentDirectory, @"../../../../Hello.txt");
           
            try
            {
                using (StreamWriter stream = new StreamWriter(path, true))
                    {
                        foreach (var p in persons)
                        {
                            stream.WriteLine(p.Name);  
                        }
                        
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}