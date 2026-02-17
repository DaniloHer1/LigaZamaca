namespace LigaZamaca.Formularios
{
    partial class FormEquipos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewEquipos = new System.Windows.Forms.DataGridView();
            this.btnAñadirEquipo = new System.Windows.Forms.Button();
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.pictureBoxEscudo = new System.Windows.Forms.PictureBox();
            this.panelEscudo = new System.Windows.Forms.Panel();
            this.lblEscudo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cmbFiltroCiudad = new System.Windows.Forms.ComboBox();
            this.lblFiltroCiudad = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.contextMenuEquipos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscudo)).BeginInit();
            this.panelEscudo.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.contextMenuEquipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltros.Controls.Add(this.cmbFiltroCiudad);
            this.panelFiltros.Controls.Add(this.lblFiltroCiudad);
            this.panelFiltros.Controls.Add(this.txtBusqueda);
            this.panelFiltros.Controls.Add(this.lblBuscar);
            this.panelFiltros.Location = new System.Drawing.Point(12, 55);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(770, 50);
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
            this.txtBusqueda.Size = new System.Drawing.Size(250, 25);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblFiltroCiudad
            // 
            this.lblFiltroCiudad.AutoSize = true;
            this.lblFiltroCiudad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroCiudad.Location = new System.Drawing.Point(345, 15);
            this.lblFiltroCiudad.Name = "lblFiltroCiudad";
            this.lblFiltroCiudad.Size = new System.Drawing.Size(55, 17);
            this.lblFiltroCiudad.Text = "Ciudad:";
            // 
            // cmbFiltroCiudad
            // 
            this.cmbFiltroCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroCiudad.Location = new System.Drawing.Point(405, 11);
            this.cmbFiltroCiudad.Name = "cmbFiltroCiudad";
            this.cmbFiltroCiudad.Size = new System.Drawing.Size(200, 25);
            this.cmbFiltroCiudad.TabIndex = 2;
            this.cmbFiltroCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCiudad_SelectedIndexChanged);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(620, 10);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(130, 28);
            this.btnLimpiarFiltros.TabIndex = 3;
            this.btnLimpiarFiltros.Text = "✖ Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // dataGridViewEquipos
            // 
            this.dataGridViewEquipos.AllowUserToAddRows = false;
            this.dataGridViewEquipos.AllowUserToDeleteRows = false;
            this.dataGridViewEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipos.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.ReadOnly = true;
            this.dataGridViewEquipos.RowHeadersWidth = 51;
            this.dataGridViewEquipos.RowTemplate.Height = 60;
            this.dataGridViewEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEquipos.Size = new System.Drawing.Size(770, 395);
            this.dataGridViewEquipos.TabIndex = 0;
            this.dataGridViewEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipos_CellDoubleClick);
            this.dataGridViewEquipos.SelectionChanged += new System.EventHandler(this.dataGridViewEquipos_SelectionChanged);
            // 
            // btnAñadirEquipo
            // 
            this.btnAñadirEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAñadirEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirEquipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAñadirEquipo.ForeColor = System.Drawing.Color.White;
            this.btnAñadirEquipo.Location = new System.Drawing.Point(15, 15);
            this.btnAñadirEquipo.Name = "btnAñadirEquipo";
            this.btnAñadirEquipo.Size = new System.Drawing.Size(140, 40);
            this.btnAñadirEquipo.TabIndex = 1;
            this.btnAñadirEquipo.Text = "➕ Añadir Equipo";
            this.btnAñadirEquipo.UseVisualStyleBackColor = false;
            this.btnAñadirEquipo.Click += new System.EventHandler(this.btnAñadirEquipo_Click);
            // 
            // btnModificarEquipo
            // 
            this.btnModificarEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnModificarEquipo.Enabled = false;
            this.btnModificarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEquipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnModificarEquipo.Location = new System.Drawing.Point(170, 15);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Size = new System.Drawing.Size(140, 40);
            this.btnModificarEquipo.TabIndex = 2;
            this.btnModificarEquipo.Text = "✏️ Modificar";
            this.btnModificarEquipo.UseVisualStyleBackColor = false;
            this.btnModificarEquipo.Click += new System.EventHandler(this.btnModificarEquipo_Click);
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
            this.lblTotal.Location = new System.Drawing.Point(550, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(210, 20);
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
            this.lblTitulo.Size = new System.Drawing.Size(237, 37);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gestión de Equipos";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnAñadirEquipo);
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnModificarEquipo);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(12, 520);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(770, 70);
            this.panelBotones.TabIndex = 6;
            // 
            // pictureBoxEscudo
            // 
            this.pictureBoxEscudo.Location = new System.Drawing.Point(10, 40);
            this.pictureBoxEscudo.Name = "pictureBoxEscudo";
            this.pictureBoxEscudo.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEscudo.TabIndex = 7;
            this.pictureBoxEscudo.TabStop = false;
            // 
            // panelEscudo
            // 
            this.panelEscudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEscudo.BackColor = System.Drawing.Color.White;
            this.panelEscudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEscudo.Controls.Add(this.lblEscudo);
            this.panelEscudo.Controls.Add(this.pictureBoxEscudo);
            this.panelEscudo.Location = new System.Drawing.Point(788, 55);
            this.panelEscudo.Name = "panelEscudo";
            this.panelEscudo.Size = new System.Drawing.Size(180, 455);
            this.panelEscudo.TabIndex = 7;
            // 
            // lblEscudo
            // 
            this.lblEscudo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEscudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(42)))));
            this.lblEscudo.Location = new System.Drawing.Point(0, 5);
            this.lblEscudo.Name = "lblEscudo";
            this.lblEscudo.Size = new System.Drawing.Size(180, 30);
            this.lblEscudo.TabIndex = 8;
            this.lblEscudo.Text = "Escudo";
            this.lblEscudo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuEquipos
            // 
            this.contextMenuEquipos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuEquipos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator1,
            this.verDetalleToolStripMenuItem,
            this.copiarNombreToolStripMenuItem,
            this.toolStripSeparator2,
            this.actualizarToolStripMenuItem});
            this.contextMenuEquipos.Name = "contextMenuEquipos";
            this.contextMenuEquipos.Size = new System.Drawing.Size(230, 160);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.añadirToolStripMenuItem.Text = "➕ Añadir equipo";
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
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.verDetalleToolStripMenuItem.Text = "👁️ Ver detalle";
            this.verDetalleToolStripMenuItem.Click += new System.EventHandler(this.verDetalleToolStripMenuItem_Click);
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
            // FormEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelEscudo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewEquipos);
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "FormEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Equipos - Liga Zamaca";
            this.Load += new System.EventHandler(this.FormEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).EndInit();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscudo)).EndInit();
            this.panelEscudo.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.contextMenuEquipos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEquipos;
        private System.Windows.Forms.Button btnAñadirEquipo;
        private System.Windows.Forms.Button btnModificarEquipo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.PictureBox pictureBoxEscudo;
        private System.Windows.Forms.Panel panelEscudo;
        private System.Windows.Forms.Label lblEscudo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.ComboBox cmbFiltroCiudad;
        private System.Windows.Forms.Label lblFiltroCiudad;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuEquipos;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
    }
}