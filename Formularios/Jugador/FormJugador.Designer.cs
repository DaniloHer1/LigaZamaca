namespace LigaZamaca.Formularios.Jugador
{
    partial class FormJugador
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
            this.dataGridViewJugador = new System.Windows.Forms.DataGridView();
            this.btnAñadirJugador = new System.Windows.Forms.Button();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerFicha = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cmbFiltroPosicion = new System.Windows.Forms.ComboBox();
            this.lblFiltroPosicion = new System.Windows.Forms.Label();
            this.cmbFiltroEquipo = new System.Windows.Forms.ComboBox();
            this.lblFiltroEquipo = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.contextMenuJugadores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugador)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.contextMenuJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltros.Controls.Add(this.cmbFiltroPosicion);
            this.panelFiltros.Controls.Add(this.lblFiltroPosicion);
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
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(10, 15);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 17);
            this.lblBuscar.Text = "🔍 Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBusqueda.Location = new System.Drawing.Point(75, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(220, 25);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblFiltroEquipo
            // 
            this.lblFiltroEquipo.AutoSize = true;
            this.lblFiltroEquipo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroEquipo.Location = new System.Drawing.Point(310, 15);
            this.lblFiltroEquipo.Name = "lblFiltroEquipo";
            this.lblFiltroEquipo.Size = new System.Drawing.Size(50, 17);
            this.lblFiltroEquipo.Text = "Equipo:";
            // 
            // cmbFiltroEquipo
            // 
            this.cmbFiltroEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEquipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroEquipo.Location = new System.Drawing.Point(365, 11);
            this.cmbFiltroEquipo.Name = "cmbFiltroEquipo";
            this.cmbFiltroEquipo.Size = new System.Drawing.Size(180, 25);
            this.cmbFiltroEquipo.TabIndex = 2;
            this.cmbFiltroEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEquipo_SelectedIndexChanged);
            // 
            // lblFiltroPosicion
            // 
            this.lblFiltroPosicion.AutoSize = true;
            this.lblFiltroPosicion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroPosicion.Location = new System.Drawing.Point(560, 15);
            this.lblFiltroPosicion.Name = "lblFiltroPosicion";
            this.lblFiltroPosicion.Size = new System.Drawing.Size(58, 17);
            this.lblFiltroPosicion.Text = "Posición:";
            // 
            // cmbFiltroPosicion
            // 
            this.cmbFiltroPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroPosicion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroPosicion.Location = new System.Drawing.Point(625, 11);
            this.cmbFiltroPosicion.Name = "cmbFiltroPosicion";
            this.cmbFiltroPosicion.Size = new System.Drawing.Size(150, 25);
            this.cmbFiltroPosicion.TabIndex = 3;
            this.cmbFiltroPosicion.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPosicion_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(795, 10);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(150, 28);
            this.btnLimpiarFiltros.TabIndex = 4;
            this.btnLimpiarFiltros.Text = "✖ Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // dataGridViewJugador
            // 
            this.dataGridViewJugador.AllowUserToAddRows = false;
            this.dataGridViewJugador.AllowUserToDeleteRows = false;
            this.dataGridViewJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJugador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJugador.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewJugador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJugador.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewJugador.Name = "dataGridViewJugador";
            this.dataGridViewJugador.ReadOnly = true;
            this.dataGridViewJugador.RowHeadersVisible = false;
            this.dataGridViewJugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJugador.Size = new System.Drawing.Size(960, 395);
            this.dataGridViewJugador.TabIndex = 0;
            this.dataGridViewJugador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJugador_CellDoubleClick);
            this.dataGridViewJugador.SelectionChanged += new System.EventHandler(this.dataGridViewJugador_SelectionChanged);
            // 
            // btnAñadirJugador
            // 
            this.btnAñadirJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAñadirJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirJugador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAñadirJugador.ForeColor = System.Drawing.Color.White;
            this.btnAñadirJugador.Location = new System.Drawing.Point(15, 15);
            this.btnAñadirJugador.Name = "btnAñadirJugador";
            this.btnAñadirJugador.Size = new System.Drawing.Size(140, 40);
            this.btnAñadirJugador.TabIndex = 1;
            this.btnAñadirJugador.Text = "➕ Añadir Jugador";
            this.btnAñadirJugador.UseVisualStyleBackColor = false;
            this.btnAñadirJugador.Click += new System.EventHandler(this.btnAñadirJugador_Click);
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnModificarJugador.Enabled = false;
            this.btnModificarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarJugador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarJugador.ForeColor = System.Drawing.Color.White;
            this.btnModificarJugador.Location = new System.Drawing.Point(170, 15);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(140, 40);
            this.btnModificarJugador.TabIndex = 2;
            this.btnModificarJugador.Text = "✏️ Modificar";
            this.btnModificarJugador.UseVisualStyleBackColor = false;
            this.btnModificarJugador.Click += new System.EventHandler(this.btnModificarJugador_Click);
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
            // btnVerFicha
            // 
            this.btnVerFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnVerFicha.Enabled = false;
            this.btnVerFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFicha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVerFicha.ForeColor = System.Drawing.Color.White;
            this.btnVerFicha.Location = new System.Drawing.Point(480, 15);
            this.btnVerFicha.Name = "btnVerFicha";
            this.btnVerFicha.Size = new System.Drawing.Size(140, 40);
            this.btnVerFicha.TabIndex = 5;
            this.btnVerFicha.Text = "👤 Ver Ficha";
            this.btnVerFicha.UseVisualStyleBackColor = false;
            this.btnVerFicha.Click += new System.EventHandler(this.btnVerFicha_Click);
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
            this.lblTitulo.Size = new System.Drawing.Size(270, 37);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gestión de Jugadores";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnVerFicha);
            this.panelBotones.Controls.Add(this.btnAñadirJugador);
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnModificarJugador);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(12, 520);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(960, 70);
            this.panelBotones.TabIndex = 6;
            // 
            // contextMenuJugadores
            // 
            this.contextMenuJugadores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuJugadores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator1,
            this.verFichaToolStripMenuItem,
            this.copiarNombreToolStripMenuItem,
            this.toolStripSeparator2,
            this.actualizarToolStripMenuItem});
            this.contextMenuJugadores.Name = "contextMenuJugadores";
            this.contextMenuJugadores.Size = new System.Drawing.Size(230, 160);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.añadirToolStripMenuItem.Text = "➕ Añadir jugador";
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
            // verFichaToolStripMenuItem
            // 
            this.verFichaToolStripMenuItem.Name = "verFichaToolStripMenuItem";
            this.verFichaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.verFichaToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.verFichaToolStripMenuItem.Text = "👤 Ver ficha";
            this.verFichaToolStripMenuItem.Click += new System.EventHandler(this.verFichaToolStripMenuItem_Click);
            // 
            // copiarNombreToolStripMenuItem
            // 
            this.copiarNombreToolStripMenuItem.Name = "copiarNombreToolStripMenuItem";
            this.copiarNombreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarNombreToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.copiarNombreToolStripMenuItem.Text = "📋 Copiar nombre";
            this.copiarNombreToolStripMenuItem.Click += new System.EventHandler(this.copiarNombreToolStripMenuItem_Click);
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
            // FormJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewJugador);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Jugadores - Liga Zamaca";
            this.Load += new System.EventHandler(this.FormJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugador)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.contextMenuJugadores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJugador;
        private System.Windows.Forms.Button btnAñadirJugador;
        private System.Windows.Forms.Button btnModificarJugador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerFicha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.ComboBox cmbFiltroPosicion;
        private System.Windows.Forms.Label lblFiltroPosicion;
        private System.Windows.Forms.ComboBox cmbFiltroEquipo;
        private System.Windows.Forms.Label lblFiltroEquipo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuJugadores;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem verFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
    }
}