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
            ((System.ComponentModel.ISupportInitialize)(this.numPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelBotones.SuspendLayout();
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
            this.lblEstadio.Size = new System.Drawing.Size(67, 17);
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
            this.lblCiudad.Size = new System.Drawing.Size(65, 17);
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
            this.lblTelefono.Size = new System.Drawing.Size(61, 17);
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
            this.lblEscudo.Size = new System.Drawing.Size(88, 17);
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
            // 
            // lblFechaFundacion
            // 
            this.lblFechaFundacion.AutoSize = true;
            this.lblFechaFundacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFechaFundacion.Location = new System.Drawing.Point(30, 350);
            this.lblFechaFundacion.Name = "lblFechaFundacion";
            this.lblFechaFundacion.Size = new System.Drawing.Size(107, 17);
            this.lblFechaFundacion.TabIndex = 14;
            this.lblFechaFundacion.Text = "Fecha Fundación:";
            // 
            // dtpFechaFundacion
            // 
            this.dtpFechaFundacion.Checked = false;
            this.dtpFechaFundacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpFechaFundacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFundacion.Location = new System.Drawing.Point(160, 347);
            this.dtpFechaFundacion.Name = "dtpFechaFundacion";
            this.dtpFechaFundacion.ShowCheckBox = true;
            this.dtpFechaFundacion.Size = new System.Drawing.Size(200, 25);
            this.dtpFechaFundacion.TabIndex = 15;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPresupuesto.Location = new System.Drawing.Point(30, 390);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(102, 17);
            this.lblPresupuesto.TabIndex = 16;
            this.lblPresupuesto.Text = "Presupuesto (€):";
            // 
            // numPresupuesto
            // 
            this.numPresupuesto.DecimalPlaces = 2;
            this.numPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numPresupuesto.Location = new System.Drawing.Point(160, 387);
            this.numPresupuesto.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numPresupuesto.Name = "numPresupuesto";
            this.numPresupuesto.Size = new System.Drawing.Size(200, 25);
            this.numPresupuesto.TabIndex = 17;
            this.numPresupuesto.ThousandsSeparator = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(140, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 18;
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
            this.btnCancelar.Location = new System.Drawing.Point(275, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 19;
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
            this.lblObligatorio.Location = new System.Drawing.Point(30, 430);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(113, 13);
            this.lblObligatorio.TabIndex = 20;
            this.lblObligatorio.Text = "* Campos obligatorios";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 470);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(504, 70);
            this.panelBotones.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Datos del Equipo";
            // 
            // FormEquipoDetalle
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(504, 540);
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
    }
}