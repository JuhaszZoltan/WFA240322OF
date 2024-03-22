namespace WFA240322OF
{
    internal static class Program
    {
        internal static string connectionString =
            "server=localhost;database=teszt240322;uid=root;";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}