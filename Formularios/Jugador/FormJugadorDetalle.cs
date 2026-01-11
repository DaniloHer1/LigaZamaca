using System;
using System.Windows.Forms;
using LigaZamaca.Modelos;
using LigaZamaca.AccesoDatos;

namespace LigaZamaca.Formularios.Jugador
{
    public partial class FormJugadorDetalle : Form
    {
        private JugadorDAO jugadorDao;
        private EquipoDAO equipoDao;
        private int idJugador = 0;
        private bool modoEdicion = false;

        /// <summary>
        /// Constructor para AÑADIR un jugador nuevo
        /// </summary>
        public FormJugadorDetalle()
        {
            InitializeComponent();
            jugadorDao = new JugadorDAO();
            equipoDao = new EquipoDAO();
            modoEdicion = false;
            this.Text = "Añadir Jugador";
        }

        /// <summary>
        /// Constructor para EDITAR un jugador existente
        /// </summary>
        public FormJugadorDetalle(int idJugador)
        {
            InitializeComponent();
            jugadorDao = new JugadorDAO();
            equipoDao = new EquipoDAO();
            this.idJugador = idJugador;
            modoEdicion = true;
            this.Text = "Modificar Jugador";
        }

        private void FormJugadorDetalle_Load(object sender, EventArgs e)
        {
            CargarEquipos();
            CargarPosiciones();

            if (modoEdicion)
            {
                CargarDatosJugador();
            }
            else
            {
                // Valores por defecto para nuevo jugador
                dtpFechaNacimiento.Value = DateTime.Now.AddYears(-25);
                chkActivo.Checked = true;
            }
        }

        /// <summary>
        /// Carga los equipos en el ComboBox
        /// </summary>
        private void CargarEquipos()
        {
            try
            {
                var equipos = equipoDao.ObtenerTodos();

                cmbEquipo.DataSource = equipos;
                cmbEquipo.DisplayMember = "Nombre";
                cmbEquipo.ValueMember = "IdEquipo";
                cmbEquipo.SelectedIndex = -1; // Sin selección por defecto
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
        /// Carga las posiciones en el ComboBox
        /// </summary>
        private void CargarPosiciones()
        {
            cmbPosicion.Items.Clear();
            cmbPosicion.Items.Add("Portero");
            cmbPosicion.Items.Add("Defensa");
            cmbPosicion.Items.Add("Centrocampista");
            cmbPosicion.Items.Add("Delantero");
            cmbPosicion.SelectedIndex = -1; // Sin selección por defecto
        }

        /// <summary>
        /// Carga los datos del jugador en modo edición
        /// </summary>
        private void CargarDatosJugador()
        {
            try
            {
                LigaZamaca.Modelos.Jugador jugador = jugadorDao.ObtenerPorId(idJugador);

                if (jugador != null)
                {
                    txtNombre.Text = jugador.Nombre;
                    txtApellidos.Text = jugador.Apellidos;
                    txtNacionalidad.Text = jugador.Nacionalidad ?? "";

                    if (jugador.FechaNacimiento.HasValue)
                        dtpFechaNacimiento.Value = jugador.FechaNacimiento.Value;

                    if (jugador.Altura.HasValue)
                        numAltura.Value = jugador.Altura.Value;

                    if (jugador.Peso.HasValue)
                        numPeso.Value = jugador.Peso.Value;

                    cmbPosicion.Text = jugador.Posicion;

                    if (jugador.Dorsal.HasValue)
                        numDorsal.Value = jugador.Dorsal.Value;

                    chkActivo.Checked = jugador.Activo;

                    // Seleccionar equipo
                    if (jugador.IdEquipo.HasValue)
                        cmbEquipo.SelectedValue = jugador.IdEquipo.Value;
                }
                else
                {
                    MessageBox.Show("No se encontró el jugador", "Error",
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

            // Validar Apellidos (obligatorio)
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Los apellidos son obligatorios");
                valido = false;
            }

            // Validar Equipo (obligatorio)
            if (cmbEquipo.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbEquipo, "Debes seleccionar un equipo");
                valido = false;
            }

            // Validar Posición (obligatoria)
            if (cmbPosicion.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbPosicion, "Debes seleccionar una posición");
                valido = false;
            }

            // Validar Dorsal (obligatorio)
            if (numDorsal.Value == 0)
            {
                errorProvider.SetError(numDorsal, "El dorsal debe ser mayor a 0");
                valido = false;
            }

            // Validar dorsal único por equipo
            if (cmbEquipo.SelectedIndex != -1 && numDorsal.Value > 0)
            {
                int idEquipo = (int)cmbEquipo.SelectedValue;
                int dorsal = (int)numDorsal.Value;

                if (jugadorDao.ExisteDorsal(idEquipo, dorsal, idJugador))
                {
                    errorProvider.SetError(numDorsal,
                        $"Ya existe un jugador con el dorsal {dorsal} en este equipo");
                    valido = false;
                }
            }

            // Validar Fecha de Nacimiento (debe ser mayor de 16 años)
            if (dtpFechaNacimiento.Value > DateTime.Now.AddYears(-16))
            {
                errorProvider.SetError(dtpFechaNacimiento,
                    "El jugador debe tener al menos 16 años");
                valido = false;
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
                // Crear objeto Jugador con los datos del formulario
                LigaZamaca.Modelos.Jugador jugador = new LigaZamaca.Modelos.Jugador
                {
                    IdJugador = this.idJugador,
                    Nombre = txtNombre.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Nacionalidad = string.IsNullOrWhiteSpace(txtNacionalidad.Text) ?
                                   null : txtNacionalidad.Text.Trim(),
                    FechaNacimiento = dtpFechaNacimiento.Checked ?
                                     (DateTime?)dtpFechaNacimiento.Value : null,
                    Altura = numAltura.Value > 0 ? (decimal?)numAltura.Value : null,
                    Peso = numPeso.Value > 0 ? (decimal?)numPeso.Value : null,
                    Posicion = cmbPosicion.Text,
                    Dorsal = (int)numDorsal.Value,
                    IdEquipo = (int)cmbEquipo.SelectedValue,
                    Activo = chkActivo.Checked
                };

                bool exito;

                if (modoEdicion)
                {
                    // Actualizar jugador existente
                    exito = jugadorDao.Actualizar(jugador);
                }
                else
                {
                    // Insertar nuevo jugador
                    int idGenerado = jugadorDao.Insertar(jugador);
                    exito = idGenerado > 0;
                }

                if (exito)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el jugador",
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

        /// <summary>
        /// Calcular edad automáticamente al cambiar fecha
        /// </summary>
        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Checked)
            {
                int edad = DateTime.Now.Year - dtpFechaNacimiento.Value.Year;

                // Ajustar si no ha cumplido años este año
                if (DateTime.Now < dtpFechaNacimiento.Value.AddYears(edad))
                    edad--;

                lblEdad.Text = $"Edad: {edad} años";
            }
            else
            {
                lblEdad.Text = "Edad: --";
            }
        }


    }
}