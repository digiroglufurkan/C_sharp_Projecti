namespace Catering_Projectin
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
            // ApplicationConfiguration.Initialize();
            //Application.Run(new Etusivu());
            //Application.Run(new KokkiKotisivu());
            //Application.Run(new AdminKotisivu());
            //Application.Run(new Menu());
            Application.Run(new Kirjaudu());
            //Application.Run(new Rekisteroidy());
           // Application.Run(new kayttayatili());
        }
    }
}