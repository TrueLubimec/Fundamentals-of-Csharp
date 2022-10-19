using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        public Guid id;
        public string? name;
        public int age;
        public int group;
        
        //// МЕТОДЫ И КЛАССЫ | ВЫЗОВ МЕТОДА ОБЪЕКТА КЛАССА                          МЕТОДЫ И КЛАССЫ | ВЫЗОВ МЕТОДА ОБЪЕКТА КЛАССА
        public void Print ()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return $"{name} {age}";
        }
    }
}
