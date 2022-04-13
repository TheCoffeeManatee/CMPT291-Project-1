using CMPT291_Project;

namespace CMPT291_Project
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            ApplicationConfiguration.Initialize();
            var login = new LoginScreen();
            var mainform =  new MainFrm();

            if (login.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return; // Exit the application
            }


            Start();
        }

        public static void Start()   // <-- must be marked public!
        {
            
            Application.Run(new MainFrm());
        }
    }
}