namespace LigaZamaca.Formularios
{
    partial class FormEquipos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscudo)).BeginInit();
            this.panelEscudo.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipos.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewEquipos.MultiSelect = false;
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.ReadOnly = true;
            this.dataGridViewEquipos.RowHeadersWidth = 51;
            this.dataGridViewEquipos.RowTemplate.Height = 60;
            this.dataGridViewEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEquipos.Size = new System.Drawing.Size(770, 450);
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
            this.btnModificarEquipo.Location = new System.Drawing.Point(165, 15);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Size = new System.Drawing.Size(160, 40);
            this.btnModificarEquipo.TabIndex = 2;
            this.btnModificarEquipo.Text = "✏️ Modificar Equipo";
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
            this.btnEliminar.Location = new System.Drawing.Point(335, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(520, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total equipos: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 32);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gestión de Equipos";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBotones.Controls.Add(this.btnAñadirEquipo);
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnModificarEquipo);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(12, 520);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(960, 70);
            this.panelBotones.TabIndex = 6;
            // 
            // pictureBoxEscudo
            // 
            this.pictureBoxEscudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEscudo.BackColor = System.Drawing.Color.White;
            this.pictureBoxEscudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panelEscudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelEscudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEscudo.Controls.Add(this.lblEscudo);
            this.panelEscudo.Controls.Add(this.pictureBoxEscudo);
            this.panelEscudo.Location = new System.Drawing.Point(790, 60);
            this.panelEscudo.Name = "panelEscudo";
            this.panelEscudo.Size = new System.Drawing.Size(182, 450);
            this.panelEscudo.TabIndex = 8;
            // 
            // lblEscudo
            // 
            this.lblEscudo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEscudo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEscudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblEscudo.Location = new System.Drawing.Point(0, 0);
            this.lblEscudo.Name = "lblEscudo";
            this.lblEscudo.Size = new System.Drawing.Size(180, 30);
            this.lblEscudo.TabIndex = 8;
            this.lblEscudo.Text = "Escudo";
            this.lblEscudo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 602);
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
    }
}