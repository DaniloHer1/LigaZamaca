namespace LigaZamaca.Formularios.Partido
{
    partial class FormPartidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPartidos = new System.Windows.Forms.DataGridView();
            this.btnAñadirPartido = new System.Windows.Forms.Button();
            this.btnModificarPartido = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cmbFiltroJornada = new System.Windows.Forms.ComboBox();
            this.lblFiltroJornada = new System.Windows.Forms.Label();
            this.cmbFiltroEquipo = new System.Windows.Forms.ComboBox();
            this.lblFiltroEquipo = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.contextMenuPartidos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidos)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.contextMenuPartidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltros.Controls.Add(this.cmbFiltroEstado);
            this.panelFiltros.Controls.Add(this.lblFiltroEstado);
            this.panelFiltros.Controls.Add(this.cmbFiltroJornada);
            this.panelFiltros.Controls.Add(this.lblFiltroJornada);
            this.panelFiltros.Controls.Add(this.cmbFiltroEquipo);
            this.panelFiltros.Controls.Add(this.lblFiltroEquipo);
            this.panelFiltros.Controls.Add(this.txtBusqueda);
            this.panelFiltros.Controls.Add(this.lblBuscar);
            this.panelFiltros.Location = new System.Drawing.Point(12, 55);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(960, 50);
            this.panelFiltros.TabIndex = 10;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(8, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(24, 15);
            this.lblBuscar.Text = "🔍";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBusqueda.Location = new System.Drawing.Point(35, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(160, 24);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblFiltroEquipo
            // 
            this.lblFiltroEquipo.AutoSize = true;
            this.lblFiltroEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroEquipo.Location = new System.Drawing.Point(210, 16);
            this.lblFiltroEquipo.Name = "lblFiltroEquipo";
            this.lblFiltroEquipo.Size = new System.Drawing.Size(47, 15);
            this.lblFiltroEquipo.Text = "Equipo:";
            // 
            // cmbFiltroEquipo
            // 
            this.cmbFiltroEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEquipo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFiltroEquipo.Location = new System.Drawing.Point(260, 12);
            this.cmbFiltroEquipo.Name = "cmbFiltroEquipo";
            this.cmbFiltroEquipo.Size = new System.Drawing.Size(160, 24);
            this.cmbFiltroEquipo.TabIndex = 2;
            this.cmbFiltroEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEquipo_SelectedIndexChanged);
            // 
            // lblFiltroJornada
            // 
            this.lblFiltroJornada.AutoSize = true;
            this.lblFiltroJornada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroJornada.Location = new System.Drawing.Point(435, 16);
            this.lblFiltroJornada.Name = "lblFiltroJornada";
            this.lblFiltroJornada.Size = new System.Drawing.Size(52, 15);
            this.lblFiltroJornada.Text = "Jornada:";
            // 
            // cmbFiltroJornada
            // 
            this.cmbFiltroJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroJornada.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFiltroJornada.Location = new System.Drawing.Point(492, 12);
            this.cmbFiltroJornada.Name = "cmbFiltroJornada";
            this.cmbFiltroJornada.Size = new System.Drawing.Size(140, 24);
            this.cmbFiltroJornada.TabIndex = 3;
            this.cmbFiltroJornada.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroJornada_SelectedIndexChanged);
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroEstado.Location = new System.Drawing.Point(645, 16);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(46, 15);
            this.lblFiltroEstado.Text = "Estado:";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFiltroEstado.Location = new System.Drawing.Point(695, 12);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(120, 24);
            this.cmbFiltroEstado.TabIndex = 4;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(830, 10);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(115, 28);
            this.btnLimpiarFiltros.TabIndex = 5;
            this.btnLimpiarFiltros.Text = "✖ Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // dataGridViewPartidos
            // 
            this.dataGridViewPartidos.AllowUserToAddRows = false;
            this.dataGridViewPartidos.AllowUserToDeleteRows = false;
            this.dataGridViewPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPartidos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidos.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewPartidos.Name = "dataGridViewPartidos";
            this.dataGridViewPartidos.ReadOnly = true;
            this.dataGridViewPartidos.RowHeadersVisible = false;
            this.dataGridViewPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPartidos.Size = new System.Drawing.Size(960, 395);
            this.dataGridViewPartidos.TabIndex = 0;
            this.dataGridViewPartidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidos_CellDoubleClick);
            this.dataGridViewPartidos.SelectionChanged += new System.EventHandler(this.dataGridViewPartidos_SelectionChanged);
            // 
            // btnAñadirPartido
            // 
            this.btnAñadirPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAñadirPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirPartido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAñadirPartido.ForeColor = System.Drawing.Color.White;
            this.btnAñadirPartido.Location = new System.Drawing.Point(15, 15);
            this.btnAñadirPartido.Name = "btnAñadirPartido";
            this.btnAñadirPartido.Size = new System.Drawing.Size(140, 40);
            this.btnAñadirPartido.TabIndex = 1;
            this.btnAñadirPartido.Text = "➕ Añadir Partido";
            this.btnAñadirPartido.UseVisualStyleBackColor = false;
            this.btnAñadirPartido.Click += new System.EventHandler(this.btnAñadirPartido_Click);
            // 
            // btnModificarPartido
            // 
            this.btnModificarPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnModificarPartido.Enabled = false;
            this.btnModificarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPartido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarPartido.ForeColor = System.Drawing.Color.White;
            this.btnModificarPartido.Location = new System.Drawing.Point(170, 15);
            this.btnModificarPartido.Name = "btnModificarPartido";
            this.btnModificarPartido.Size = new System.Drawing.Size(140, 40);
            this.btnModificarPartido.TabIndex = 2;
            this.btnModificarPartido.Text = "✏️ Modificar";
            this.btnModificarPartido.UseVisualStyleBackColor = false;
            this.btnModificarPartido.Click += new System.EventHandler(this.btnModificarPartido_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(325, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblTotal.Location = new System.Drawing.Point(750, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Mostrando: 0 de 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(42)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 37);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gestión de Partidos";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnAñadirPartido);
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnModificarPartido);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(12, 520);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(960, 70);
            this.panelBotones.TabIndex = 6;
            // 
            // contextMenuPartidos
            // 
            this.contextMenuPartidos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuPartidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator1,
            this.copiarResultadoToolStripMenuItem,
            this.toolStripSeparator2,
            this.actualizarToolStripMenuItem});
            this.contextMenuPartidos.Name = "contextMenuPartidos";
            this.contextMenuPartidos.Size = new System.Drawing.Size(230, 140);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.añadirToolStripMenuItem.Text = "➕ Añadir partido";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.modificarToolStripMenuItem.Text = "✏️ Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.eliminarToolStripMenuItem.Text = "🗑️ Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // copiarResultadoToolStripMenuItem
            // 
            this.copiarResultadoToolStripMenuItem.Name = "copiarResultadoToolStripMenuItem";
            this.copiarResultadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarResultadoToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.copiarResultadoToolStripMenuItem.Text = "📋 Copiar resultado";
            this.copiarResultadoToolStripMenuItem.Click += new System.EventHandler(this.copiarResultadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.actualizarToolStripMenuItem.Text = "🔄 Actualizar lista";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // FormPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewPartidos);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Partidos - Liga Zamaca";
            this.Load += new System.EventHandler(this.FormPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidos)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.contextMenuPartidos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPartidos;
        private System.Windows.Forms.Button btnAñadirPartido;
        private System.Windows.Forms.Button btnModificarPartido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroJornada;
        private System.Windows.Forms.Label lblFiltroJornada;
        private System.Windows.Forms.ComboBox cmbFiltroEquipo;
        private System.Windows.Forms.Label lblFiltroEquipo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuPartidos;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
    }
}