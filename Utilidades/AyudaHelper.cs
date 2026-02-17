using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LigaZamaca.Utilidades
{
    /// <summary>
    /// Clase para gestionar la ayuda de la aplicación
    /// </summary>
    public static class AyudaHelper
    {
        /// <summary>
        /// Nombre del archivo del manual de usuario
        /// </summary>
        private const string NOMBRE_MANUAL = "ManualUsuario_LigaZamaca.pdf";

        /// <summary>
        /// Abre el manual de usuario en PDF
        /// </summary>
        public static void AbrirManual()
        {
            try
            {
                // Construir la ruta al manual
                string rutaManual = Path.Combine(Application.StartupPath, NOMBRE_MANUAL);

                // Verificar si existe el archivo
                if (!File.Exists(rutaManual))
                {
                    // Intentar en la carpeta Ayuda
                    rutaManual = Path.Combine(Application.StartupPath, "Ayuda", NOMBRE_MANUAL);
                }

                if (!File.Exists(rutaManual))
                {
                    MessageBox.Show(
                        "No se encontró el manual de usuario.\n\n" +
                        $"Ruta buscada: {rutaManual}\n\n" +
                        "Asegúrese de que el archivo 'ManualUsuario_LigaZamaca.pdf' " +
                        "esté en la carpeta de la aplicación.",
                        "Manual no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Abrir el PDF con el visor predeterminado del sistema
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaManual,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al abrir el manual: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Registra el atajo F1 en un formulario para abrir la ayuda
        /// </summary>
        /// <param name="form">Formulario donde registrar el atajo</param>
        public static void RegistrarAtajoAyuda(Form form)
        {
            form.KeyPreview = true;
            form.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    AbrirManual();
                    e.Handled = true;
                }
            };
        }
    }
}