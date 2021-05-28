using System;

namespace Task_5
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {
            GeneratePerson();
        }

        private void GeneratePerson()
        {
            string FirstName = new Bogus.DataSets.Name().FirstName();
            string LastName =   new Bogus.DataSets.Name().LastName();
            int Age;
            string[] Gender = {"Male", "Female"};

            Random random = new Random();
            Age = random.Next(1, 100);
            Name = FirstName + " " + LastName + " " + Age + " " + Gender[random.Next(0, Gender.Length)];
            
        }
    }
}