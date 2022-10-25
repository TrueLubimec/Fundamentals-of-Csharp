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



            //// СВОЙСТВА get set | ключевое слово value                                СВОЙСТВА get set | ключевое слово value
            // По сути - те же самые методы
            // В блоке set устанавливается значение свойства.
            // В блоке get выполняются действия по получению значения свойства.

            // Но в C# есть особенность
            // ФАЙЛ Point.cs
            //Point point = new Point();

            //point.Y = 6; // ТУТ СЕТТЕР
            //int Y = point.Y; // ТУТ ГЕТТЕР



            //// КЛЮЧЕВОЕ СЛОВО static                                                  КЛЮЧЕВОЕ СЛОВО static
            // static даёт доступ к переменным для всех объектов экземпляра
            // (т.е. делят между собой, одна область в ОЗУ)
            // можно совмезать с режимами доступа
            // ФАЙЛ Point.cs, class MyClass!!
            //MyClass.b = 5; // тип мы обратились к переменной, даже не выделяя новую память под экземпляр



            //// СТАТИЧЕСКИЙ МЕТОД                                                      СТАТИЧЕСКИЙ МЕТОД
            // схожая работа с полями
            // ФАЙЛ Point.cs
            //MyClass myClass = new MyClass();
            //myClass.Boo(); // У него не было static, а у Foo есть - и он нам недоступен
            //MyClass.Foo(); // Но теперь на уровне самого класса есть возможность вызова метода

            //MyClass myClass1 = new MyClass();
            //MyClass myClass2 = new MyClass();
            //MyClass myClass3 = new MyClass();

            //Console.WriteLine(MyClass.Counter);



            //// СТАТИЧЕСКИЙ КОНСТРУКТОР КЛАССА                                         СТАТИЧЕСКИЙ КОНСТРУКТОР КЛАССА
            // Статичный конструктор вызывается лишь один раз!
            // И он вызывается всегда перед обычным
            // Принцип работы с нестатичными членами такой же - как в методах
            // Удобно использовать с базами данных (для оптимизации) 



            //// СТАТИЧЕСКИЙ КЛАСС                                                      СТАТИЧЕСКИЙ КЛАСС
            // ФАЙЛ Point.cs, класс StaticClass
            // Не даёт создать объект или экземпляр такого класса
            // т.к. он статический - не позволяет создавать
            // методы, поля, свойства внутри себя без static 
            // Ну и конструктор тоже нельзя закинуть



            //// МЕТОДЫ РАСШИРЕНИЯ                                                      МЕТОДЫ РАСШИРЕНИЯ
            // Полезно, если мы не имеем доступа к методу и не можем его переписать
            // ФАЙЛ Gun.cs, класс MyExtension
            // Желательно писать в другом пространстве имён
            //DateTime date = DateTime.Now;
            //date.Print();
            //// Можно было просто вот так написать:
            //DateTime.Now.Print();

            DateTime Current = DateTime.Now;
            Console.WriteLine(Current.Check(DayOfWeek.Wednesday));

            // sealed modifier - When applied to a class, the sealed modifier prevents other classes from inheriting from it.
            // Если наследование невозиожно(например стоит модификатор sealed), то помогает расширение метода
        }
    }
}