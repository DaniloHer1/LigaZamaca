using System;
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