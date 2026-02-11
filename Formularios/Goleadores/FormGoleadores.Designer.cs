namespace LigaZamaca.Formularios.Goleadores
{
    partial class FormGoleadores
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridViewGoleadores = new System.Windows.Forms.DataGridView();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelLeyenda = new System.Windows.Forms.Panel();
            this.lblOro = new System.Windows.Forms.Label();
            this.lblPlata = new System.Windows.Forms.Label();
            this.lblBronce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoleadores)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelLeyenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(331, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🥇 TOP GOLEADORES";
            // 
            // dataGridViewGoleadores
            // 
            this.dataGridViewGoleadores.AllowUserToAddRows = false;
            this.dataGridViewGoleadores.AllowUserToDeleteRows = false;
            this.dataGridViewGoleadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGoleadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGoleadores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGoleadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGoleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoleadores.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewGoleadores.Name = "dataGridViewGoleadores";
            this.dataGridViewGoleadores.ReadOnly = true;
            this.dataGridViewGoleadores.RowHeadersVisible = false;
            this.dataGridViewGoleadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGoleadores.Size = new System.Drawing.Size(860, 460);
            this.dataGridViewGoleadores.TabIndex = 1;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnActualizar);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Location = new System.Drawing.Point(12, 526);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(860, 60);
            this.panelBotones.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(15, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(147, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Goleadores: 0";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(620, 10);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 40);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(740, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "✖ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelLeyenda
            // 
            this.panelLeyenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeyenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeyenda.Controls.Add(this.lblOro);
            this.panelLeyenda.Controls.Add(this.lblPlata);
            this.panelLeyenda.Controls.Add(this.lblBronce);
            this.panelLeyenda.Location = new System.Drawing.Point(630, 9);
            this.panelLeyenda.Name = "panelLeyenda";
            this.panelLeyenda.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeyenda.Size = new System.Drawing.Size(242, 45);
            this.panelLeyenda.TabIndex = 3;
            // 
            // lblOro
            // 
            this.lblOro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblOro.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblOro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOro.Location = new System.Drawing.Point(13, 13);
            this.lblOro.Name = "lblOro";
            this.lblOro.Padding = new System.Windows.Forms.Padding(5);
            this.lblOro.Size = new System.Drawing.Size(65, 23);
            this.lblOro.TabIndex = 0;
            this.lblOro.Text = "🥇 1°";
            this.lblOro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlata
            // 
            this.lblPlata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPlata.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPlata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlata.Location = new System.Drawing.Point(89, 13);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Padding = new System.Windows.Forms.Padding(5);
            this.lblPlata.Size = new System.Drawing.Size(65, 23);
            this.lblPlata.TabIndex = 1;
            this.lblPlata.Text = "🥈 2°";
            this.lblPlata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBronce
            // 
            this.lblBronce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(127)))), ((int)(((byte)(50)))));
            this.lblBronce.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBronce.ForeColor = System.Drawing.Color.White;
            this.lblBronce.Location = new System.Drawing.Point(165, 13);
            this.lblBronce.Name = "lblBronce";
            this.lblBronce.Padding = new System.Windows.Forms.Padding(5);
            this.lblBronce.Size = new System.Drawing.Size(65, 23);
            this.lblBronce.TabIndex = 2;
            this.lblBronce.Text = "🥉 3°";
            this.lblBronce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGoleadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 598);
            this.Controls.Add(this.panelLeyenda);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.dataGridViewGoleadores);
            this.Controls.Add(this.lblTitulo);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormGoleadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Goleadores - Liga Zamaca";
            this.Load += new System.EventHandler(this.FormGoleadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoleadores)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panelLeyenda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridViewGoleadores;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelLeyenda;
        private System.Windows.Forms.Label lblOro;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.Label lblBronce;
    }
}