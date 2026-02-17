using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;

namespace LigaZamaca.Informes
{
    /// <summary>
    /// Formulario visor del informe de Goleadores.
    /// Este informe solicita un parámetro (cantidad de goleadores a mostrar).
    /// </summary>
    public partial class FormInformeGoleadores : Form
    {
        private ReportDocument reporteGoleadores;
        private InformeDAO informeDAO;

        public FormInformeGoleadores()
        {
            InitializeComponent();
            informeDAO = new InformeDAO();
        }

        private void FormInformeGoleadores_Load(object sender, EventArgs e)
        {
            // Configurar valores por defecto
            numCantidad.Value = 10;
            numCantidad.Minimum = 1;
            numCantidad.Maximum = 50;

            // Cargar informe inicial
            CargarInforme();
        }

        /// <summary>
        /// Carga y muestra el informe de goleadores
        /// </summary>
        private void CargarInforme()
        {
            try
            {
                // Obtener el parámetro de cantidad
                int cantidad = (int)numCantidad.Value;

                // Crear instancia del informe
                reporteGoleadores = new ReportDocument();

                // Cargar el archivo .rpt
                string rutaInforme = Application.StartupPath + @"\Informes\RptGoleadores.rpt";
                reporteGoleadores.Load(rutaInforme);

                // Obtener los datos con el parámetro
                DataTable datos = informeDAO.ObtenerDatosGoleadores(cantidad);

                // Asignar datos al informe
                reporteGoleadores.SetDataSource(datos);

                // Configurar parámetros del informe
                reporteGoleadores.SetParameterValue("CantidadGoleadores", cantidad);
              //  reporteGoleadores.SetParameterValue("Temporada", "2024-2025");
              //  reporteGoleadores.SetParameterValue("FechaGeneracion", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                // Mostrar en el visor
                crystalReportViewer.ReportSource = reporteGoleadores;
                crystalReportViewer.Refresh();

                // Actualizar etiqueta de estado
                lblEstado.Text = $"Mostrando Top {cantidad} goleadores - Generado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón para generar el informe con el nuevo parámetro
        /// </summary>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CargarInforme();
        }

        /// <summary>
        /// Botón para exportar a PDF
        /// </summary>
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarInforme(ExportFormatType.PortableDocFormat, "pdf", "Documento PDF");
        }

        /// <summary>
        /// Botón para exportar a Excel
        /// </summary>
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarInforme(ExportFormatType.Excel, "xls", "Libro de Excel");
        }

        /// <summary>
        /// Exporta el informe al formato especificado
        /// </summary>
        private void ExportarInforme(ExportFormatType formato, string extension, string descripcion)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = $"{descripcion} (*.{extension})|*.{extension}";
                saveDialog.FileName = $"TopGoleadores_{numCantidad.Value}_{DateTime.Now:yyyyMMdd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    reporteGoleadores.ExportToDisk(formato, saveDialog.FileName);
                    MessageBox.Show("Informe exportado correctamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón para imprimir
        /// </summary>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                reporteGoleadores.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpieza al cerrar el formulario
        /// </summary>
        private void FormInformeGoleadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reporteGoleadores != null)
            {
                reporteGoleadores.Close();
                reporteGoleadores.Dispose();
            }
        }
    }
}