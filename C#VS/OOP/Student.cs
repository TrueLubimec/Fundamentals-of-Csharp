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
        public DateTime age;
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

        //// Ключевое слово this.                                                   Ключевое слово this.
        public Student(string name, DateTime age)
        {
            this.name = name;
            this.age = age;
        }
        // Используется, когда есть неоднозначность в названии переменных
        public Student(string name, DateTime age, int group) : this(name, age) // То есть он делегирует эти данные другому конструктору
        {
            this.id = new Guid();
            this.group = group;
        }
    }
}
