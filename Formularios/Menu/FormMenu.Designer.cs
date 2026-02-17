namespace LigaZamaca.Formularios.Menu
{
    partial class FormMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goleadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelIcono = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHoraIcono = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSeparador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnGoleadores = new System.Windows.Forms.Button();
            this.btnClasificacion = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.manualTecnicoCHMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(900, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.jugadoresToolStripMenuItem,
            this.partidosToolStripMenuItem});
            this.gestionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.gestionToolStripMenuItem.Text = "&Gestión";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.equiposToolStripMenuItem.Text = "&Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.jugadoresToolStripMenuItem.Text = "&Jugadores";
            this.jugadoresToolStripMenuItem.Click += new System.EventHandler(this.jugadoresToolStripMenuItem_Click);
            // 
            // partidosToolStripMenuItem
            // 
            this.partidosToolStripMenuItem.Name = "partidosToolStripMenuItem";
            this.partidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.partidosToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.partidosToolStripMenuItem.Text = "&Partidos";
            this.partidosToolStripMenuItem.Click += new System.EventHandler(this.partidosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clasificacionToolStripMenuItem,
            this.goleadoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.estadisticasToolStripMenuItem});
            this.informesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.informesToolStripMenuItem.Text = "&Informes";
            // 
            // clasificacionToolStripMenuItem
            // 
            this.clasificacionToolStripMenuItem.Name = "clasificacionToolStripMenuItem";
            this.clasificacionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clasificacionToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.clasificacionToolStripMenuItem.Text = "&Clasificación";
            this.clasificacionToolStripMenuItem.Click += new System.EventHandler(this.clasificacionToolStripMenuItem_Click);
            // 
            // goleadoresToolStripMenuItem
            // 
            this.goleadoresToolStripMenuItem.Name = "goleadoresToolStripMenuItem";
            this.goleadoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goleadoresToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.goleadoresToolStripMenuItem.Text = "&Goleadores";
            this.goleadoresToolStripMenuItem.Click += new System.EventHandler(this.goleadoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.estadisticasToolStripMenuItem.Text = "&Estadísticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualUsuarioToolStripMenuItem,
            this.manualTecnicoCHMToolStripMenuItem,
            this.toolStripSeparator2,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // manualUsuarioToolStripMenuItem
            // 
            this.manualUsuarioToolStripMenuItem.Name = "manualUsuarioToolStripMenuItem";
            this.manualUsuarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.manualUsuarioToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.manualUsuarioToolStripMenuItem.Text = "&Manual de Usuario";
            this.manualUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelIcono,
            this.toolStripStatusLabelEstado,
            this.toolStripStatusLabelSpring,
            this.toolStripStatusLabelHoraIcono,
            this.toolStripStatusLabelHora,
            this.toolStripStatusLabelSeparador,
            this.toolStripStatusLabelVersion});
            this.statusStrip.Location = new System.Drawing.Point(0, 640);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(900, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelIcono
            // 
            this.toolStripStatusLabelIcono.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripStatusLabelIcono.Name = "toolStripStatusLabelIcono";
            this.toolStripStatusLabelIcono.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelIcono.Text = "●";
            // 
            // toolStripStatusLabelEstado
            // 
            this.toolStripStatusLabelEstado.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelEstado.Name = "toolStripStatusLabelEstado";
            this.toolStripStatusLabelEstado.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabelEstado.Text = "Conectado";
            // 
            // toolStripStatusLabelSpring
            // 
            this.toolStripStatusLabelSpring.Name = "toolStripStatusLabelSpring";
            this.toolStripStatusLabelSpring.Size = new System.Drawing.Size(672, 17);
            this.toolStripStatusLabelSpring.Spring = true;
            // 
            // toolStripStatusLabelHoraIcono
            // 
            this.toolStripStatusLabelHoraIcono.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripStatusLabelHoraIcono.Name = "toolStripStatusLabelHoraIcono";
            this.toolStripStatusLabelHoraIcono.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabelHoraIcono.Text = "🕐";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabelHora.Text = "00:00:00";
            // 
            // toolStripStatusLabelSeparador
            // 
            this.toolStripStatusLabelSeparador.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelSeparador.Name = "toolStripStatusLabelSeparador";
            this.toolStripStatusLabelSeparador.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabelSeparador.Text = "|";
            // 
            // toolStripStatusLabelVersion
            // 
            this.toolStripStatusLabelVersion.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelVersion.Text = "v1.0";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(42)))));
            this.panelSuperior.Controls.Add(this.lblFecha);
            this.panelSuperior.Controls.Add(this.lblSubtitulo);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 31);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(900, 120);
            this.panelSuperior.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblFecha.Location = new System.Drawing.Point(600, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(285, 23);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Lunes, 14 de enero de 2025";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(15, 75);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(270, 21);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Sistema de Gestión de Liga de Fútbol ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Liga Zamaca";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPrincipal.Controls.Add(this.btnGoleadores);
            this.panelPrincipal.Controls.Add(this.btnClasificacion);
            this.panelPrincipal.Controls.Add(this.btnPartidos);
            this.panelPrincipal.Controls.Add(this.btnJugadores);
            this.panelPrincipal.Controls.Add(this.btnEquipos);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 151);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Padding = new System.Windows.Forms.Padding(30);
            this.panelPrincipal.Size = new System.Drawing.Size(900, 429);
            this.panelPrincipal.TabIndex = 3;
            // 
            // btnGoleadores
            // 
            this.btnGoleadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnGoleadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoleadores.FlatAppearance.BorderSize = 0;
            this.btnGoleadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoleadores.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnGoleadores.ForeColor = System.Drawing.Color.White;
            this.btnGoleadores.Location = new System.Drawing.Point(246, 279);
            this.btnGoleadores.Name = "btnGoleadores";
            this.btnGoleadores.Size = new System.Drawing.Size(400, 100);
            this.btnGoleadores.TabIndex = 4;
            this.btnGoleadores.Text = "🥇 TOP GOLEADORES\r\n";
            this.btnGoleadores.UseVisualStyleBackColor = false;
            this.btnGoleadores.Click += new System.EventHandler(this.btnGoleadores_Click);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClasificacion.FlatAppearance.BorderSize = 0;
            this.btnClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasificacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClasificacion.ForeColor = System.Drawing.Color.White;
            this.btnClasificacion.Location = new System.Drawing.Point(470, 140);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Size = new System.Drawing.Size(400, 100);
            this.btnClasificacion.TabIndex = 3;
            this.btnClasificacion.Text = "📈 CLASIFICACIÓN\r\n";
            this.btnClasificacion.UseVisualStyleBackColor = false;
            this.btnClasificacion.Click += new System.EventHandler(this.btnClasificacion_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.Location = new System.Drawing.Point(30, 140);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(400, 100);
            this.btnPartidos.TabIndex = 2;
            this.btnPartidos.Text = "⚽ PARTIDOS";
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnJugadores.ForeColor = System.Drawing.Color.White;
            this.btnJugadores.Location = new System.Drawing.Point(470, 20);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(400, 100);
            this.btnJugadores.TabIndex = 1;
            this.btnJugadores.Text = "👥 JUGADORES";
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEquipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEquipos.ForeColor = System.Drawing.Color.White;
            this.btnEquipos.Location = new System.Drawing.Point(30, 20);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(400, 100);
            this.btnEquipos.TabIndex = 0;
            this.btnEquipos.Text = "🏆 EQUIPOS";
            this.btnEquipos.UseVisualStyleBackColor = false;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.White;
            this.panelInferior.Controls.Add(this.btnAcercaDe);
            this.panelInferior.Controls.Add(this.btnSalir);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 580);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(900, 60);
            this.panelInferior.TabIndex = 4;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe.Location = new System.Drawing.Point(30, 10);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(140, 40);
            this.btnAcercaDe.TabIndex = 1;
            this.btnAcercaDe.Text = "ℹ️ Acerca de";
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(730, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 40);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // manualTecnicoCHMToolStripMenuItem
            // 
            this.manualTecnicoCHMToolStripMenuItem.Name = "manualTecnicoCHMToolStripMenuItem";
            this.manualTecnicoCHMToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.manualTecnicoCHMToolStripMenuItem.Text = "Manual Tecnico CHM";
            this.manualTecnicoCHMToolStripMenuItem.Click += new System.EventHandler(this.manualTecnicoCHMToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 662);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liga Zamaca - Menú Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // MenuStrip y sus elementos
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goleadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;

        // StatusStrip y sus elementos
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelIcono;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpring;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHoraIcono;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSeparador;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;

        // Paneles y controles existentes
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnClasificacion;
        private System.Windows.Forms.Button btnGoleadores;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem manualTecnicoCHMToolStripMenuItem;
    }
}