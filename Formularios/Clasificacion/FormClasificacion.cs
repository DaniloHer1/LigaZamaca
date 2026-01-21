using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;

namespace LigaZamaca.Formularios.Clasificacion
{
    public partial class FormClasificacion : Form
    {
        private ClasificacionDAO clasificacionDAO;

        public FormClasificacion()
        {
            InitializeComponent();
            clasificacionDAO = new ClasificacionDAO();
        }

        private void FormClasificacion_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarClasificacion();
        }

        /// <summary>
        /// Configura las columnas del DataGridView
        /// </summary>
        private void ConfigurarDataGridView()
        {
            dataGridViewClasificacion.AutoGenerateColumns = false;
            dataGridViewClasificacion.Columns.Clear();
            dataGridViewClasificacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClasificacion.MultiSelect = false;
            dataGridViewClasificacion.ReadOnly = true;
            dataGridViewClasificacion.RowTemplate.Height = 50; // Altura para mostrar escudos

            // Columna Posición
            DataGridViewTextBoxColumn colPosicion = new DataGridViewTextBoxColumn();
            colPosicion.Name = "Posicion";
            colPosicion.HeaderText = "Pos";
            colPosicion.DataPropertyName = "Posicion";
            colPosicion.Width = 50;
            colPosicion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPosicion.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewClasificacion.Columns.Add(colPosicion);

            // Columna Escudo (Imagen)
            DataGridViewImageColumn colEscudo = new DataGridViewImageColumn();
            colEscudo.Name = "Escudo";
            colEscudo.HeaderText = "";
            colEscudo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEscudo.Width = 60;
            dataGridViewClasificacion.Columns.Add(colEscudo);

            // Columna Equipo
            DataGridViewTextBoxColumn colEquipo = new DataGridViewTextBoxColumn();
            colEquipo.Name = "Equipo";
            colEquipo.HeaderText = "Equipo";
            colEquipo.DataPropertyName = "Equipo";
            colEquipo.Width = 200;
            colEquipo.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewClasificacion.Columns.Add(colEquipo);

            // Columna PJ
            DataGridViewTextBoxColumn colPJ = new DataGridViewTextBoxColumn();
            colPJ.Name = "PJ";
            colPJ.HeaderText = "PJ";
            colPJ.DataPropertyName = "PJ";
            colPJ.Width = 50;
            colPJ.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClasificacion.Columns.Add(colPJ);

            // Columna PG
            DataGridViewTextBoxColumn colPG = new DataGridViewTextBoxColumn();
            colPG.Name = "PG";
            colPG.HeaderText = "PG";
            colPG.DataPropertyName = "PG";
            colPG.Width = 50;
            colPG.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClasificacion.Columns.Add(colPG);

            // Columna PE
            DataGridViewTextBoxColumn colPE = new DataGridViewTextBoxColumn();
            colPE.Name = "PE";
            colPE.HeaderText = "PE";
            colPE.DataPropertyName = "PE";
            colPE.Width = 50;
            colPE.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClasificacion.Columns.Add(colPE);

            // Columna PP
            DataGridViewTextBoxColumn colPP = new DataGridViewTextBoxColumn();
            colPP.Name = "PP";
            colPP.HeaderText = "PP";
            colPP.DataPropertyName = "PP";
            colPP.Width = 50;
            colPP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClasificacion.Columns.Add(colPP);

            // Columna GF
            DataGridViewTextBoxColumn colGF = new DataGridViewTextBoxColumn();
            colGF.Name = "GF";
            colGF.HeaderText = "GF";
            colGF.DataPropertyName = "GF";
            colGF.Width = 50;
            colGF.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClasificacion.Columns.Add(colGF);

            // Columna GC
            DataGridViewTextBoxColumn colGC = new DataGridViewTextBoxColumn();
            colGC.Name = "GC";
            colGC.HeaderText = "GC";
            colGC.DataPropertyName = "GC";
            colGC.Width = 50;
            colGC.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClasificacion.Columns.Add(colGC);

            // Columna DG
            DataGridViewTextBoxColumn colDG = new DataGridViewTextBoxColumn();
            colDG.Name = "DG";
            colDG.HeaderText = "DG";
            colDG.DataPropertyName = "DG";
            colDG.Width = 50;
            colDG.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClasificacion.Columns.Add(colDG);

            // Columna Puntos
            DataGridViewTextBoxColumn colPuntos = new DataGridViewTextBoxColumn();
            colPuntos.Name = "Puntos";
            colPuntos.HeaderText = "Pts";
            colPuntos.DataPropertyName = "Puntos";
            colPuntos.Width = 60;
            colPuntos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPuntos.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colPuntos.DefaultCellStyle.BackColor = Color.FromArgb(230, 247, 255);
            dataGridViewClasificacion.Columns.Add(colPuntos);

            // Columna URL Escudo (oculta)
            DataGridViewTextBoxColumn colUrlEscudo = new DataGridViewTextBoxColumn();
            colUrlEscudo.Name = "UrlEscudo";
            colUrlEscudo.DataPropertyName = "Escudo";
            colUrlEscudo.Visible = false;
            dataGridViewClasificacion.Columns.Add(colUrlEscudo);
        }

        /// <summary>
        /// Carga la clasificación en el DataGridView
        /// </summary>
        private void CargarClasificacion()
        {
            try
            {
                var clasificacion = clasificacionDAO.ObtenerClasificacion();

                // Limpiar filas
                dataGridViewClasificacion.Rows.Clear();

                // Agregar cada equipo con su escudo
                foreach (var equipo in clasificacion)
                {
                    int rowIndex = dataGridViewClasificacion.Rows.Add();
                    DataGridViewRow row = dataGridViewClasificacion.Rows[rowIndex];

                    // Datos del equipo
                    row.Cells["Posicion"].Value = equipo.Posicion;
                    row.Cells["Equipo"].Value = equipo.Equipo;
                    row.Cells["PJ"].Value = equipo.PJ;
                    row.Cells["PG"].Value = equipo.PG;
                    row.Cells["PE"].Value = equipo.PE;
                    row.Cells["PP"].Value = equipo.PP;
                    row.Cells["GF"].Value = equipo.GF;
                    row.Cells["GC"].Value = equipo.GC;
                    row.Cells["DG"].Value = equipo.DG;
                    row.Cells["Puntos"].Value = equipo.Puntos;
                    row.Cells["UrlEscudo"].Value = equipo.Escudo;

                    // ⭐ Cargar imagen del escudo
                    row.Cells["Escudo"].Value = CargarImagenEscudo(equipo.Escudo);

                    // ⭐ Colorear las primeras 3 posiciones (Champions League)
                    if (equipo.Posicion <= 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201); // Verde claro
                    }
                    // ⭐ Colorear las últimas 3 posiciones (Descenso)
                    else if (equipo.Posicion > clasificacion.Count - 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210); // Rojo claro
                    }
                }

                lblTotal.Text = $"Total Equipos: {clasificacion.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clasificación: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga la imagen del escudo desde URL o muestra imagen por defecto
        /// </summary>
        private Image CargarImagenEscudo(string urlEscudo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(urlEscudo))
                {
                    return ObtenerImagenPorDefecto();
                }

                // Si es una URL web
                if (urlEscudo.StartsWith("http://") || urlEscudo.StartsWith("https://"))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(urlEscudo);
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
                // Si es una ruta local
                else if (File.Exists(urlEscudo))
                {
                    return Image.FromFile(urlEscudo);
                }
                else
                {
                    return ObtenerImagenPorDefecto();
                }
            }
            catch
            {
                return ObtenerImagenPorDefecto();
            }
        }

        /// <summary>
        /// Obtiene una imagen por defecto cuando no hay escudo
        /// </summary>
        private Image ObtenerImagenPorDefecto()
        {
            Bitmap bmp = new Bitmap(50, 50);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.DrawString("?", new Font("Arial", 20, FontStyle.Bold), Brushes.White, 10, 10);
            }
            return bmp;
        }

        /// <summary>
        /// Botón Actualizar
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarClasificacion();
            MessageBox.Show("Clasificación actualizada correctamente",
                          "Actualizado",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        /// <summary>
        /// Botón Cerrar
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}