using System;

namespace Template.Comparable
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            var other = (Person) obj;

            return string.Compare(Name, other.Name, StringComparison.Ordinal) == 0 
                ? Age.CompareTo(other.Age) 
                : string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{Name} : {Age}";
        }
    }
}