using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using LigaZamaca.Modelos;
using LigaZamaca.AccesoDatos;

namespace LigaZamaca.Formularios
{
    /// <summary>
    /// Formulario para la gestión de equipos de la liga.
    /// Permite añadir, modificar, eliminar, buscar y filtrar equipos.
    /// </summary>
    public partial class FormEquipos : Form
    {
        private EquipoDAO equipoDao;
        private int idEquipoSeleccionado = 0;
        private List<Equipo> listaEquiposCompleta;

        public FormEquipos()
        {
            InitializeComponent();
            equipoDao = new EquipoDAO();
            listaEquiposCompleta = new List<Equipo>();
        }

        private void FormEquipos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            ConfigurarMenuContextual();
            ConfigurarFiltros();
            CargarEquipos();
        }

        #region Configuración del DataGridView

        private void ConfigurarDataGridView()
        {
            dataGridViewEquipos.AutoGenerateColumns = false;
            dataGridViewEquipos.Columns.Clear();
            dataGridViewEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEquipos.MultiSelect = false;
            dataGridViewEquipos.ReadOnly = true;
            dataGridViewEquipos.RowTemplate.Height = 60;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdEquipo";
            colId.DataPropertyName = "IdEquipo";
            colId.Visible = false;
            dataGridViewEquipos.Columns.Add(colId);

            DataGridViewImageColumn colEscudo = new DataGridViewImageColumn();
            colEscudo.Name = "Escudo";
            colEscudo.HeaderText = "Logo";
            colEscudo.Width = 70;
            colEscudo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewEquipos.Columns.Add(colEscudo);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.Width = 200;
            dataGridViewEquipos.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colCiudad = new DataGridViewTextBoxColumn();
            colCiudad.Name = "Ciudad";
            colCiudad.HeaderText = "Ciudad";
            colCiudad.DataPropertyName = "Ciudad";
            colCiudad.Width = 150;
            dataGridViewEquipos.Columns.Add(colCiudad);

            DataGridViewTextBoxColumn colEstadio = new DataGridViewTextBoxColumn();
            colEstadio.Name = "Estadio";
            colEstadio.HeaderText = "Estadio";
            colEstadio.DataPropertyName = "Estadio";
            colEstadio.Width = 200;
            dataGridViewEquipos.Columns.Add(colEstadio);

            DataGridViewTextBoxColumn colFundacion = new DataGridViewTextBoxColumn();
            colFundacion.Name = "AñoFundacion";
            colFundacion.HeaderText = "Fundación";
            colFundacion.DataPropertyName = "AñoFundacion";
            colFundacion.Width = 100;
            dataGridViewEquipos.Columns.Add(colFundacion);
        }

        #endregion

        #region Búsqueda y Filtros

        private void ConfigurarFiltros()
        {
            cmbFiltroCiudad.Items.Clear();
            cmbFiltroCiudad.Items.Add("-- Todas las ciudades --");
            cmbFiltroCiudad.SelectedIndex = 0;

            txtBusqueda.Text = "Buscar por nombre, estadio...";
            txtBusqueda.ForeColor = Color.Gray;
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Buscar por nombre, estadio...")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Buscar por nombre, estadio...";
                txtBusqueda.ForeColor = Color.Gray;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.ForeColor != Color.Gray)
            {
                AplicarFiltros();
            }
        }

        private void cmbFiltroCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "Buscar por nombre, estadio...";
            txtBusqueda.ForeColor = Color.Gray;
            cmbFiltroCiudad.SelectedIndex = 0;
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            if (listaEquiposCompleta == null || listaEquiposCompleta.Count == 0)
                return;

            var resultados = listaEquiposCompleta.AsEnumerable();

            string textoBusqueda = txtBusqueda.ForeColor == Color.Gray ? "" : txtBusqueda.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                resultados = resultados.Where(e =>
                    (e.Nombre?.ToLower().Contains(textoBusqueda) ?? false) ||
                    (e.Ciudad?.ToLower().Contains(textoBusqueda) ?? false) ||
                    (e.Estadio?.ToLower().Contains(textoBusqueda) ?? false)
                );
            }

            if (cmbFiltroCiudad.SelectedIndex > 0)
            {
                string ciudadSeleccionada = cmbFiltroCiudad.SelectedItem.ToString();
                resultados = resultados.Where(e => e.Ciudad == ciudadSeleccionada);
            }

            MostrarEquipos(resultados.ToList());
        }

        #endregion

        #region Menú Contextual

        private void ConfigurarMenuContextual()
        {
            dataGridViewEquipos.ContextMenuStrip = contextMenuEquipos;
            dataGridViewEquipos.MouseDown += DataGridViewEquipos_MouseDown;
        }

        private void DataGridViewEquipos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dataGridViewEquipos.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    dataGridViewEquipos.ClearSelection();
                    dataGridViewEquipos.Rows[hitTest.RowIndex].Selected = true;
                    dataGridViewEquipos.CurrentCell = dataGridViewEquipos.Rows[hitTest.RowIndex].Cells[1];
                    modificarToolStripMenuItem.Enabled = true;
                    eliminarToolStripMenuItem.Enabled = true;
                    verDetalleToolStripMenuItem.Enabled = true;
                    copiarNombreToolStripMenuItem.Enabled = true;
                }
                else
                {
                    modificarToolStripMenuItem.Enabled = false;
                    eliminarToolStripMenuItem.Enabled = false;
                    verDetalleToolStripMenuItem.Enabled = false;
                    copiarNombreToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e) => btnAñadirEquipo_Click(sender, e);
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e) => btnModificarEquipo_Click(sender, e);
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) => btnEliminar_Click(sender, e);
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e) => CargarEquipos();

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count > 0)
            {
                int idEquipo = Convert.ToInt32(dataGridViewEquipos.SelectedRows[0].Cells["IdEquipo"].Value);
                FormEquipoDetalle formDetalle = new FormEquipoDetalle(idEquipo);
                formDetalle.ShowDialog();
                CargarEquipos();
            }
        }

        private void copiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count > 0)
            {
                string nombre = dataGridViewEquipos.SelectedRows[0].Cells["Nombre"].Value.ToString();
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

        private void CargarEquipos()
        {
            try
            {
                listaEquiposCompleta = equipoDao.ObtenerTodos();
                ActualizarFiltroCiudades();
                MostrarEquipos(listaEquiposCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarFiltroCiudades()
        {
            var ciudadActual = cmbFiltroCiudad.SelectedItem?.ToString();
            cmbFiltroCiudad.Items.Clear();
            cmbFiltroCiudad.Items.Add("-- Todas las ciudades --");

            var ciudades = listaEquiposCompleta
                .Where(e => !string.IsNullOrEmpty(e.Ciudad))
                .Select(e => e.Ciudad)
                .Distinct()
                .OrderBy(c => c);

            foreach (var ciudad in ciudades)
                cmbFiltroCiudad.Items.Add(ciudad);

            if (!string.IsNullOrEmpty(ciudadActual) && cmbFiltroCiudad.Items.Contains(ciudadActual))
                cmbFiltroCiudad.SelectedItem = ciudadActual;
            else
                cmbFiltroCiudad.SelectedIndex = 0;
        }

        private void MostrarEquipos(List<Equipo> equipos)
        {
            dataGridViewEquipos.DataSource = null;
            dataGridViewEquipos.DataSource = equipos;

            foreach (DataGridViewRow row in dataGridViewEquipos.Rows)
            {
                if (row.DataBoundItem is Equipo equipo)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(equipo.Escudo))
                        {
                            using (WebClient client = new WebClient())
                            {
                                byte[] imageData = client.DownloadData(equipo.Escudo);
                                using (var ms = new System.IO.MemoryStream(imageData))
                                {
                                    row.Cells["Escudo"].Value = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                    catch { }
                }
            }

            lblTotal.Text = $"Mostrando: {equipos.Count} de {listaEquiposCompleta.Count}";
        }

        #endregion

        #region Botones CRUD

        private void btnAñadirEquipo_Click(object sender, EventArgs e)
        {
            FormEquipoDetalle formDetalle = new FormEquipoDetalle();
            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarEquipos();
                MessageBox.Show("Equipo añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un equipo para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEquipo = Convert.ToInt32(dataGridViewEquipos.SelectedRows[0].Cells["IdEquipo"].Value);
            FormEquipoDetalle formDetalle = new FormEquipoDetalle(idEquipo);

            if (formDetalle.ShowDialog() == DialogResult.OK)
            {
                CargarEquipos();
                MessageBox.Show("Equipo modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un equipo para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEquipo = Convert.ToInt32(dataGridViewEquipos.SelectedRows[0].Cells["IdEquipo"].Value);
            string nombreEquipo = dataGridViewEquipos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            DialogResult resultado = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el equipo '{nombreEquipo}'?\n\nADVERTENCIA: También se eliminarán todos los jugadores, partidos y estadísticas relacionadas.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (equipoDao.Eliminar(idEquipo))
                    {
                        CargarEquipos();
                        MessageBox.Show("Equipo eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count > 0)
            {
                idEquipoSeleccionado = Convert.ToInt32(dataGridViewEquipos.SelectedRows[0].Cells["IdEquipo"].Value);
                btnModificarEquipo.Enabled = true;
                btnEliminar.Enabled = true;
                MostrarEscudoSeleccionado();
            }
            else
            {
                idEquipoSeleccionado = 0;
                btnModificarEquipo.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void MostrarEscudoSeleccionado()
        {
            try
            {
                if (dataGridViewEquipos.SelectedRows.Count > 0 && dataGridViewEquipos.SelectedRows[0].Cells["Escudo"].Value != null)
                    pictureBoxEscudo.Image = (Image)dataGridViewEquipos.SelectedRows[0].Cells["Escudo"].Value;
            }
            catch { pictureBoxEscudo.Image = null; }
        }

        private void dataGridViewEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnModificarEquipo_Click(sender, e);
        }

        #endregion
    }
}