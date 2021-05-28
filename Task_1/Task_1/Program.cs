using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Join";
            int age = 20;
            string gender = "Female";
            double Maths, Physics, Armenian;
            double result;

            Console.WriteLine("Input User  Name");
            string name_name = Console.ReadLine();

            Console.WriteLine("Input User  Age");
             int age_age = int.Parse(Console.ReadLine());

            Console.WriteLine("Input User  Gender");
            string gender_gender = Console.ReadLine();

            Console.WriteLine("Input Grades for the  Maths");
            Maths = double.Parse(Console.ReadLine());

            Console.WriteLine("Input Grades for the  Physics");
            Physics = double.Parse(Console.ReadLine());

            Console.WriteLine("Input Grades for the  Armenian");
            Armenian = double.Parse(Console.ReadLine());

            result = (Maths + Physics + Armenian) / 3;
            if (name_name != "" || gender_gender != "")
            {
                Console.WriteLine("Name: {0} \n Age: {1} \n Gender: {2} \n GPA: {3}", name_name, age_age, gender_gender,
                    result);
            }
            else
            {
                Console.WriteLine("Name: {0} \n Age: {1} \n Gender: {2} \n GPA: {3}", name, age, gender,
                    result);
            }
            
        }
    }
}