using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;
using System;
using System.Windows.Forms;

namespace LigaZamaca.Formularios.Partido
{
    public partial class FormPartidos : Form
    {
        private PartidoDAO partidoDAO;
        private int idPartidoSeleccionado = 0;

        public FormPartidos()
        {
            InitializeComponent();
            partidoDAO = new PartidoDAO();
        }

        /// <summary>
        /// Evento Load del formulario
        /// </summary>
        private void FormPartidos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarPartidos();
        }

        /// <summary>
        /// Configura las columnas del DataGridView
        /// </summary>
        private void ConfigurarDataGridView()
        {
            // Limpiar Columnas
            dataGridViewPartidos.AutoGenerateColumns = false;
            dataGridViewPartidos.Columns.Clear();

            // Configurar Seleccion
            dataGridViewPartidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartidos.MultiSelect = false;
            dataGridViewPartidos.ReadOnly = true;

            // Columna ID (Oculta)
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "IdPartido";
            colID.HeaderText = "ID";
            colID.DataPropertyName = "IdPartido";
            colID.Visible = false;
            dataGridViewPartidos.Columns.Add(colID);

            // Columna Jornada
            DataGridViewTextBoxColumn colJornada = new DataGridViewTextBoxColumn();
            colJornada.Name = "Jornada";
            colJornada.HeaderText = "Jornada";
            colJornada.DataPropertyName = "Jornada";
            colJornada.Width = 80;
            dataGridViewPartidos.Columns.Add(colJornada);

            // Columna Fecha
            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "Fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.DataPropertyName = "Fecha";
            colFecha.DefaultCellStyle.Format = "dd/MM/yyyy";
            colFecha.Width = 100;
            dataGridViewPartidos.Columns.Add(colFecha);

            // Columna Equipo Local
            DataGridViewTextBoxColumn colEquipoLocal = new DataGridViewTextBoxColumn();
            colEquipoLocal.Name = "NombreEquipoLocal";
            colEquipoLocal.HeaderText = "Equipo Local";
            colEquipoLocal.DataPropertyName = "NombreEquipoLocal";
            colEquipoLocal.Width = 180;
            dataGridViewPartidos.Columns.Add(colEquipoLocal);

            // Columna Resultado
            DataGridViewTextBoxColumn colResultado = new DataGridViewTextBoxColumn();
            colResultado.Name = "Resultado";
            colResultado.HeaderText = "Resultado";
            colResultado.DataPropertyName = "Resultado";
            colResultado.Width = 80;
            colResultado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPartidos.Columns.Add(colResultado);

            // Columna Equipo Visitante
            DataGridViewTextBoxColumn colEquipoVisitante = new DataGridViewTextBoxColumn();
            colEquipoVisitante.Name = "NombreEquipoVisitante";
            colEquipoVisitante.HeaderText = "Equipo Visitante";
            colEquipoVisitante.DataPropertyName = "NombreEquipoVisitante";
            colEquipoVisitante.Width = 180;
            dataGridViewPartidos.Columns.Add(colEquipoVisitante);

            // Columna Estadio
            DataGridViewTextBoxColumn colEstadio = new DataGridViewTextBoxColumn();
            colEstadio.Name = "Estadio";
            colEstadio.HeaderText = "Estadio";
            colEstadio.DataPropertyName = "Estadio";
            colEstadio.Width = 150;
            dataGridViewPartidos.Columns.Add(colEstadio);

            // Columna Estado
            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.DataPropertyName = "Estado";
            colEstado.Width = 120;
            dataGridViewPartidos.Columns.Add(colEstado);
        }

        /// <summary>
        /// Carga todos los partidos en el DataGridView
        /// </summary>
        private void CargarPartidos()
        {
            try
            {
                var partidos = partidoDAO.ObtenerTodos();
                dataGridViewPartidos.DataSource = partidos;

                lblTotal.Text = $"Total Partidos: {partidos.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar partidos: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón Añadir Partido
        /// </summary>
        private void btnAñadirPartido_Click(object sender, EventArgs e)
        {
            FormPartidoDetalle formDetalle = new FormPartidoDetalle();

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarPartidos();
                MessageBox.Show("Partido añadido correctamente",
                              "Éxito",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Botón Modificar Partido
        /// </summary>
        private void btnModificarPartido_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un partido para modificar",
                               "Aviso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del partido seleccionado
            int idPartido = Convert.ToInt32(dataGridViewPartidos.SelectedRows[0].Cells["IdPartido"].Value);

            // Abrir formulario de detalle en modo edición
            FormPartidoDetalle formDetalle = new FormPartidoDetalle(idPartido);

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarPartidos();
                MessageBox.Show("Partido modificado correctamente",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Botón Eliminar Partido
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un partido para eliminar",
                               "Aviso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del partido seleccionado
            int idPartido = Convert.ToInt32(dataGridViewPartidos.SelectedRows[0].Cells["IdPartido"].Value);
            string equipoLocal = dataGridViewPartidos.SelectedRows[0].Cells["NombreEquipoLocal"].Value.ToString();
            string equipoVisitante = dataGridViewPartidos.SelectedRows[0].Cells["NombreEquipoVisitante"].Value.ToString();

            // Confirmar eliminación
            DialogResult resultado = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el partido:\n{equipoLocal} vs {equipoVisitante}?\n\n" +
                "ADVERTENCIA: También se eliminarán todas las estadísticas relacionadas.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = partidoDAO.Eliminar(idPartido);

                    if (eliminado)
                    {
                        CargarPartidos();
                        MessageBox.Show("Partido eliminado correctamente",
                                       "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el partido",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar partido: {ex.Message}",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Evento cuando cambia la selección del DataGridView
        /// </summary>
        private void dataGridViewPartidos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPartidos.SelectedRows.Count > 0)
            {
                idPartidoSeleccionado = Convert.ToInt32(dataGridViewPartidos.SelectedRows[0].Cells["IdPartido"].Value);
                btnModificarPartido.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                idPartidoSeleccionado = 0;
                btnModificarPartido.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        /// <summary>
        /// Evento doble click en una fila del DataGridView
        /// </summary>
        private void dataGridViewPartidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificarPartido_Click(sender, e);
            }
        }
    }
}