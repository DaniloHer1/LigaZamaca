using LigaZamaca.Formularios;
using LigaZamaca.Formularios.Menu;
using LigaZamaca.Formularios.Splash;
using System;
using System.Windows.Forms;

namespace LigaZamaca
{
    /// <summary>
    /// Clase principal de la aplicación Liga Zamaca.
    /// Punto de entrada que muestra el SplashScreen y luego el menú principal.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// Muestra primero el SplashScreen y después el formulario principal.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar SplashScreen
            using (FormSplash splash = new FormSplash())
            {
                if (splash.ShowDialog() == DialogResult.OK)
                {
                    // Después del splash, mostrar el menú principal
                    Application.Run(new FormMenu());
                }
            }
        }
    }
}