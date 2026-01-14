using System;
using System.Windows.Forms;
using LigaZamaca.Modelos;
using LigaZamaca.AccesoDatos;

namespace LigaZamaca.Formularios.Partido
{
    public partial class FormPartidoDetalle : Form
    {
        private PartidoDAO partidoDAO;
        private EquipoDAO equipoDAO;
        private int idPartido = 0;
        private bool modoEdicion = false;

        /// <summary>
        /// Constructor para AÑADIR un partido nuevo
        /// </summary>
        public FormPartidoDetalle()
        {
            InitializeComponent();
            partidoDAO = new PartidoDAO();
            equipoDAO = new EquipoDAO();
            modoEdicion = false;
            this.Text = "Añadir Partido";
        }

        /// <summary>
        /// Constructor para EDITAR un partido existente
        /// </summary>
        public FormPartidoDetalle(int idPartido)
        {
            InitializeComponent();
            partidoDAO = new PartidoDAO();
            equipoDAO = new EquipoDAO();
            this.idPartido = idPartido;
            modoEdicion = true;
            this.Text = "Modificar Partido";
        }

        private void FormPartidoDetalle_Load(object sender, EventArgs e)
        {
            CargarEquipos();
            CargarEstados();

            if (modoEdicion)
            {
                CargarDatosPartido();
            }
            else
            {
                // Valores por defecto para nuevo partido
                dtpFecha.Value = DateTime.Now.AddDays(7); // Una semana adelante
                numJornada.Value = 1;
                cmbEstado.SelectedIndex = 0; // "Programado"
                numGolesLocal.Value = 0;
                numGolesVisitante.Value = 0;
                numAsistencia.Value = 0;
            }
        }

        /// <summary>
        /// Carga los equipos en ambos ComboBox
        /// </summary>
        private void CargarEquipos()
        {
            try
            {
                var equipos = equipoDAO.ObtenerTodos();

                // ComboBox Equipo Local
                cmbEquipoLocal.DataSource = new System.ComponentModel.BindingList<Equipo>(equipos);
                cmbEquipoLocal.DisplayMember = "Nombre";
                cmbEquipoLocal.ValueMember = "IdEquipo";
                cmbEquipoLocal.SelectedIndex = -1;

                // ComboBox Equipo Visitante (clonar la lista)
                var equiposVisitante = equipoDAO.ObtenerTodos();
                cmbEquipoVisitante.DataSource = new System.ComponentModel.BindingList<Equipo>(equiposVisitante);
                cmbEquipoVisitante.DisplayMember = "Nombre";
                cmbEquipoVisitante.ValueMember = "IdEquipo";
                cmbEquipoVisitante.SelectedIndex = -1;
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
        /// Carga los estados del partido en el ComboBox
        /// </summary>
        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Programado");
            cmbEstado.Items.Add("En Curso");
            cmbEstado.Items.Add("Finalizado");
            cmbEstado.Items.Add("Suspendido");
            cmbEstado.Items.Add("Aplazado");
            cmbEstado.SelectedIndex = 0; // Por defecto "Programado"
        }

        /// <summary>
        /// Carga los datos del partido en modo edición
        /// </summary>
        private void CargarDatosPartido()
        {
            try
            {
                LigaZamaca.Modelos.Partido partido = partidoDAO.ObtenerPorId(idPartido);

                if (partido != null)
                {
                    cmbEquipoLocal.SelectedValue = partido.IdEquipoLocal;
                    cmbEquipoVisitante.SelectedValue = partido.IdEquipoVisitante;
                    dtpFecha.Value = partido.FechaHora;
                    numJornada.Value = partido.Jornada;
                    txtEstadio.Text = partido.Estadio;
                    txtArbitro.Text = partido.Arbitro ?? "";
                    cmbEstado.Text = partido.Estado;
                    numGolesLocal.Value = partido.GolesLocal;
                    numGolesVisitante.Value = partido.GolesVisitante;

                    if (partido.Asistencia.HasValue)
                        numAsistencia.Value = partido.Asistencia.Value;
                }
                else
                {
                    MessageBox.Show("No se encontró el partido", "Error",
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
        /// Evento cuando cambia la selección del Equipo Local
        /// </summary>
        private void cmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipoLocal.SelectedValue != null && cmbEquipoLocal.SelectedValue is int)
            {
                int idEquipo = (int)cmbEquipoLocal.SelectedValue;
                Equipo equipo = equipoDAO.ObtenerPorId(idEquipo);

                // ⭐ Autocompletar el estadio con el del equipo local
                if (equipo != null && string.IsNullOrEmpty(txtEstadio.Text))
                {
                    txtEstadio.Text = equipo.Estadio;
                }
            }
        }

        /// <summary>
        /// Evento cuando cambia el estado del partido
        /// </summary>
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.Text;

            // ⭐ Habilitar/Deshabilitar campos de goles según el estado
            bool partidoJugado = (estado == "En Curso" || estado == "Finalizado");

            numGolesLocal.Enabled = partidoJugado;
            numGolesVisitante.Enabled = partidoJugado;
            lblGolesLocal.Enabled = partidoJugado;
            lblGolesVisitante.Enabled = partidoJugado;

            // Si el partido no está jugado, resetear goles a 0
            if (!partidoJugado)
            {
                numGolesLocal.Value = 0;
                numGolesVisitante.Value = 0;
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

            // Validar Equipo Local
            if (cmbEquipoLocal.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbEquipoLocal, "Debes seleccionar un equipo local");
                valido = false;
            }

            // Validar Equipo Visitante
            if (cmbEquipoVisitante.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbEquipoVisitante, "Debes seleccionar un equipo visitante");
                valido = false;
            }

            // ⭐ Validar que los equipos sean diferentes
            if (cmbEquipoLocal.SelectedIndex != -1 && cmbEquipoVisitante.SelectedIndex != -1)
            {
                if (cmbEquipoLocal.SelectedValue.Equals(cmbEquipoVisitante.SelectedValue))
                {
                    errorProvider.SetError(cmbEquipoVisitante, "Un equipo no puede jugar contra sí mismo");
                    valido = false;
                }
            }

            // Validar Estadio
            if (string.IsNullOrWhiteSpace(txtEstadio.Text))
            {
                errorProvider.SetError(txtEstadio, "El estadio es obligatorio");
                valido = false;
            }

            // Validar Estado
            if (cmbEstado.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbEstado, "Debes seleccionar un estado");
                valido = false;
            }

            // ⭐ Validar fecha para partidos programados
            if (cmbEstado.Text == "Programado" && dtpFecha.Value.Date < DateTime.Now.Date)
            {
                errorProvider.SetError(dtpFecha, "Un partido programado no puede tener fecha pasada");
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
                MessageBox.Show("Por favor, corrige los errores antes de continuar",
                               "Validación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear objeto Partido
                LigaZamaca.Modelos.Partido partido = new LigaZamaca.Modelos.Partido
                {
                    IdEquipoLocal = (int)cmbEquipoLocal.SelectedValue,
                    IdEquipoVisitante = (int)cmbEquipoVisitante.SelectedValue,
                    FechaHora = dtpFecha.Value,
                    Jornada = (int)numJornada.Value,
                    GolesLocal = (int)numGolesLocal.Value,
                    GolesVisitante = (int)numGolesVisitante.Value,
                    Estadio = txtEstadio.Text.Trim(),
                    Arbitro = string.IsNullOrWhiteSpace(txtArbitro.Text) ? null : txtArbitro.Text.Trim(),
                    Estado = cmbEstado.Text,
                    Asistencia = numAsistencia.Value > 0 ? (int?)numAsistencia.Value : null
                };

                if (modoEdicion)
                {
                    // Actualizar partido existente
                    partido.IdPartido = idPartido;
                    bool actualizado = partidoDAO.Actualizar(partido);

                    if (actualizado)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el partido",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Insertar nuevo partido
                    int idGenerado = partidoDAO.Insertar(partido);

                    if (idGenerado > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo añadir el partido",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el partido: {ex.Message}",
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