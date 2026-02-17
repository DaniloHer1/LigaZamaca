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
    /// Formulario visor del informe de Clasificación de la Liga.
    /// Este informe obtiene datos de múltiples tablas (Vista_Clasificacion).
    /// </summary>
    public partial class FormInformeClasificacion : Form
    {
        private ReportDocument reporteClasificacion;
        private InformeDAO informeDAO;

        public FormInformeClasificacion()
        {
            InitializeComponent();
            informeDAO = new InformeDAO();
        }

        private void FormInformeClasificacion_Load(object sender, EventArgs e)
        {
            CargarInforme();
        }

        /// <summary>
        /// Carga y muestra el informe de clasificación
        /// </summary>
        private void CargarInforme()
        {
            try
            {
                // Crear instancia del informe
                reporteClasificacion = new ReportDocument();

                // Cargar el archivo .rpt desde la carpeta de informes
                string rutaInforme = Application.StartupPath + @"\Informes\RptClasificacion.rpt";
                reporteClasificacion.Load(rutaInforme);

                // Obtener los datos
                DataTable datos = informeDAO.ObtenerDatosClasificacion();

                // Asignar datos al informe
                reporteClasificacion.SetDataSource(datos);

                // Configurar parámetros del informe (título, fecha, etc.)
                //reporteClasificacion.SetParameterValue("Temporada", "2025-2026");
                //reporteClasificacion.SetParameterValue("FechaGeneracion", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                // Mostrar en el visor
                crystalReportViewer.ReportSource = reporteClasificacion;
                crystalReportViewer.Refresh();

                // Actualizar etiqueta de estado
                lblEstado.Text = $"Informe generado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón para actualizar el informe
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
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
                saveDialog.FileName = $"Clasificacion_Liga_{DateTime.Now:yyyyMMdd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    reporteClasificacion.ExportToDisk(formato, saveDialog.FileName);
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
                reporteClasificacion.PrintToPrinter(1, false, 0, 0);
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
        private void FormInformeClasificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reporteClasificacion != null)
            {
                reporteClasificacion.Close();
                reporteClasificacion.Dispose();
            }
        }
    }
}