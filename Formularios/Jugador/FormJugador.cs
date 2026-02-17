using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;

namespace LigaZamaca.Formularios.Jugador
{
    /// <summary>
    /// Formulario para la gestión de jugadores de la liga.
    /// Permite añadir, modificar, eliminar, buscar y filtrar jugadores.
    /// </summary>
    public partial class FormJugador : Form
    {
        private JugadorDAO jugadorDAO;
        private EquipoDAO equipoDAO;
        private int idJugadorSeleccionado = 0;
        private List<LigaZamaca.Modelos.Jugador> listaJugadoresCompleta;

        public FormJugador()
        {
            InitializeComponent();
            jugadorDAO = new JugadorDAO();
            equipoDAO = new EquipoDAO();
            listaJugadoresCompleta = new List<LigaZamaca.Modelos.Jugador>();
        }

        private void FormJugador_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            ConfigurarMenuContextual();
            ConfigurarFiltros();
            CargarJugadores();
        }

        #region Configuración del DataGridView

        private void ConfigurarDataGridView()
        {
            dataGridViewJugador.AutoGenerateColumns = false;
            dataGridViewJugador.Columns.Clear();
            dataGridViewJugador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJugador.MultiSelect = false;
            dataGridViewJugador.ReadOnly = true;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdJugador";
            colId.DataPropertyName = "IdJugador";
            colId.Visible = false;
            dataGridViewJugador.Columns.Add(colId);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.Width = 180;
            dataGridViewJugador.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colPosicion = new DataGridViewTextBoxColumn();
            colPosicion.Name = "Posicion";
            colPosicion.HeaderText = "Posición";
            colPosicion.DataPropertyName = "Posicion";
            colPosicion.Width = 100;
            dataGridViewJugador.Columns.Add(colPosicion);

            DataGridViewTextBoxColumn colDorsal = new DataGridViewTextBoxColumn();
            colDorsal.Name = "Dorsal";
            colDorsal.HeaderText = "Dorsal";
            colDorsal.DataPropertyName = "Dorsal";
            colDorsal.Width = 60;
            dataGridViewJugador.Columns.Add(colDorsal);

            DataGridViewTextBoxColumn colNacionalidad = new DataGridViewTextBoxColumn();
            colNacionalidad.Name = "Nacionalidad";
            colNacionalidad.HeaderText = "Nacionalidad";
            colNacionalidad.DataPropertyName = "Nacionalidad";
            colNacionalidad.Width = 100;
            dataGridViewJugador.Columns.Add(colNacionalidad);

            DataGridViewTextBoxColumn colFechaNac = new DataGridViewTextBoxColumn();
            colFechaNac.Name = "FechaNacimiento";
            colFechaNac.HeaderText = "F. Nacimiento";
            colFechaNac.DataPropertyName = "FechaNacimiento";
            colFechaNac.Width = 100;
            colFechaNac.DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewJugador.Columns.Add(colFechaNac);

            DataGridViewTextBoxColumn colEquipo = new DataGridViewTextBoxColumn();
            colEquipo.Name = "NombreEquipo";
            colEquipo.HeaderText = "Equipo";
            colEquipo.DataPropertyName = "NombreEquipo";
            colEquipo.Width = 150;
            dataGridViewJugador.Columns.Add(colEquipo);
        }

        #endregion

        #region Búsqueda y Filtros

        private void ConfigurarFiltros()
        {
            // Cargar equipos
            cmbFiltroEquipo.Items.Clear();
            cmbFiltroEquipo.Items.Add("-- Todos los equipos --");
            cmbFiltroEquipo.SelectedIndex = 0;

            // Cargar posiciones
            cmbFiltroPosicion.Items.Clear();
            cmbFiltroPosicion.Items.Add("-- Todas las posiciones --");
            cmbFiltroPosicion.Items.Add("Portero");
            cmbFiltroPosicion.Items.Add("Defensa");
            cmbFiltroPosicion.Items.Add("Centrocampista");
            cmbFiltroPosicion.Items.Add("Delantero");
            cmbFiltroPosicion.SelectedIndex = 0;

            // Placeholder búsqueda
            txtBusqueda.Text = "Buscar por nombre, nacionalidad...";
            txtBusqueda.ForeColor = Color.Gray;
        }

        private void CargarEquiposEnFiltro()
        {
            var equipoActual = cmbFiltroEquipo.SelectedItem?.ToString();
            cmbFiltroEquipo.Items.Clear();
            cmbFiltroEquipo.Items.Add("-- Todos los equipos --");

            try
            {
                var equipos = equipoDAO.ObtenerTodos().OrderBy(e => e.Nombre);
                foreach (var equipo in equipos)
                    cmbFiltroEquipo.Items.Add(equipo.Nombre);
            }
            catch { }

            if (!string.IsNullOrEmpty(equipoActual) && cmbFiltroEquipo.Items.Contains(equipoActual))
                cmbFiltroEquipo.SelectedItem = equipoActual;
            else
                cmbFiltroEquipo.SelectedIndex = 0;
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Buscar por nombre, nacionalidad...")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Buscar por nombre, nacionalidad...";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.ForeColor != Color.Gray)
                AplicarFiltros();
        }

        private void cmbFiltroEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "Buscar por nombre, nacionalidad...";
            txtBusqueda.ForeColor = Color.Gray;
            cmbFiltroEquipo.SelectedIndex = 0;
            cmbFiltroPosicion.SelectedIndex = 0;
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            if (listaJugadoresCompleta == null || listaJugadoresCompleta.Count == 0)
                return;

            var resultados = listaJugadoresCompleta.AsEnumerable();

            // Filtro por texto de búsqueda
            string textoBusqueda = txtBusqueda.ForeColor == Color.Gray ? "" : txtBusqueda.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                resultados = resultados.Where(j =>
                    (j.Nombre?.ToLower().Contains(textoBusqueda) ?? false) ||
                    (j.Nacionalidad?.ToLower().Contains(textoBusqueda) ?? false) ||
                    (j.NombreEquipo?.ToLower().Contains(textoBusqueda) ?? false)
                );
            }

            // Filtro por equipo
            if (cmbFiltroEquipo.SelectedIndex > 0)
            {
                string equipoSeleccionado = cmbFiltroEquipo.SelectedItem.ToString();
                resultados = resultados.Where(j => j.NombreEquipo == equipoSeleccionado);
            }

            // Filtro por posición
            if (cmbFiltroPosicion.SelectedIndex > 0)
            {
                string posicionSeleccionada = cmbFiltroPosicion.SelectedItem.ToString();
                resultados = resultados.Where(j => j.Posicion == posicionSeleccionada);
            }

            MostrarJugadores(resultados.ToList());
        }

        #endregion

        #region Menú Contextual

        private void ConfigurarMenuContextual()
        {
            dataGridViewJugador.ContextMenuStrip = contextMenuJugadores;
            dataGridViewJugador.MouseDown += DataGridViewJugador_MouseDown;
        }

        private void DataGridViewJugador_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dataGridViewJugador.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    dataGridViewJugador.ClearSelection();
                    dataGridViewJugador.Rows[hitTest.RowIndex].Selected = true;
                    dataGridViewJugador.CurrentCell = dataGridViewJugador.Rows[hitTest.RowIndex].Cells[1];
                    modificarToolStripMenuItem.Enabled = true;
                    eliminarToolStripMenuItem.Enabled = true;
                    verFichaToolStripMenuItem.Enabled = true;
                    copiarNombreToolStripMenuItem.Enabled = true;
                }
                else
                {
                    modificarToolStripMenuItem.Enabled = false;
                    eliminarToolStripMenuItem.Enabled = false;
                    verFichaToolStripMenuItem.Enabled = false;
                    copiarNombreToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e) => btnAñadirJugador_Click(sender, e);
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e) => btnModificarJugador_Click(sender, e);
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) => btnEliminar_Click(sender, e);
        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e) => btnVerFicha_Click(sender, e);
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e) => CargarJugadores();

        private void copiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count > 0)
            {
                string nombre = dataGridViewJugador.SelectedRows[0].Cells["Nombre"].Value.ToString();
                Clipboard.SetText(nombre);
                MostrarNotificacion("✓ Nombre copiado");
            }
        }

        private void MostrarNotificacion(string mensaje)
        {
            string tituloOriginal = this.Text;
            this.Text = mensaje;
            Timer timer = new Timer { Interval = 2000 };
            timer.Tick += (s, args) => { this.Text = tituloOriginal; timer.Stop(); timer.Dispose(); };
            timer.Start();
        }

        #endregion

        #region Carga de Datos

        private void CargarJugadores()
        {
            try
            {
                listaJugadoresCompleta = jugadorDAO.ObtenerTodos();
                CargarEquiposEnFiltro();
                MostrarJugadores(listaJugadoresCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar Jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarJugadores(List<LigaZamaca.Modelos.Jugador> jugadores)
        {
            dataGridViewJugador.DataSource = null;
            dataGridViewJugador.DataSource = jugadores;
            lblTotal.Text = $"Mostrando: {jugadores.Count} de {listaJugadoresCompleta.Count}";
        }

        #endregion

        #region Botones CRUD

        private void btnAñadirJugador_Click(object sender, EventArgs e)
        {
            FormJugadorDetalle formDetalle = new FormJugadorDetalle();
            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarJugadores();
                MessageBox.Show("Jugador añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un Jugador para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idJugador = Convert.ToInt32(dataGridViewJugador.SelectedRows[0].Cells["IdJugador"].Value);
            FormJugadorDetalle formDetalle = new FormJugadorDetalle(idJugador);

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarJugadores();
                MessageBox.Show("Jugador modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un Jugador para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idJugador = Convert.ToInt32(dataGridViewJugador.SelectedRows[0].Cells["IdJugador"].Value);
            string nombreJugador = dataGridViewJugador.SelectedRows[0].Cells["Nombre"].Value.ToString();

            DialogResult resultado = MessageBox.Show(
               $"¿Estás seguro de que deseas eliminar el jugador '{nombreJugador}'?\n\nADVERTENCIA: También se eliminarán todas las estadísticas relacionadas.",
               "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (jugadorDAO.Eliminar(idJugador))
                    {
                        CargarJugadores();
                        MessageBox.Show("Jugador eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el jugador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVerFicha_Click(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un jugador para ver su ficha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idJugador = Convert.ToInt32(dataGridViewJugador.SelectedRows[0].Cells["IdJugador"].Value);
            FormFichaJugador formFicha = new FormFichaJugador(idJugador);
            formFicha.ShowDialog();
        }

        private void dataGridViewJugador_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewJugador.SelectedRows.Count > 0)
            {
                idJugadorSeleccionado = Convert.ToInt32(dataGridViewJugador.SelectedRows[0].Cells["IdJugador"].Value);
                btnModificarJugador.Enabled = true;
                btnEliminar.Enabled = true;
                btnVerFicha.Enabled = true;
            }
            else
            {
                idJugadorSeleccionado = 0;
                btnModificarJugador.Enabled = false;
                btnEliminar.Enabled = false;
                btnVerFicha.Enabled = false;
            }
        }

        private void dataGridViewJugador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnVerFicha_Click(sender, e);
        }

        #endregion
    }
}