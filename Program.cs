using LigaZamaca.AccesoDatos;
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
        /// Muestra primero el SplashScreen, verifica la BD y después el formulario principal.
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
                    // ⭐ VERIFICAR Y CREAR BASE DE DATOS SI NO EXISTE
                    if (!DatabaseInitializer.InicializarBaseDatos())
                    {
                        MessageBox.Show(
                            "No se pudo inicializar la base de datos.\n\n" +
                            "La aplicación se cerrará.",
                            "Error crítico",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    // Si la BD está lista, mostrar el menú principal
                    Application.Run(new FormMenu());
                }
            }
        }
    }
}