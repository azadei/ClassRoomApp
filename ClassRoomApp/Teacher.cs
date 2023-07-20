using System;

namespace demo_1.Models
{
    public class Teacher : BaseEntity
    {
        private static int counter = 0;

        public Teacher(string name, string surname, double salary, DateTime birthDay)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Birthday = birthDay;

            Id = counter;
            counter++;
        }



        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public DateTime Birthday { get; set; }
    }
}
