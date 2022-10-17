// See https://aka.ms/new-console-template for more information
using OOP;

namespace OOP // Если namespace (названия) одинаковые в файлах, то они позволяют юзать классы из других файлов
{
	//class student
	//{
	//	// Для удобства и в вопросах архитектуры для классов иногда создают отдельные файлы в проекте
	//	public Guid id;
	//	public string? name;
	//	public int age;
	//	public int group;
	//}

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



			var Student1 = GetStudent();
			Print(Student1);

		}
        static Student GetStudent()
        {
			Student/* тут мог быть var (это не тип данных) */ Student = new Student();

			Student.id = Guid.NewGuid();
			Student.name = "Kto";
			Student.group = 01;
			Student.age = 22;

			return Student;
        }
        static void Print(Student Student)
        {
			Console.WriteLine($"ID: {Student.id}");
            Console.WriteLine($"Name: {Student.name}");
            Console.WriteLine($"Age: {Student.age}");
            Console.WriteLine($"Group: {Student.group}");
        }
    }
}