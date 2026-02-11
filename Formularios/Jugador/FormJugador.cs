using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaZamaca.Formularios.Jugador
{
    public partial class FormJugador : Form
    {
        private JugadorDAO jugadorDAO;
        private int idJugadorSeleccionado = 0;

        public FormJugador()
        {
            InitializeComponent();
            jugadorDAO = new JugadorDAO();
        }

        /// <summary>
        /// Evento Load del formulario
        /// </summary>
        private void FormJugador_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarJugadores();
        }

        /// <summary>
        /// Configura las columnas del DataGridView
        /// </summary>
        private void ConfigurarDataGridView()
        {
            // Limpiar Columnas
            dataGridViewJugador.AutoGenerateColumns = false;
            dataGridViewJugador.Columns.Clear();

            // Configurar Seleccion
            dataGridViewJugador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJugador.MultiSelect = false;
            dataGridViewJugador.ReadOnly = true;

            //  Columna ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "IdJugador";
            colID.HeaderText = "ID";
            colID.DataPropertyName = "IdJugador";
            colID.Visible = false;
            dataGridViewJugador.Columns.Add(colID);

            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.Width = 150;
            dataGridViewJugador.Columns.Add(colNombre);

            //  Columna Apellidos 
            DataGridViewTextBoxColumn colApellidos = new DataGridViewTextBoxColumn();
            colApellidos.Name = "Apellidos";
            colApellidos.HeaderText = "Apellidos";
            colApellidos.DataPropertyName = "Apellidos";  // ⭐ Plural
            colApellidos.Width = 150;
            dataGridViewJugador.Columns.Add(colApellidos);

            //  Columna Fecha Nacimiento 
            DataGridViewTextBoxColumn colFechaNacimiento = new DataGridViewTextBoxColumn();
            colFechaNacimiento.Name = "FechaNacimiento";
            colFechaNacimiento.HeaderText = "Fecha Nacimiento";
            colFechaNacimiento.DataPropertyName = "FechaNacimiento";
            colFechaNacimiento.DefaultCellStyle.Format = "dd/MM/yyyy";
            colFechaNacimiento.Width = 120;
            dataGridViewJugador.Columns.Add(colFechaNacimiento);

            //  Columna Posición 
            DataGridViewTextBoxColumn colPosicion = new DataGridViewTextBoxColumn();
            colPosicion.Name = "Posicion";
            colPosicion.HeaderText = "Posición";
            colPosicion.DataPropertyName = "Posicion";
            colPosicion.Width = 100;
            dataGridViewJugador.Columns.Add(colPosicion);

            //  Columna Dorsal
            DataGridViewTextBoxColumn colDorsal = new DataGridViewTextBoxColumn();
            colDorsal.Name = "Dorsal";
            colDorsal.HeaderText = "Dorsal";
            colDorsal.DataPropertyName = "Dorsal";
            colDorsal.Width = 70;
            dataGridViewJugador.Columns.Add(colDorsal);

            //  Columna Equipo (Nombre del equipo)
            DataGridViewTextBoxColumn colEquipo = new DataGridViewTextBoxColumn();
            colEquipo.Name = "NombreEquipo";
            colEquipo.HeaderText = "Equipo";
            colEquipo.DataPropertyName = "NombreEquipo";
            colEquipo.Width = 150;
            dataGridViewJugador.Columns.Add(colEquipo);
        }

        /// <summary>
        /// Carga todos los jugadores en el DataGridView
        /// </summary>
        private void CargarJugadores()
        {
            try
            {
                var jugadores = jugadorDAO.ObtenerTodos();
                dataGridViewJugador.DataSource = jugadores;

                lblTotal.Text = $"Total Jugadores: {jugadores.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar Jugadores: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón Añadir Jugador
        /// </summary>
        private void btnAñadirJugador_Click(object sender, EventArgs e)
        {
            FormJugadorDetalle formDetalle = new FormJugadorDetalle();

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarJugadores();
                MessageBox.Show("Jugador añadido correctamente",
                              "Éxito",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Botón Modificar Jugador
        /// </summary>
        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un Jugador para modificar",
                              "Aviso",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Obtener ID
            int idJugador = Convert.ToInt32(dataGridViewJugador.SelectedRows[0].Cells["IdJugador"].Value);

            // Abrir Form Detalle en modo edicion
            FormJugadorDetalle formDetalle = new FormJugadorDetalle(idJugador);

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarJugadores(); // Recargar la lista
                MessageBox.Show("Jugador modificado correctamente",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Botón Eliminar Jugador
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un Jugador para eliminar",
                             "Aviso",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del jugador seleccionado
            int idJugador = Convert.ToInt32(dataGridViewJugador.SelectedRows[0].Cells["IdJugador"].Value);
            string nombreJugador = dataGridViewJugador.SelectedRows[0].Cells["Nombre"].Value.ToString();

            DialogResult resultado = MessageBox.Show(
               $"¿Estás seguro de que deseas eliminar el jugador '{nombreJugador}'?\n\n" +
               "ADVERTENCIA: También se eliminarán todas las estadísticas relacionadas.",
               "Confirmar eliminación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = jugadorDAO.Eliminar(idJugador);

                    if (eliminado)
                    {
                        CargarJugadores(); // Recargar la lista
                        MessageBox.Show("Jugador eliminado correctamente",
                                       "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el jugador",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el jugador: {ex.Message}\n\n" +
                                   "El jugador puede tener estadísticas asociadas.",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Doble clic en una fila para editar
        /// </summary>
        private void dataGridViewJugador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificarJugador_Click(sender, e);
            }
        }

        /// <summary>
        /// Evento de selección cambiada
        /// </summary>
        private void dataGridViewJugador_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count > 0)
            {
                btnModificarJugador.Enabled = true;
                btnEliminar.Enabled = true;
                bool haySeleccion = dataGridViewJugador.SelectedRows.Count > 0;
                btnModificarJugador.Enabled = haySeleccion;
                btnEliminar.Enabled = haySeleccion;
                btnVerFicha.Enabled = haySeleccion;
            }
            else
            {
                btnModificarJugador.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        /// <summary>
        /// Botón Ver Ficha del jugador
        /// </summary>    
        private void btnVerFicha_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un jugador",
                               "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idJugador = Convert.ToInt32(dataGridViewJugador.SelectedRows[0].Cells["IdJugador"].Value);
            FormFichaJugador formFicha = new FormFichaJugador(idJugador);
            formFicha.ShowDialog();
        }
    }
}