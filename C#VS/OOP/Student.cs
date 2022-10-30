using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    internal class Student
    {
        //public guid id;
        //public string? name;
        //public datetime age;
        //public int group;

        ////// МЕТОДЫ И КЛАССЫ | ВЫЗОВ МЕТОДА ОБЪЕКТА КЛАССА                          МЕТОДЫ И КЛАССЫ | ВЫЗОВ МЕТОДА ОБЪЕКТА КЛАССА
        //public void Print ()
        //{
        //    Console.WriteLine($"ID: {id}");
        //    Console.WriteLine($"Name: {name}");
        //    Console.WriteLine($"Age: {age}");
        //    Console.WriteLine($"Group: {group}");
        //}

        //public string GetFullName()
        //{
        //    return $"{name} {age}";
        //}

        ////// Ключевое слово this.                                                   Ключевое слово this.
        //public Student(string name, DateTime age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}
        //// Используется, когда есть неоднозначность в названии переменных
        //public Student(string name, DateTime age, int group) : this(name, age) // То есть он делегирует эти данные другому конструктору
        //{
        //    this.id = new Guid();
        //    this.group = group;
        //}


        //// СИНСТАКСИС ИНИЦИАЛИЗАЦИИ ОБЪЕКТОВ
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }
    }

    //// НАСЛЕДОВАНИЕ                                                                   НАСЛЕДОВАНИЕ
    //class Person
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public void PrintName()
    //    {
    //        Console.WriteLine($"Meine Name ist {FirstName}!");
    //    }
    //}
    //class Studik : Person // Через двоеточие указываем от чего унаследовать
    //{
    //    // Т.е класс Studik одновременно явялется классом Person.
    //    // Studik - наследник. Person - базовый
    //    public void Learn()
    //    {
    //        Console.WriteLine($"{LastName} is studying");
    //    }
    //}



    ////particle КЛАСС                                                                particle КЛАСС
    //partial class PartialClass
    //{
    //    // Хз пока как это юзать для консоли
    //}
}
