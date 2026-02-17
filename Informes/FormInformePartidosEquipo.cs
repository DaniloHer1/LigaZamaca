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
    /// Formulario visor del informe de Partidos por Equipo.
    /// Este informe contiene un gráfico de resultados (Victorias, Empates, Derrotas).
    /// </summary>
    public partial class FormInformePartidosEquipo : Form
    {
        private ReportDocument reportePartidos;
        private InformeDAO informeDAO;
        private EquipoDAO equipoDAO;

        public FormInformePartidosEquipo()
        {
            InitializeComponent();
            informeDAO = new InformeDAO();
            equipoDAO = new EquipoDAO();
        }

        private void FormInformePartidosEquipo_Load(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        /// <summary>
        /// Carga la lista de equipos en el ComboBox
        /// </summary>
        private void CargarEquipos()
        {
            try
            {
                cmbEquipo.Items.Clear();
                cmbEquipo.Items.Add("-- Seleccione un equipo --");

                var equipos = equipoDAO.ObtenerTodos();
                foreach (var equipo in equipos)
                {
                    cmbEquipo.Items.Add(new ComboBoxItem(equipo.IdEquipo, equipo.Nombre));
                }

                cmbEquipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento cuando cambia la selección del equipo
        /// </summary>
        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = cmbEquipo.SelectedIndex > 0;
        }

        /// <summary>
        /// Botón para generar el informe
        /// </summary>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbEquipo.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor, seleccione un equipo",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarInforme();
        }

        /// <summary>
        /// Carga y muestra el informe de partidos del equipo
        /// </summary>
        private void CargarInforme()
        {
            try
            {
                // Obtener el equipo seleccionado
                ComboBoxItem item = (ComboBoxItem)cmbEquipo.SelectedItem;
                int idEquipo = item.Value;
                string nombreEquipo = item.Text;

                // Crear instancia del informe
                reportePartidos = new ReportDocument();

                // Cargar el archivo .rpt
                string rutaInforme = Application.StartupPath + @"\Informes\RptPartidosEquipos.rpt";
                reportePartidos.Load(rutaInforme);

                // Obtener los datos
                DataTable datosPartidos = informeDAO.ObtenerPartidosEquipo(idEquipo);
                DataTable datosResumen = informeDAO.ObtenerResumenEquipo(idEquipo);
                DataTable datosGrafico = informeDAO.ObtenerDatosGraficoResultados(idEquipo);

                // Crear DataSet con múltiples tablas
                DataSet ds = new DataSet("DSPartidosEquipo");
                datosPartidos.TableName = "PartidosEquipo";
                datosResumen.TableName = "ResumenEquipo";
                datosGrafico.TableName = "GraficoResultados";

                ds.Tables.Add(datosPartidos.Copy());
                ds.Tables.Add(datosResumen.Copy());
                ds.Tables.Add(datosGrafico.Copy());

                // Asignar datos al informe
                reportePartidos.SetDataSource(ds);

                // Configurar parámetros del informe
                reportePartidos.SetParameterValue("IdEquipo", idEquipo);

                // Mostrar en el visor
                crystalReportViewer.ReportSource = reportePartidos;
                crystalReportViewer.Refresh();

                // Actualizar etiqueta de estado
                lblEstado.Text = $"Informe de {nombreEquipo} - Generado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

                // Habilitar botones de exportación
                btnExportarPDF.Enabled = true;
                btnExportarExcel.Enabled = true;
                btnImprimir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                ComboBoxItem item = (ComboBoxItem)cmbEquipo.SelectedItem;
                string nombreEquipo = item.Text.Replace(" ", "_");

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = $"{descripcion} (*.{extension})|*.{extension}";
                saveDialog.FileName = $"Partidos_{nombreEquipo}_{DateTime.Now:yyyyMMdd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    reportePartidos.ExportToDisk(formato, saveDialog.FileName);
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
                reportePartidos.PrintToPrinter(1, false, 0, 0);
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
        private void FormInformePartidosEquipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reportePartidos != null)
            {
                reportePartidos.Close();
                reportePartidos.Dispose();
            }
        }
    }

    /// <summary>
    /// Clase auxiliar para items del ComboBox con valor e texto
    /// </summary>
    public class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem(int value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}