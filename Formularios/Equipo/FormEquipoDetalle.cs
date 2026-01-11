using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LigaZamaca.Modelos;
using LigaZamaca.AccesoDatos;

namespace LigaZamaca.Formularios
{
    public partial class FormEquipoDetalle : Form
    {
        private EquipoDAO equipoDao;
        private int idEquipo = 0;
        private bool modoEdicion = false;
        private string rutaImagenSeleccionada = null;

        /// <summary>
        /// Constructor para AÑADIR un equipo nuevo
        /// </summary>
        public FormEquipoDetalle()
        {
            InitializeComponent();
            equipoDao = new EquipoDAO();
            modoEdicion = false;
            this.Text = "Añadir Equipo";
        }

        /// <summary>
        /// Constructor para EDITAR un equipo existente
        /// </summary>
        public FormEquipoDetalle(int idEquipo)
        {
            InitializeComponent();
            equipoDao = new EquipoDAO();
            this.idEquipo = idEquipo;
            modoEdicion = true;
            this.Text = "Modificar Equipo";
        }

        private void FormEquipoDetalle_Load(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                CargarDatosEquipo();
            }
            else
            {
                // Valores por defecto para nuevo equipo
                dtpFechaFundacion.Value = DateTime.Now.AddYears(-100);
                MostrarImagenPorDefecto();
            }
        }

        /// <summary>
        /// Carga los datos del equipo en modo edición
        /// </summary>
        private void CargarDatosEquipo()
        {
            try
            {
                Equipo equipo = equipoDao.ObtenerPorId(idEquipo);

                if (equipo != null)
                {
                    txtNombre.Text = equipo.Nombre;
                    txtEstadio.Text = equipo.Estadio;
                    txtCiudad.Text = equipo.Ciudad;
                    txtEntrenador.Text = equipo.Entrenador ?? "";
                    txtEmail.Text = equipo.Email ?? "";
                    txtTelefono.Text = equipo.Telefono ?? "";
                    txtEscudo.Text = equipo.Escudo ?? "";

                    if (equipo.FechaFundacion.HasValue)
                        dtpFechaFundacion.Value = equipo.FechaFundacion.Value;

                    if (equipo.Presupuesto.HasValue)
                        numPresupuesto.Value = equipo.Presupuesto.Value;

                    // Cargar imagen del escudo
                    CargarImagenEscudo(equipo.Escudo);
                }
                else
                {
                    MessageBox.Show("No se encontró el equipo", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// Carga la imagen del escudo desde URL o archivo local
        /// </summary>
        private void CargarImagenEscudo(string ruta)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ruta))
                {
                    MostrarImagenPorDefecto();
                    return;
                }

                // Si es una URL web
                if (ruta.StartsWith("http://") || ruta.StartsWith("https://"))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(ruta);
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            pictureBoxEscudo.Image = Image.FromStream(ms);
                        }
                    }
                }
                // Si es una ruta local
                else if (File.Exists(ruta))
                {
                    pictureBoxEscudo.Image = Image.FromFile(ruta);
                }
                else
                {
                    MostrarImagenPorDefecto();
                }
            }
            catch
            {
                MostrarImagenPorDefecto();
            }
        }

        /// <summary>
        /// Muestra una imagen por defecto
        /// </summary>
        private void MostrarImagenPorDefecto()
        {
            Bitmap bmp = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Fondo azul
                g.FillEllipse(new SolidBrush(Color.FromArgb(0, 122, 204)), 0, 0, 150, 150);

                // Borde blanco
                g.DrawEllipse(new Pen(Color.White, 5), 5, 5, 140, 140);

                // Texto "FC"
                Font font = new Font("Arial", 40, FontStyle.Bold);
                SizeF textSize = g.MeasureString("FC", font);
                g.DrawString("FC", font, Brushes.White,
                            (150 - textSize.Width) / 2,
                            (150 - textSize.Height) / 2);
            }
            pictureBoxEscudo.Image = bmp;
        }

        /// <summary>
        /// Botón para examinar y seleccionar imagen
        /// </summary>
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar escudo del equipo";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cargar imagen en el PictureBox
                        pictureBoxEscudo.Image = Image.FromFile(openFileDialog.FileName);

                        // Guardar la ruta seleccionada
                        rutaImagenSeleccionada = openFileDialog.FileName;

                        // Actualizar el TextBox
                        txtEscudo.Text = rutaImagenSeleccionada;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Botón para copiar imagen a carpeta del proyecto
        /// </summary>
        private void btnCopiarProyecto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rutaImagenSeleccionada))
            {
                MessageBox.Show("Primero selecciona una imagen usando el botón Examinar",
                               "Aviso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear carpeta para escudos si no existe
                string carpetaEscudos = Path.Combine(Application.StartupPath, "Escudos");
                if (!Directory.Exists(carpetaEscudos))
                {
                    Directory.CreateDirectory(carpetaEscudos);
                }

                // Generar nombre único para la imagen
                string extension = Path.GetExtension(rutaImagenSeleccionada);
                string nombreEquipo = string.IsNullOrWhiteSpace(txtNombre.Text) ?
                                     "equipo" : txtNombre.Text.Replace(" ", "_");
                string nombreArchivo = $"{nombreEquipo}_{DateTime.Now.Ticks}{extension}";
                string rutaDestino = Path.Combine(carpetaEscudos, nombreArchivo);

                // Copiar archivo
                File.Copy(rutaImagenSeleccionada, rutaDestino, true);

                // Actualizar referencia
                rutaImagenSeleccionada = rutaDestino;
                txtEscudo.Text = rutaDestino;

                MessageBox.Show("Imagen copiada al proyecto correctamente",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al copiar imagen: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento cuando cambia el texto del TextBox de escudo (para URLs)
        /// </summary>
        private void txtEscudo_TextChanged(object sender, EventArgs e)
        {
            // Si es una URL, intentar cargarla
            if (txtEscudo.Text.StartsWith("http://") || txtEscudo.Text.StartsWith("https://"))
            {
                CargarImagenEscudo(txtEscudo.Text);
            }
        }

        /// <summary>
        /// Valida los datos del formulario
        /// </summary>
        private bool ValidarFormulario()
        {
            // Limpiar errores previos
            errorProvider.Clear();

            bool valido = true;

            // Validar Nombre (obligatorio)
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio");
                valido = false;
            }

            // Validar Estadio (obligatorio)
            if (string.IsNullOrWhiteSpace(txtEstadio.Text))
            {
                errorProvider.SetError(txtEstadio, "El estadio es obligatorio");
                valido = false;
            }

            // Validar Ciudad (obligatoria)
            if (string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                errorProvider.SetError(txtCiudad, "La ciudad es obligatoria");
                valido = false;
            }

            // Validar nombre único (solo al añadir o si cambió el nombre)
            if (!modoEdicion || txtNombre.Text != equipoDao.ObtenerPorId(idEquipo)?.Nombre)
            {
                if (equipoDao.ExisteEquipo(txtNombre.Text, idEquipo))
                {
                    errorProvider.SetError(txtNombre, "Ya existe un equipo con este nombre");
                    valido = false;
                }
            }

            return valido;
        }

        /// <summary>
        /// Botón Guardar
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Por favor, corrige los errores antes de guardar",
                               "Validación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear objeto Equipo con los datos del formulario
                Equipo equipo = new Equipo
                {
                    IdEquipo = this.idEquipo,
                    Nombre = txtNombre.Text.Trim(),
                    Estadio = txtEstadio.Text.Trim(),
                    Ciudad = txtCiudad.Text.Trim(),
                    Entrenador = string.IsNullOrWhiteSpace(txtEntrenador.Text) ? null : txtEntrenador.Text.Trim(),
                    Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                    Escudo = string.IsNullOrWhiteSpace(txtEscudo.Text) ? null : txtEscudo.Text.Trim(),
                    FechaFundacion = dtpFechaFundacion.Checked ? (DateTime?)dtpFechaFundacion.Value : null,
                    Presupuesto = numPresupuesto.Value > 0 ? (decimal?)numPresupuesto.Value : null
                };

                bool exito;

                if (modoEdicion)
                {
                    // Actualizar equipo existente
                    exito = equipoDao.Actualizar(equipo);
                }
                else
                {
                    // Insertar nuevo equipo
                    int idGenerado = equipoDao.Insertar(equipo);
                    exito = idGenerado > 0;
                }

                if (exito)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el equipo",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón Cancelar
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}