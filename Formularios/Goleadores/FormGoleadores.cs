using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;

namespace LigaZamaca.Formularios.Goleadores
{
    public partial class FormGoleadores : Form
    {
        private GoleadoresDAO goleadoresDAO;

        public FormGoleadores()
        {
            InitializeComponent();
            goleadoresDAO = new GoleadoresDAO();
        }

        private void FormGoleadores_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarGoleadores();
        }

        /// <summary>
        /// Configura las columnas del DataGridView
        /// </summary>
        private void ConfigurarDataGridView()
        {
            dataGridViewGoleadores.AutoGenerateColumns = false;
            dataGridViewGoleadores.Columns.Clear();
            dataGridViewGoleadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGoleadores.MultiSelect = false;
            dataGridViewGoleadores.ReadOnly = true;
            dataGridViewGoleadores.RowTemplate.Height = 50; // Altura para mostrar escudos

            // Columna Posición
            DataGridViewTextBoxColumn colPosicion = new DataGridViewTextBoxColumn();
            colPosicion.Name = "Posicion";
            colPosicion.HeaderText = "Pos";
            colPosicion.DataPropertyName = "Posicion";
            colPosicion.Width = 50;
            colPosicion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPosicion.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewGoleadores.Columns.Add(colPosicion);

            // Columna Escudo (Imagen)
            DataGridViewImageColumn colEscudo = new DataGridViewImageColumn();
            colEscudo.Name = "Escudo";
            colEscudo.HeaderText = "";
            colEscudo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEscudo.Width = 50;
            dataGridViewGoleadores.Columns.Add(colEscudo);

            // Columna Jugador
            DataGridViewTextBoxColumn colJugador = new DataGridViewTextBoxColumn();
            colJugador.Name = "Jugador";
            colJugador.HeaderText = "Jugador";
            colJugador.DataPropertyName = "NombreCompleto";
            colJugador.Width = 200;
            colJugador.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewGoleadores.Columns.Add(colJugador);

            // Columna Equipo
            DataGridViewTextBoxColumn colEquipo = new DataGridViewTextBoxColumn();
            colEquipo.Name = "Equipo";
            colEquipo.HeaderText = "Equipo";
            colEquipo.DataPropertyName = "NombreEquipo";
            colEquipo.Width = 180;
            dataGridViewGoleadores.Columns.Add(colEquipo);

            // Columna Goles
            DataGridViewTextBoxColumn colGoles = new DataGridViewTextBoxColumn();
            colGoles.Name = "Goles";
            colGoles.HeaderText = "⚽ Goles";
            colGoles.DataPropertyName = "TotalGoles";
            colGoles.Width = 80;
            colGoles.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colGoles.DefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            colGoles.DefaultCellStyle.ForeColor = Color.FromArgb(33, 150, 243);
            dataGridViewGoleadores.Columns.Add(colGoles);

            // Columna Asistencias
            DataGridViewTextBoxColumn colAsistencias = new DataGridViewTextBoxColumn();
            colAsistencias.Name = "Asistencias";
            colAsistencias.HeaderText = "🎯 Asist.";
            colAsistencias.DataPropertyName = "TotalAsistencias";
            colAsistencias.Width = 80;
            colAsistencias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAsistencias.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridViewGoleadores.Columns.Add(colAsistencias);

            // Columna Partidos
            DataGridViewTextBoxColumn colPartidos = new DataGridViewTextBoxColumn();
            colPartidos.Name = "Partidos";
            colPartidos.HeaderText = "PJ";
            colPartidos.DataPropertyName = "PartidosJugados";
            colPartidos.Width = 60;
            colPartidos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGoleadores.Columns.Add(colPartidos);

            // Columna Promedio
            DataGridViewTextBoxColumn colPromedio = new DataGridViewTextBoxColumn();
            colPromedio.Name = "Promedio";
            colPromedio.HeaderText = "Prom.";
            colPromedio.Width = 80;
            colPromedio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPromedio.DefaultCellStyle.Format = "0.00";
            dataGridViewGoleadores.Columns.Add(colPromedio);

            // Columna oculta para URL del escudo
            DataGridViewTextBoxColumn colUrlEscudo = new DataGridViewTextBoxColumn();
            colUrlEscudo.Name = "UrlEscudo";
            colUrlEscudo.DataPropertyName = "EscudoEquipo";
            colUrlEscudo.Visible = false;
            dataGridViewGoleadores.Columns.Add(colUrlEscudo);
        }

        /// <summary>
        /// Carga los goleadores en el DataGridView
        /// </summary>
        private void CargarGoleadores()
        {
            try
            {
                var goleadores = goleadoresDAO.ObtenerTopGoleadores(20);

                // Limpiar filas
                dataGridViewGoleadores.Rows.Clear();

                // Agregar cada goleador con su escudo
                foreach (var goleador in goleadores)
                {
                    int rowIndex = dataGridViewGoleadores.Rows.Add();
                    DataGridViewRow row = dataGridViewGoleadores.Rows[rowIndex];

                    // Datos del goleador
                    row.Cells["Posicion"].Value = goleador.Posicion;
                    row.Cells["Jugador"].Value = goleador.NombreCompleto;
                    row.Cells["Equipo"].Value = goleador.NombreEquipo;
                    row.Cells["Goles"].Value = goleador.TotalGoles;
                    row.Cells["Asistencias"].Value = goleador.TotalAsistencias;
                    row.Cells["Partidos"].Value = goleador.PartidosJugados;
                    row.Cells["Promedio"].Value = goleador.PromedioGoles;
                    row.Cells["UrlEscudo"].Value = goleador.EscudoEquipo;

                    // ⭐ Cargar imagen del escudo
                    row.Cells["Escudo"].Value = CargarImagenEscudo(goleador.EscudoEquipo);

                    // ⭐ Colorear el PODIO (1°, 2°, 3°)
                    if (goleador.Posicion == 1)
                    {
                        // 🥇 ORO
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 215, 0);
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (goleador.Posicion == 2)
                    {
                        // 🥈 PLATA
                        row.DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                    else if (goleador.Posicion == 3)
                    {
                        // 🥉 BRONCE
                        row.DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50);
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                }

                // Actualizar contador
                lblTotal.Text = $"Total Goleadores: {goleadores.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar goleadores: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga una imagen del escudo desde URL
        /// </summary>
        /// <summary>
        /// Carga una imagen del escudo desde URL
        /// </summary>
        private Image CargarImagenEscudo(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                    return null; // Sin escudo

                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                return null; // Si falla la descarga, sin escudo
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGoleadores();
            MessageBox.Show("Datos actualizados correctamente",
                           "Información",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}