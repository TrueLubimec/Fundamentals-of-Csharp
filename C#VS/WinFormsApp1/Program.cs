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

            //// ÎÏÅĞÀÒÎĞ ÏĞÈÑÂÀÈÂÀÍÈß ÑÎ ÇÍÀ×ÅÍÈÅÌ NULL                                    ÎÏÅĞÀÒÎĞ ÏĞÈÑÂÀÈÂÀÍÈß ÑÎ ÇÍÀ×ÅÍÈÅÌ NULL

            //string str = null;
            //str ??= string.Empty; //ğîşèò íà âåğñèè 8.0 è âûøå (òèï ôğıéìâîğêà)
            //Console.WriteLine($"The length of the string: {str.Length}");


            //int[] MyArray = {1,23,14,24};
            //MyArray ??= new int[0];
            //Console.WriteLine($"Amount: {MyArray.Length}");




        }
    }
}