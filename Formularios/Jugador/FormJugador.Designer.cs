using System;
using System.Windows.Forms;

namespace LigaZamaca.Formularios.Jugador
{
    partial class FormJugador
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
            this.dataGridViewJugador = new System.Windows.Forms.DataGridView();
            this.btnAñadirJugador = new System.Windows.Forms.Button();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnVerFicha = new System.Windows.Forms.Button();
            this.btnVerFicha.BackColor = System.Drawing.Color.FromArgb(156, 39, 176);
            this.btnVerFicha.Enabled = false;
            this.btnVerFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFicha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVerFicha.ForeColor = System.Drawing.Color.White;
            this.btnVerFicha.Location = new System.Drawing.Point(465, 15);
            this.btnVerFicha.Name = "btnVerFicha";
            this.btnVerFicha.Size = new System.Drawing.Size(140, 40);
            this.btnVerFicha.Text = "📋 Ver Ficha";
            this.btnVerFicha.Click += new System.EventHandler(this.btnVerFicha_Click);
            this.panelBotones.Controls.Add(this.btnVerFicha);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugador)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJugador.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewJugador.MultiSelect = false;
            this.dataGridViewJugador.Name = "dataGridViewJugador";
            this.dataGridViewJugador.ReadOnly = true;
            this.dataGridViewJugador.RowHeadersWidth = 51;
            this.dataGridViewJugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJugador.Size = new System.Drawing.Size(960, 450);
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
            this.btnModificarJugador.Location = new System.Drawing.Point(165, 15);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(160, 40);
            this.btnModificarJugador.TabIndex = 2;
            this.btnModificarJugador.Text = "✏️ Modificar Jugador";
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
            this.lblTotal.Location = new System.Drawing.Point(720, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total jugadores: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 32);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gestión de Jugadores";
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBotones.Controls.Add(this.btnAñadirJugador);
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnModificarJugador);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(12, 520);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(960, 70);
            this.panelBotones.TabIndex = 6;
            // 
            // FormJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewJugador);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Jugadores - Liga Zamaca ";
            this.Load += new System.EventHandler(this.FormJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugador)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJugador;
        private System.Windows.Forms.Button btnAñadirJugador;
        private System.Windows.Forms.Button btnModificarJugador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnVerFicha;
    }
}