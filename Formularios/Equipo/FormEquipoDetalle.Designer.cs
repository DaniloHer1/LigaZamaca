namespace LigaZamaca.Formularios
{
    partial class FormEquipoDetalle
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
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblEntrenador = new System.Windows.Forms.Label();
            this.txtEntrenador = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEscudo = new System.Windows.Forms.Label();
            this.txtEscudo = new System.Windows.Forms.TextBox();
            this.lblFechaFundacion = new System.Windows.Forms.Label();
            this.dtpFechaFundacion = new System.Windows.Forms.DateTimePicker();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.numPresupuesto = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxEscudo = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.btnCopiarProyecto = new System.Windows.Forms.Button();
            this.panelImagen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscudo)).BeginInit();
            this.panelImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(30, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: *";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(160, 67);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEstadio.Location = new System.Drawing.Point(30, 110);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(69, 17);
            this.lblEstadio.TabIndex = 2;
            this.lblEstadio.Text = "Estadio: *";
            // 
            // txtEstadio
            // 
            this.txtEstadio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEstadio.Location = new System.Drawing.Point(160, 107);
            this.txtEstadio.MaxLength = 100;
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(300, 25);
            this.txtEstadio.TabIndex = 3;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCiudad.Location = new System.Drawing.Point(30, 150);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(66, 17);
            this.lblCiudad.TabIndex = 4;
            this.lblCiudad.Text = "Ciudad: *";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCiudad.Location = new System.Drawing.Point(160, 147);
            this.txtCiudad.MaxLength = 100;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(300, 25);
            this.txtCiudad.TabIndex = 5;
            // 
            // lblEntrenador
            // 
            this.lblEntrenador.AutoSize = true;
            this.lblEntrenador.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEntrenador.Location = new System.Drawing.Point(30, 190);
            this.lblEntrenador.Name = "lblEntrenador";
            this.lblEntrenador.Size = new System.Drawing.Size(76, 17);
            this.lblEntrenador.TabIndex = 6;
            this.lblEntrenador.Text = "Entrenador:";
            // 
            // txtEntrenador
            // 
            this.txtEntrenador.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEntrenador.Location = new System.Drawing.Point(160, 187);
            this.txtEntrenador.MaxLength = 100;
            this.txtEntrenador.Name = "txtEntrenador";
            this.txtEntrenador.Size = new System.Drawing.Size(300, 25);
            this.txtEntrenador.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(30, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(160, 227);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTelefono.Location = new System.Drawing.Point(30, 270);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 17);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTelefono.Location = new System.Drawing.Point(160, 267);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(300, 25);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblEscudo
            // 
            this.lblEscudo.AutoSize = true;
            this.lblEscudo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEscudo.Location = new System.Drawing.Point(30, 310);
            this.lblEscudo.Name = "lblEscudo";
            this.lblEscudo.Size = new System.Drawing.Size(93, 17);
            this.lblEscudo.TabIndex = 12;
            this.lblEscudo.Text = "Escudo (URL):";
            // 
            // txtEscudo
            // 
            this.txtEscudo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEscudo.Location = new System.Drawing.Point(160, 307);
            this.txtEscudo.MaxLength = 255;
            this.txtEscudo.Name = "txtEscudo";
            this.txtEscudo.Size = new System.Drawing.Size(300, 25);
            this.txtEscudo.TabIndex = 13;
            this.txtEscudo.TextChanged += new System.EventHandler(this.txtEscudo_TextChanged);
            // 
            // lblFechaFundacion
            // 
            this.lblFechaFundacion.AutoSize = true;
            this.lblFechaFundacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFechaFundacion.Location = new System.Drawing.Point(30, 390);
            this.lblFechaFundacion.Name = "lblFechaFundacion";
            this.lblFechaFundacion.Size = new System.Drawing.Size(108, 17);
            this.lblFechaFundacion.TabIndex = 16;
            this.lblFechaFundacion.Text = "Fecha Fundación:";
            // 
            // dtpFechaFundacion
            // 
            this.dtpFechaFundacion.Checked = false;
            this.dtpFechaFundacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpFechaFundacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFundacion.Location = new System.Drawing.Point(160, 387);
            this.dtpFechaFundacion.Name = "dtpFechaFundacion";
            this.dtpFechaFundacion.ShowCheckBox = true;
            this.dtpFechaFundacion.Size = new System.Drawing.Size(200, 25);
            this.dtpFechaFundacion.TabIndex = 17;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPresupuesto.Location = new System.Drawing.Point(30, 430);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(105, 17);
            this.lblPresupuesto.TabIndex = 18;
            this.lblPresupuesto.Text = "Presupuesto (€):";
            // 
            // numPresupuesto
            // 
            this.numPresupuesto.DecimalPlaces = 2;
            this.numPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numPresupuesto.Location = new System.Drawing.Point(160, 427);
            this.numPresupuesto.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numPresupuesto.Name = "numPresupuesto";
            this.numPresupuesto.Size = new System.Drawing.Size(200, 25);
            this.numPresupuesto.TabIndex = 19;
            this.numPresupuesto.ThousandsSeparator = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(210, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(345, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblObligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblObligatorio.Location = new System.Drawing.Point(30, 470);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(123, 13);
            this.lblObligatorio.TabIndex = 22;
            this.lblObligatorio.Text = "* Campos obligatorios";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 510);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(694, 70);
            this.panelBotones.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 25);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "📝 Datos del Equipo";
            // 
            // pictureBoxEscudo
            // 
            this.pictureBoxEscudo.BackColor = System.Drawing.Color.White;
            this.pictureBoxEscudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEscudo.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxEscudo.Name = "pictureBoxEscudo";
            this.pictureBoxEscudo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEscudo.TabIndex = 25;
            this.pictureBoxEscudo.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(10, 190);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(150, 30);
            this.btnExaminar.TabIndex = 14;
            this.btnExaminar.Text = "📁 Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVistaPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblVistaPrevia.Location = new System.Drawing.Point(0, 0);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(172, 25);
            this.lblVistaPrevia.TabIndex = 26;
            this.lblVistaPrevia.Text = "🖼️ Vista Previa";
            this.lblVistaPrevia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopiarProyecto
            // 
            this.btnCopiarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCopiarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarProyecto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCopiarProyecto.ForeColor = System.Drawing.Color.White;
            this.btnCopiarProyecto.Location = new System.Drawing.Point(10, 226);
            this.btnCopiarProyecto.Name = "btnCopiarProyecto";
            this.btnCopiarProyecto.Size = new System.Drawing.Size(150, 25);
            this.btnCopiarProyecto.TabIndex = 15;
            this.btnCopiarProyecto.Text = "💾 Copiar al Proyecto";
            this.btnCopiarProyecto.UseVisualStyleBackColor = false;
            this.btnCopiarProyecto.Click += new System.EventHandler(this.btnCopiarProyecto_Click);
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImagen.Controls.Add(this.lblVistaPrevia);
            this.panelImagen.Controls.Add(this.pictureBoxEscudo);
            this.panelImagen.Controls.Add(this.btnCopiarProyecto);
            this.panelImagen.Controls.Add(this.btnExaminar);
            this.panelImagen.Location = new System.Drawing.Point(490, 67);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(174, 265);
            this.panelImagen.TabIndex = 27;
            // 
            // FormEquipoDetalle
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(694, 580);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblObligatorio);
            this.Controls.Add(this.numPresupuesto);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.dtpFechaFundacion);
            this.Controls.Add(this.lblFechaFundacion);
            this.Controls.Add(this.txtEscudo);
            this.Controls.Add(this.lblEscudo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEntrenador);
            this.Controls.Add(this.lblEntrenador);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtEstadio);
            this.Controls.Add(this.lblEstadio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEquipoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.FormEquipoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscudo)).EndInit();
            this.panelImagen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblEntrenador;
        private System.Windows.Forms.TextBox txtEntrenador;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEscudo;
        private System.Windows.Forms.TextBox txtEscudo;
        private System.Windows.Forms.Label lblFechaFundacion;
        private System.Windows.Forms.DateTimePicker dtpFechaFundacion;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.NumericUpDown numPresupuesto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxEscudo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Button btnCopiarProyecto;
        private System.Windows.Forms.Panel panelImagen;
    }
}