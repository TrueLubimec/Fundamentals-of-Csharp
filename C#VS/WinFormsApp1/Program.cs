namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //// ОПЕРАТОР ПРИСВАИВАНИЯ СО ЗНАЧЕНИЕМ NULL                                    ОПЕРАТОР ПРИСВАИВАНИЯ СО ЗНАЧЕНИЕМ NULL

            //string str = null;
            //str ??= string.Empty; //роюит на версии 8.0 и выше (тип фрэймворка)
            //Console.WriteLine($"The length of the string: {str.Length}");


            //int[] MyArray = {1,23,14,24};
            //MyArray ??= new int[0];
            //Console.WriteLine($"Amount: {MyArray.Length}");


            //// ОПЕРАТОР УСЛОВНОГО NULL                                                    ОПЕРАТОР УСЛОВНОГО NULL

            //int[] anArray = { };
            //Console.WriteLine($"Amount of elements: {anArray?.Length ?? 0}"); //сначала проверяет на NULL и подставляет вместо длины NULL. Если NULL - то выводит 0.


            ////КЛЮЧЕВОЕ СЛОВО REF                                                          КЛЮЧЕВОЕ СЛОВО REF

            //int a = -2;
            //Foo(ref a);

            //в новых версиях языка можно создавать ссылочные локальные переменные.
            int[] anArray = { 1, 2, 4 };
            ref int Aref = ref anArray[0];
        }
        ////КЛЮЧЕВОЕ СЛОВО REF                                                          КЛЮЧЕВОЕ СЛОВО REF
        //static void Foo(ref int a) //через ref передаётся по ссылка ,а не значению, т.е. не копируется а передаёт само значенме по координатам в памяти
        //{
        //    a = -5;
        //}
    }
}