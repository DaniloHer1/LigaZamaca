namespace LigaZamaca.Formularios.Partido
{
    partial class FormPartidos
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
            this.dataGridViewPartidos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarPartido = new System.Windows.Forms.Button();
            this.btnAñadirPartido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidos)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidos.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewPartidos.Name = "dataGridViewPartidos";
            this.dataGridViewPartidos.ReadOnly = true;
            this.dataGridViewPartidos.RowHeadersWidth = 51;
            this.dataGridViewPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPartidos.Size = new System.Drawing.Size(1060, 450);
            this.dataGridViewPartidos.TabIndex = 0;
            this.dataGridViewPartidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidos_CellDoubleClick);
            this.dataGridViewPartidos.SelectionChanged += new System.EventHandler(this.dataGridViewPartidos_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de Partidos";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnModificarPartido);
            this.panelBotones.Controls.Add(this.btnAñadirPartido);
            this.panelBotones.Location = new System.Drawing.Point(12, 520);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1060, 70);
            this.panelBotones.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(850, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 23);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Partidos: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificarPartido.Size = new System.Drawing.Size(150, 40);
            this.btnModificarPartido.TabIndex = 1;
            this.btnModificarPartido.Text = "✏️ Modificar Partido";
            this.btnModificarPartido.UseVisualStyleBackColor = false;
            this.btnModificarPartido.Click += new System.EventHandler(this.btnModificarPartido_Click);
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
            this.btnAñadirPartido.TabIndex = 0;
            this.btnAñadirPartido.Text = "➕ Añadir Partido";
            this.btnAñadirPartido.UseVisualStyleBackColor = false;
            this.btnAñadirPartido.Click += new System.EventHandler(this.btnAñadirPartido_Click);
            // 
            // FormPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 602);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewPartidos);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Partidos - Liga Zamaca";
            this.Load += new System.EventHandler(this.FormPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidos)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPartidos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAñadirPartido;
        private System.Windows.Forms.Button btnModificarPartido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotal;
    }
}