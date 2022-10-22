// See https://aka.ms/new-console-template for more information
using OOP;
using System.Reflection;

namespace OOP // Если namespace (названия) одинаковые в файлах, то они позволяют юзать классы из других файлов
{
	class Program
	{

        static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

            // ЧТО ТАКОЕ КЛАСС															ЧТО ТАКОЕ КЛАСС
            //enum Color
            //{
            //    Yellow,
            //    Red,
            //    Blue,
            //    Violet,
            //    Bebra
            //}
            //class Point
            //{
            //    public int x; // public редко юзают, обычно данные скрыты и доступ к ним через свойства или методы
            //    public int y;
            //    public Color color;
            //}

            //Point p = new Point();
            //p.x = 4;
            //p.y = 5;
            //p.color = Color.Red;
            //Console.WriteLine($"{ p.x}, { p.y}, {p.color}");
            //p = null; // УДАЛИЛИ СВЯЗЬ

            //Point p2 = new Point();
            //p2.x = 1;
            //p2.y = 2;
            //Console.WriteLine($"{p2.x}, {p2.y}");


            //class student
            //{
            //	// Для удобства и в вопросах архитектуры для классов иногда создают отдельные файлы в проекте
            //	public Guid id;
            //	public string? name;
            //	public int age;
            //	public int group;
            //}

            //var Student1 = GetStudent();

            //Print(Student1);
            //         static Student GetStudent()
            //         {
            //             Student/* тут мог быть var (это не тип данных) */ Student = new Student();

            //             Student.id = Guid.NewGuid();
            //             Student.name = "Kto";
            //             Student.group = 01;
            //             Student.age = 22;

            //             return Student;
            //         }
            //         static void Print(Student Student)
            //         {
            //             Console.WriteLine($"ID: {Student.id}");
            //             Console.WriteLine($"Name: {Student.name}");
            //             Console.WriteLine($"Age: {Student.age}");
            //             Console.WriteLine($"Group: {Student.group}");
            //         }



            //// МЕТОДЫ И КЛАССЫ | ВЫЗОВ МЕТОДА ОБЪЕКТА КЛАССА                          МЕТОДЫ И КЛАССЫ | ВЫЗОВ МЕТОДА ОБЪЕКТА КЛАССА
            // В файле Student.cs
            // Крч, можно в классе прописать методы и в переменной потом вызывать сразу,
            // тип сам себя будет вызывать, что отдельно метод не прописывать в файле

            //var Student1 = GetStudent();
            //Student1.Print();
            //Console.WriteLine(" ------------ ");
            //var Student2 = new Student();
            //Student2.id = Guid.NewGuid();
            //Student2.Print();
            //Console.WriteLine(" ------------ ");
            //var SpecialStudent = new Student();
            //SpecialStudent.GetFullName();
            //SpecialStudent.Print();

            //ФАЙЛ Car.cs
            //var car = new Car();
            //car.PrintSpeed();
            //car.DrivingForward();
            //car.PrintSpeed();



            //// МЕТОДЫ И КЛАССЫ | РАЗНИЦА МЕЖДУ public & private                       РАЗНИЦА МЕЖДУ public & private
            // Очевидно, что public позволяет обращаться к методу через объект,
            // а private не позволяет - НО ЭТО НЕ ЗНАЧИТ, что его нет или на него
            // нельзя как-то повлиять
            // Если модификатор доступа не обозначен - то по умолчанию - private

            //var typeInfo = typeof(Point).
            //    GetField(BindingFlags.Instance | 
            //    BindingFlags.NonPublic | 
            //    BindingFlags.Public);



            //// ИНКАПСУЛЯЦИЯ                                                           ИНКАПСУЛЯЦИЯ
            // Позволяет правильно настроить под управление, то есть сделать так,
            // чтобы им могли пользоваться так ,как задумывалось.
            // То есть закрывает те методы, которые пользователю не нужны. Спасает логику класса!



            //// КОНСТРУКТОР КЛАССА                                                     КОНСТРУКТОР КЛАССА
            // Конструктор есть даже, если мы его явно не определили
            // конструктор вызывается для создания экземпляра (new "название класса")
            // ФАЙЛ Gun.cs
            // 
            //var bebra = new Gun(/*Можно также юзать именные*/isLoaded: true);
            //bebra.Shoot();



            //// ПЕРЕГРУЗКА КОНСТРУКТОРОВ КЛАССА                                        ПЕРЕГРУЗКА КОНСТРУКТОРОВ КЛАССА
            // По сути, тоже самое - что перегрузка методов (через сниппет ctor)
            // Классы - ССЫЛОЧНЫЕ ТИПЫ!! ДАННЫЕ ХРАНЯТСЯ В УПРАВЛЯЕМОЙ КУЧЕ
            // student Student2 = new student(student1) Так можно создавать отдельные копии (если был создан конструктор внутри класса)
            // Вот так: 
            //public Student (Student student)
            //{
            //    _name = student.name;
            //    _age = student.age;
            //}



            //// КЛЮЧЕВОЕ СЛОВО this.                                                   КЛЮЧЕВОЕ СЛОВО this.
            // ФАЙЛ Student.cs
            // В static this не юзается!
        }
    }
}