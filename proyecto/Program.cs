namespace proyecto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //proyecto.formsu.usuario.newsesion("pepe", "Asd", "XD");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            
            //proyecto.formsu.lista_articulos.load();
           //Application.Run(new reserva.fr_reservar());
           //Application.Run(new proyecto.menu.menu());
            Application.Run(new login.login());
        }
    }
}