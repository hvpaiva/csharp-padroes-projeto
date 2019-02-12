using System;
using System.Collections.Generic;
using System.Linq;
using Template.Beverage;
using Template.Comparable;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            var coffee = new Coffee();

            tea.WantsCondiments = true;
            tea.AddSugar = 5;
            tea.Prepare();
           
            Console.WriteLine();

            coffee.WantsCondiments = true;
            coffee.Prepare();
            
            Console.WriteLine();

            var people = new List<Person>
            {
                new Person("Luisa", 5),
                new Person("Fernanda", 35)
            };

            ShowPeople(people);
            
            people.Sort();
            
            ShowPeople(people);
        }

        private static void ShowPeople(IEnumerable<Person> people)
        {
            Console.Write(string.Join(" < ", people));
           
            Console.WriteLine();
        }
    }
}