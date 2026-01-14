namespace LigaZamaca.Formularios.Partido
{
    partial class FormPartidoDetalle
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxInfoBasica = new System.Windows.Forms.GroupBox();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.lblJornada = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.numJornada = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBoxEquipos = new System.Windows.Forms.GroupBox();
            this.lblEquipoLocal = new System.Windows.Forms.Label();
            this.lblEquipoVisitante = new System.Windows.Forms.Label();
            this.cmbEquipoLocal = new System.Windows.Forms.ComboBox();
            this.cmbEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblGolesLocal = new System.Windows.Forms.Label();
            this.lblGolesVisitante = new System.Windows.Forms.Label();
            this.numGolesLocal = new System.Windows.Forms.NumericUpDown();
            this.numGolesVisitante = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.lblArbitro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.txtArbitro = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.numAsistencia = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInfoBasica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJornada)).BeginInit();
            this.groupBoxEquipos.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesVisitante)).BeginInit();
            this.groupBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "⚽ Detalles del Partido";
            // 
            // groupBoxInfoBasica
            // 
            this.groupBoxInfoBasica.Controls.Add(this.lblEstadio);
            this.groupBoxInfoBasica.Controls.Add(this.lblJornada);
            this.groupBoxInfoBasica.Controls.Add(this.lblFecha);
            this.groupBoxInfoBasica.Controls.Add(this.txtEstadio);
            this.groupBoxInfoBasica.Controls.Add(this.numJornada);
            this.groupBoxInfoBasica.Controls.Add(this.dtpFecha);
            this.groupBoxInfoBasica.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfoBasica.Location = new System.Drawing.Point(17, 59);
            this.groupBoxInfoBasica.Name = "groupBoxInfoBasica";
            this.groupBoxInfoBasica.Size = new System.Drawing.Size(620, 100);
            this.groupBoxInfoBasica.TabIndex = 1;
            this.groupBoxInfoBasica.TabStop = false;
            this.groupBoxInfoBasica.Text = "Información Básica";
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEstadio.Location = new System.Drawing.Point(270, 33);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(54, 17);
            this.lblEstadio.TabIndex = 4;
            this.lblEstadio.Text = "Estadio:";
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblJornada.Location = new System.Drawing.Point(15, 68);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(58, 17);
            this.lblJornada.TabIndex = 2;
            this.lblJornada.Text = "Jornada:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFecha.Location = new System.Drawing.Point(15, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtEstadio
            // 
            this.txtEstadio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEstadio.Location = new System.Drawing.Point(350, 30);
            this.txtEstadio.MaxLength = 100;
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(250, 25);
            this.txtEstadio.TabIndex = 5;
            // 
            // numJornada
            // 
            this.numJornada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numJornada.Location = new System.Drawing.Point(95, 65);
            this.numJornada.Maximum = new decimal(new int[] {
            38,
            0,
            0,
            0});
            this.numJornada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJornada.Name = "numJornada";
            this.numJornada.Size = new System.Drawing.Size(150, 25);
            this.numJornada.TabIndex = 3;
            this.numJornada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(95, 30);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 25);
            this.dtpFecha.TabIndex = 1;
            // 
            // groupBoxEquipos
            // 
            this.groupBoxEquipos.Controls.Add(this.lblEquipoLocal);
            this.groupBoxEquipos.Controls.Add(this.lblEquipoVisitante);
            this.groupBoxEquipos.Controls.Add(this.cmbEquipoLocal);
            this.groupBoxEquipos.Controls.Add(this.cmbEquipoVisitante);
            this.groupBoxEquipos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxEquipos.Location = new System.Drawing.Point(17, 165);
            this.groupBoxEquipos.Name = "groupBoxEquipos";
            this.groupBoxEquipos.Size = new System.Drawing.Size(620, 100);
            this.groupBoxEquipos.TabIndex = 2;
            this.groupBoxEquipos.TabStop = false;
            this.groupBoxEquipos.Text = "Equipos";
            // 
            // lblEquipoLocal
            // 
            this.lblEquipoLocal.AutoSize = true;
            this.lblEquipoLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEquipoLocal.Location = new System.Drawing.Point(15, 28);
            this.lblEquipoLocal.Name = "lblEquipoLocal";
            this.lblEquipoLocal.Size = new System.Drawing.Size(86, 17);
            this.lblEquipoLocal.TabIndex = 0;
            this.lblEquipoLocal.Text = "Equipo Local:";
            // 
            // lblEquipoVisitante
            // 
            this.lblEquipoVisitante.AutoSize = true;
            this.lblEquipoVisitante.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEquipoVisitante.Location = new System.Drawing.Point(15, 63);
            this.lblEquipoVisitante.Name = "lblEquipoVisitante";
            this.lblEquipoVisitante.Size = new System.Drawing.Size(105, 17);
            this.lblEquipoVisitante.TabIndex = 2;
            this.lblEquipoVisitante.Text = "Equipo Visitante:";
            // 
            // cmbEquipoLocal
            // 
            this.cmbEquipoLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbEquipoLocal.FormattingEnabled = true;
            this.cmbEquipoLocal.Location = new System.Drawing.Point(150, 25);
            this.cmbEquipoLocal.Name = "cmbEquipoLocal";
            this.cmbEquipoLocal.Size = new System.Drawing.Size(450, 25);
            this.cmbEquipoLocal.TabIndex = 1;
            this.cmbEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoLocal_SelectedIndexChanged);
            // 
            // cmbEquipoVisitante
            // 
            this.cmbEquipoVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoVisitante.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbEquipoVisitante.FormattingEnabled = true;
            this.cmbEquipoVisitante.Location = new System.Drawing.Point(150, 60);
            this.cmbEquipoVisitante.Name = "cmbEquipoVisitante";
            this.cmbEquipoVisitante.Size = new System.Drawing.Size(450, 25);
            this.cmbEquipoVisitante.TabIndex = 3;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblGolesLocal);
            this.groupBoxResultado.Controls.Add(this.lblGolesVisitante);
            this.groupBoxResultado.Controls.Add(this.numGolesLocal);
            this.groupBoxResultado.Controls.Add(this.numGolesVisitante);
            this.groupBoxResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxResultado.Location = new System.Drawing.Point(17, 275);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(620, 80);
            this.groupBoxResultado.TabIndex = 3;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado";
            // 
            // lblGolesLocal
            // 
            this.lblGolesLocal.AutoSize = true;
            this.lblGolesLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGolesLocal.Location = new System.Drawing.Point(15, 38);
            this.lblGolesLocal.Name = "lblGolesLocal";
            this.lblGolesLocal.Size = new System.Drawing.Size(78, 17);
            this.lblGolesLocal.TabIndex = 0;
            this.lblGolesLocal.Text = "Goles Local:";
            // 
            // lblGolesVisitante
            // 
            this.lblGolesVisitante.AutoSize = true;
            this.lblGolesVisitante.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGolesVisitante.Location = new System.Drawing.Point(330, 38);
            this.lblGolesVisitante.Name = "lblGolesVisitante";
            this.lblGolesVisitante.Size = new System.Drawing.Size(97, 17);
            this.lblGolesVisitante.TabIndex = 2;
            this.lblGolesVisitante.Text = "Goles Visitante:";
            // 
            // numGolesLocal
            // 
            this.numGolesLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numGolesLocal.Location = new System.Drawing.Point(150, 35);
            this.numGolesLocal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGolesLocal.Name = "numGolesLocal";
            this.numGolesLocal.Size = new System.Drawing.Size(150, 25);
            this.numGolesLocal.TabIndex = 1;
            // 
            // numGolesVisitante
            // 
            this.numGolesVisitante.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numGolesVisitante.Location = new System.Drawing.Point(450, 35);
            this.numGolesVisitante.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGolesVisitante.Name = "numGolesVisitante";
            this.numGolesVisitante.Size = new System.Drawing.Size(150, 25);
            this.numGolesVisitante.TabIndex = 3;
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.lblArbitro);
            this.groupBoxDetalles.Controls.Add(this.lblEstado);
            this.groupBoxDetalles.Controls.Add(this.lblAsistencia);
            this.groupBoxDetalles.Controls.Add(this.txtArbitro);
            this.groupBoxDetalles.Controls.Add(this.cmbEstado);
            this.groupBoxDetalles.Controls.Add(this.numAsistencia);
            this.groupBoxDetalles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxDetalles.Location = new System.Drawing.Point(17, 374);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Size = new System.Drawing.Size(620, 120);
            this.groupBoxDetalles.TabIndex = 4;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = " Detalles Adicionales";
            // 
            // lblArbitro
            // 
            this.lblArbitro.AutoSize = true;
            this.lblArbitro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblArbitro.Location = new System.Drawing.Point(15, 18);
            this.lblArbitro.Name = "lblArbitro";
            this.lblArbitro.Size = new System.Drawing.Size(52, 17);
            this.lblArbitro.TabIndex = 0;
            this.lblArbitro.Text = "Árbitro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEstado.Location = new System.Drawing.Point(15, 48);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 17);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAsistencia.Location = new System.Drawing.Point(15, 83);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(68, 17);
            this.lblAsistencia.TabIndex = 4;
            this.lblAsistencia.Text = "Asistencia:";
            // 
            // txtArbitro
            // 
            this.txtArbitro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtArbitro.Location = new System.Drawing.Point(150, 10);
            this.txtArbitro.MaxLength = 100;
            this.txtArbitro.Name = "txtArbitro";
            this.txtArbitro.Size = new System.Drawing.Size(450, 25);
            this.txtArbitro.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(150, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 25);
            this.cmbEstado.TabIndex = 3;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // numAsistencia
            // 
            this.numAsistencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numAsistencia.Location = new System.Drawing.Point(150, 80);
            this.numAsistencia.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numAsistencia.Name = "numAsistencia";
            this.numAsistencia.Size = new System.Drawing.Size(150, 25);
            this.numAsistencia.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(417, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "✅ Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(533, 500);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormPartidoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 552);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.groupBoxEquipos);
            this.Controls.Add(this.groupBoxInfoBasica);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPartidoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Partido - Liga Zamaca";
            this.Load += new System.EventHandler(this.FormPartidoDetalle_Load);
            this.groupBoxInfoBasica.ResumeLayout(false);
            this.groupBoxInfoBasica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJornada)).EndInit();
            this.groupBoxEquipos.ResumeLayout(false);
            this.groupBoxEquipos.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolesVisitante)).EndInit();
            this.groupBoxDetalles.ResumeLayout(false);
            this.groupBoxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxInfoBasica;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown numJornada;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.GroupBox groupBoxEquipos;
        private System.Windows.Forms.ComboBox cmbEquipoLocal;
        private System.Windows.Forms.ComboBox cmbEquipoVisitante;
        private System.Windows.Forms.Label lblEquipoLocal;
        private System.Windows.Forms.Label lblEquipoVisitante;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.NumericUpDown numGolesLocal;
        private System.Windows.Forms.NumericUpDown numGolesVisitante;
        private System.Windows.Forms.Label lblGolesLocal;
        private System.Windows.Forms.Label lblGolesVisitante;
        private System.Windows.Forms.GroupBox groupBoxDetalles;
        private System.Windows.Forms.TextBox txtArbitro;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.NumericUpDown numAsistencia;
        private System.Windows.Forms.Label lblArbitro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}