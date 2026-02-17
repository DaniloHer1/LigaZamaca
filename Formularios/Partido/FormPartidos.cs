using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;

namespace LigaZamaca.Formularios.Partido
{
    /// <summary>
    /// Formulario para la gestión de partidos de la liga.
    /// Permite añadir, modificar, eliminar, buscar y filtrar partidos.
    /// </summary>
    public partial class FormPartidos : Form
    {
        private PartidoDAO partidoDAO;
        private EquipoDAO equipoDAO;
        private int idPartidoSeleccionado = 0;
        private List<LigaZamaca.Modelos.Partido> listaPartidosCompleta;

        public FormPartidos()
        {
            InitializeComponent();
            partidoDAO = new PartidoDAO();
            equipoDAO = new EquipoDAO();
            listaPartidosCompleta = new List<LigaZamaca.Modelos.Partido>();
        }

        private void FormPartidos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            ConfigurarMenuContextual();
            ConfigurarFiltros();
            CargarPartidos();
        }

        #region Configuración del DataGridView

        private void ConfigurarDataGridView()
        {
            dataGridViewPartidos.AutoGenerateColumns = false;
            dataGridViewPartidos.Columns.Clear();
            dataGridViewPartidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartidos.MultiSelect = false;
            dataGridViewPartidos.ReadOnly = true;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdPartido";
            colId.DataPropertyName = "IdPartido";
            colId.Visible = false;
            dataGridViewPartidos.Columns.Add(colId);

            DataGridViewTextBoxColumn colJornada = new DataGridViewTextBoxColumn();
            colJornada.Name = "Jornada";
            colJornada.HeaderText = "Jornada";
            colJornada.DataPropertyName = "Jornada";
            colJornada.Width = 70;
            dataGridViewPartidos.Columns.Add(colJornada);

            DataGridViewTextBoxColumn colLocal = new DataGridViewTextBoxColumn();
            colLocal.Name = "NombreEquipoLocal";
            colLocal.HeaderText = "Equipo Local";
            colLocal.DataPropertyName = "NombreEquipoLocal";
            colLocal.Width = 150;
            dataGridViewPartidos.Columns.Add(colLocal);

            DataGridViewTextBoxColumn colGolesLocal = new DataGridViewTextBoxColumn();
            colGolesLocal.Name = "GolesLocal";
            colGolesLocal.HeaderText = "GL";
            colGolesLocal.DataPropertyName = "GolesLocal";
            colGolesLocal.Width = 45;
            dataGridViewPartidos.Columns.Add(colGolesLocal);

            DataGridViewTextBoxColumn colVs = new DataGridViewTextBoxColumn();
            colVs.Name = "vs";
            colVs.HeaderText = "";
            colVs.Width = 30;
            colVs.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPartidos.Columns.Add(colVs);

            DataGridViewTextBoxColumn colGolesVisitante = new DataGridViewTextBoxColumn();
            colGolesVisitante.Name = "GolesVisitante";
            colGolesVisitante.HeaderText = "GV";
            colGolesVisitante.DataPropertyName = "GolesVisitante";
            colGolesVisitante.Width = 45;
            dataGridViewPartidos.Columns.Add(colGolesVisitante);

            DataGridViewTextBoxColumn colVisitante = new DataGridViewTextBoxColumn();
            colVisitante.Name = "NombreEquipoVisitante";
            colVisitante.HeaderText = "Equipo Visitante";
            colVisitante.DataPropertyName = "NombreEquipoVisitante";
            colVisitante.Width = 150;
            dataGridViewPartidos.Columns.Add(colVisitante);

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "FechaHora";
            colFecha.HeaderText = "Fecha";
            colFecha.DataPropertyName = "FechaHora";
            colFecha.Width = 120;
            colFecha.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dataGridViewPartidos.Columns.Add(colFecha);

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.DataPropertyName = "Estado";
            colEstado.Width = 90;
            dataGridViewPartidos.Columns.Add(colEstado);
        }

        #endregion

        #region Búsqueda y Filtros

        private void ConfigurarFiltros()
        {
            // Cargar equipos
            cmbFiltroEquipo.Items.Clear();
            cmbFiltroEquipo.Items.Add("-- Todos los equipos --");
            cmbFiltroEquipo.SelectedIndex = 0;

            // Cargar jornadas
            cmbFiltroJornada.Items.Clear();
            cmbFiltroJornada.Items.Add("-- Todas las jornadas --");
            for (int i = 1; i <= 38; i++)
                cmbFiltroJornada.Items.Add($"Jornada {i}");
            cmbFiltroJornada.SelectedIndex = 0;

            // Cargar estados
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add("-- Todos los estados --");
            cmbFiltroEstado.Items.Add("Programado");
            cmbFiltroEstado.Items.Add("En Juego");
            cmbFiltroEstado.Items.Add("Finalizado");
            cmbFiltroEstado.Items.Add("Suspendido");
            cmbFiltroEstado.Items.Add("Aplazado");
            cmbFiltroEstado.SelectedIndex = 0;

            // Placeholder búsqueda
            txtBusqueda.Text = "Buscar por equipo...";
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
            if (txtBusqueda.Text == "Buscar por equipo...")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Buscar por equipo...";
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

        private void cmbFiltroJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "Buscar por equipo...";
            txtBusqueda.ForeColor = Color.Gray;
            cmbFiltroEquipo.SelectedIndex = 0;
            cmbFiltroJornada.SelectedIndex = 0;
            cmbFiltroEstado.SelectedIndex = 0;
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            if (listaPartidosCompleta == null || listaPartidosCompleta.Count == 0)
                return;

            var resultados = listaPartidosCompleta.AsEnumerable();

            // Filtro por texto de búsqueda
            string textoBusqueda = txtBusqueda.ForeColor == Color.Gray ? "" : txtBusqueda.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                resultados = resultados.Where(p =>
                    (p.NombreEquipoLocal?.ToLower().Contains(textoBusqueda) ?? false) ||
                    (p.NombreEquipoVisitante?.ToLower().Contains(textoBusqueda) ?? false)
                );
            }

            // Filtro por equipo
            if (cmbFiltroEquipo.SelectedIndex > 0)
            {
                string equipoSeleccionado = cmbFiltroEquipo.SelectedItem.ToString();
                resultados = resultados.Where(p =>
                    p.NombreEquipoLocal == equipoSeleccionado ||
                    p.NombreEquipoVisitante == equipoSeleccionado
                );
            }

            // Filtro por jornada
            if (cmbFiltroJornada.SelectedIndex > 0)
            {
                int jornadaSeleccionada = cmbFiltroJornada.SelectedIndex;
                resultados = resultados.Where(p => p.Jornada == jornadaSeleccionada);
            }

            // Filtro por estado
            if (cmbFiltroEstado.SelectedIndex > 0)
            {
                string estadoSeleccionado = cmbFiltroEstado.SelectedItem.ToString();
                resultados = resultados.Where(p => p.Estado == estadoSeleccionado);
            }

            MostrarPartidos(resultados.ToList());
        }

        #endregion

        #region Menú Contextual

        private void ConfigurarMenuContextual()
        {
            dataGridViewPartidos.ContextMenuStrip = contextMenuPartidos;
            dataGridViewPartidos.MouseDown += DataGridViewPartidos_MouseDown;
        }

        private void DataGridViewPartidos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dataGridViewPartidos.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    dataGridViewPartidos.ClearSelection();
                    dataGridViewPartidos.Rows[hitTest.RowIndex].Selected = true;
                    dataGridViewPartidos.CurrentCell = dataGridViewPartidos.Rows[hitTest.RowIndex].Cells[1];
                    modificarToolStripMenuItem.Enabled = true;
                    eliminarToolStripMenuItem.Enabled = true;
                    copiarResultadoToolStripMenuItem.Enabled = true;
                }
                else
                {
                    modificarToolStripMenuItem.Enabled = false;
                    eliminarToolStripMenuItem.Enabled = false;
                    copiarResultadoToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e) => btnAñadirPartido_Click(sender, e);
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e) => btnModificarPartido_Click(sender, e);
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) => btnEliminar_Click(sender, e);
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e) => CargarPartidos();

        private void copiarResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartidos.SelectedRows.Count > 0)
            {
                var row = dataGridViewPartidos.SelectedRows[0];
                string local = row.Cells["NombreEquipoLocal"].Value?.ToString() ?? "";
                string visitante = row.Cells["NombreEquipoVisitante"].Value?.ToString() ?? "";
                string golesLocal = row.Cells["GolesLocal"].Value?.ToString() ?? "0";
                string golesVisitante = row.Cells["GolesVisitante"].Value?.ToString() ?? "0";

                string resultado = $"{local} {golesLocal} - {golesVisitante} {visitante}";
                Clipboard.SetText(resultado);
                MostrarNotificacion("✓ Resultado copiado");
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

        private void CargarPartidos()
        {
            try
            {
                listaPartidosCompleta = partidoDAO.ObtenerTodos();
                CargarEquiposEnFiltro();
                MostrarPartidos(listaPartidosCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar partidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarPartidos(List<LigaZamaca.Modelos.Partido> partidos)
        {
            dataGridViewPartidos.DataSource = null;
            dataGridViewPartidos.DataSource = partidos;

            // Añadir "vs" en la columna central
            foreach (DataGridViewRow row in dataGridViewPartidos.Rows)
                row.Cells["vs"].Value = "vs";

            lblTotal.Text = $"Mostrando: {partidos.Count} de {listaPartidosCompleta.Count}";
        }

        #endregion

        #region Botones CRUD

        private void btnAñadirPartido_Click(object sender, EventArgs e)
        {
            FormPartidoDetalle formDetalle = new FormPartidoDetalle();
            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarPartidos();
                MessageBox.Show("Partido añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarPartido_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un partido para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPartido = Convert.ToInt32(dataGridViewPartidos.SelectedRows[0].Cells["IdPartido"].Value);
            FormPartidoDetalle formDetalle = new FormPartidoDetalle(idPartido);

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarPartidos();
                MessageBox.Show("Partido modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un partido para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPartido = Convert.ToInt32(dataGridViewPartidos.SelectedRows[0].Cells["IdPartido"].Value);
            var row = dataGridViewPartidos.SelectedRows[0];
            string descripcion = $"{row.Cells["NombreEquipoLocal"].Value} vs {row.Cells["NombreEquipoVisitante"].Value}";

            DialogResult resultado = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el partido:\n{descripcion}?\n\nADVERTENCIA: También se eliminarán todas las estadísticas relacionadas.",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (partidoDAO.Eliminar(idPartido))
                    {
                        CargarPartidos();
                        MessageBox.Show("Partido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar partido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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

        private void dataGridViewPartidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnModificarPartido_Click(sender, e);
        }

        #endregion
    }
}