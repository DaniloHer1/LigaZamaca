using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using LigaZamaca.Modelos;
using LigaZamaca.AccesoDatos;

namespace LigaZamaca.Formularios
{
    public partial class FormEquipos : Form
    {
        private EquipoDAO equipoDao;
        private int idEquipoSeleccionado = 0;

        public FormEquipos()
        {
            InitializeComponent();
            equipoDao = new EquipoDAO();
        }

        private void FormEquipos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarEquipos();
        }

        /// <summary>
        /// Configura las columnas del DataGridView CON IMÁGENES
        /// </summary>
        private void ConfigurarDataGridView()
        {
            // Limpiar columnas automáticas
            dataGridViewEquipos.AutoGenerateColumns = false;
            dataGridViewEquipos.Columns.Clear();

            // Configurar selección
            dataGridViewEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEquipos.MultiSelect = false;
            dataGridViewEquipos.ReadOnly = true;
            dataGridViewEquipos.RowTemplate.Height = 60; // ⭐ Altura para las imágenes

            // Ocultar columna de ID (pero mantenerla para usarla)
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdEquipo";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "IdEquipo";
            colId.Visible = false;
            dataGridViewEquipos.Columns.Add(colId);

            // ⭐ Columna ESCUDO (Imagen pequeña)
            DataGridViewImageColumn colEscudo = new DataGridViewImageColumn();
            colEscudo.Name = "Escudo";
            colEscudo.HeaderText = "Logo";
            colEscudo.Width = 70;
            colEscudo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewEquipos.Columns.Add(colEscudo);

            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.Width = 180;
            dataGridViewEquipos.Columns.Add(colNombre);

            // Columna Estadio
            DataGridViewTextBoxColumn colEstadio = new DataGridViewTextBoxColumn();
            colEstadio.Name = "Estadio";
            colEstadio.HeaderText = "Estadio";
            colEstadio.DataPropertyName = "Estadio";
            colEstadio.Width = 150;
            dataGridViewEquipos.Columns.Add(colEstadio);

            // Columna Ciudad
            DataGridViewTextBoxColumn colCiudad = new DataGridViewTextBoxColumn();
            colCiudad.Name = "Ciudad";
            colCiudad.HeaderText = "Ciudad";
            colCiudad.DataPropertyName = "Ciudad";
            colCiudad.Width = 120;
            dataGridViewEquipos.Columns.Add(colCiudad);

            // Columna Entrenador
            DataGridViewTextBoxColumn colEntrenador = new DataGridViewTextBoxColumn();
            colEntrenador.Name = "Entrenador";
            colEntrenador.HeaderText = "Entrenador";
            colEntrenador.DataPropertyName = "Entrenador";
            colEntrenador.Width = 150;
            dataGridViewEquipos.Columns.Add(colEntrenador);

            // Columna URL Escudo (OCULTA)
            DataGridViewTextBoxColumn colUrlEscudo = new DataGridViewTextBoxColumn();
            colUrlEscudo.Name = "UrlEscudo";
            colUrlEscudo.HeaderText = "URL";
            colUrlEscudo.DataPropertyName = "Escudo";
            colUrlEscudo.Visible = false;
            dataGridViewEquipos.Columns.Add(colUrlEscudo);
        }

        /// <summary>
        /// Carga todos los equipos en el DataGridView CON IMÁGENES
        /// </summary>
        private void CargarEquipos()
        {
            try
            {
                var equipos = equipoDao.ObtenerTodos();

                // Limpiar DataGridView
                dataGridViewEquipos.Rows.Clear();

                // Agregar cada equipo con su imagen
                foreach (var equipo in equipos)
                {
                    int rowIndex = dataGridViewEquipos.Rows.Add();
                    DataGridViewRow row = dataGridViewEquipos.Rows[rowIndex];

                    // Datos del equipo
                    row.Cells["IdEquipo"].Value = equipo.IdEquipo;
                    row.Cells["Nombre"].Value = equipo.Nombre;
                    row.Cells["Estadio"].Value = equipo.Estadio;
                    row.Cells["Ciudad"].Value = equipo.Ciudad;
                    row.Cells["Entrenador"].Value = equipo.Entrenador;
                    row.Cells["UrlEscudo"].Value = equipo.Escudo;

                    // ⭐ Cargar imagen del escudo
                    row.Cells["Escudo"].Value = CargarImagenEscudo(equipo.Escudo);
                }

                // Actualizar contador
                lblTotal.Text = $"Total equipos: {equipos.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos: {ex.Message}",
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
                        using (var ms = new System.IO.MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
                // Si es una ruta local
                else if (System.IO.File.Exists(urlEscudo))
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
        /// Genera una imagen por defecto (escudo genérico)
        /// </summary>
        private Image ObtenerImagenPorDefecto()
        {
            // Crear una imagen simple con las iniciales "FC"
            Bitmap bmp = new Bitmap(50, 50);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Fondo azul
                g.FillEllipse(new SolidBrush(Color.FromArgb(0, 122, 204)), 0, 0, 50, 50);

                // Borde blanco
                g.DrawEllipse(new Pen(Color.White, 3), 3, 3, 44, 44);

                // Texto "FC"
                Font font = new Font("Arial", 14, FontStyle.Bold);
                SizeF textSize = g.MeasureString("FC", font);
                g.DrawString("FC", font, Brushes.White,
                            (50 - textSize.Width) / 2,
                            (50 - textSize.Height) / 2);
            }
            return bmp;
        }

        /// <summary>
        /// Evento de selección cambiada - Muestra escudo grande
        /// </summary>
        private void dataGridViewEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count > 0)
            {
                btnModificarEquipo.Enabled = true;
                btnEliminar.Enabled = true;

                // ⭐ Mostrar escudo grande en PictureBox
                string urlEscudo = dataGridViewEquipos.SelectedRows[0].Cells["UrlEscudo"].Value?.ToString();
                MostrarEscudoGrande(urlEscudo);
            }
            else
            {
                btnModificarEquipo.Enabled = false;
                btnEliminar.Enabled = false;

                // Limpiar PictureBox
                if (pictureBoxEscudo != null)
                {
                    pictureBoxEscudo.Image = null;
                }
            }
        }

        /// <summary>
        /// Muestra el escudo en grande en el PictureBox
        /// </summary>
        private void MostrarEscudoGrande(string urlEscudo)
        {
            try
            {
                if (pictureBoxEscudo != null)
                {
                    pictureBoxEscudo.Image = CargarImagenEscudo(urlEscudo);
                }
            }
            catch (Exception ex)
            {
                // Error silencioso - solo muestra imagen por defecto
                if (pictureBoxEscudo != null)
                {
                    pictureBoxEscudo.Image = ObtenerImagenPorDefecto();
                }
            }
        }

        /// <summary>
        /// Botón Añadir Equipo
        /// </summary>
        private void btnAñadirEquipo_Click(object sender, EventArgs e)
        {
            FormEquipoDetalle formDetalle = new FormEquipoDetalle();

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarEquipos(); // Recargar la lista
                MessageBox.Show("Equipo añadido correctamente",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Botón Modificar Equipo
        /// </summary>
        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un equipo para modificar",
                               "Aviso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del equipo seleccionado
            int idEquipo = Convert.ToInt32(dataGridViewEquipos.SelectedRows[0].Cells["IdEquipo"].Value);

            // Abrir formulario de detalle en modo edición
            FormEquipoDetalle formDetalle = new FormEquipoDetalle(idEquipo);

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarEquipos(); // Recargar la lista
                MessageBox.Show("Equipo modificado correctamente",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Botón Eliminar Equipo
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un equipo para eliminar",
                               "Aviso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del equipo seleccionado
            int idEquipo = Convert.ToInt32(dataGridViewEquipos.SelectedRows[0].Cells["IdEquipo"].Value);
            string nombreEquipo = dataGridViewEquipos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            // Confirmar eliminación
            DialogResult resultado = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el equipo '{nombreEquipo}'?\n\n" +
                "ADVERTENCIA: También se eliminarán todos los jugadores, partidos y estadísticas relacionadas.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = equipoDao.Eliminar(idEquipo);

                    if (eliminado)
                    {
                        CargarEquipos(); // Recargar la lista
                        MessageBox.Show("Equipo eliminado correctamente",
                                       "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el equipo",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar equipo: {ex.Message}\n\n" +
                                   "El equipo puede tener jugadores o partidos asociados.",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Doble clic en una fila para editar
        /// </summary>
        private void dataGridViewEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificarEquipo_Click(sender, e);
            }
        }
    }
}