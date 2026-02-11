namespace LigaZamaca.Formularios.Jugador
{
    partial class FormFichaJugador
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
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblDorsal = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelEstadisticas = new System.Windows.Forms.Panel();
            this.lblTituloEstadisticas = new System.Windows.Forms.Label();
            this.panelPartidos = new System.Windows.Forms.Panel();
            this.lblPartidosValor = new System.Windows.Forms.Label();
            this.lblPartidosTitulo = new System.Windows.Forms.Label();
            this.lblPartidosDetalle = new System.Windows.Forms.Label();
            this.panelGoles = new System.Windows.Forms.Panel();
            this.lblGolesValor = new System.Windows.Forms.Label();
            this.lblGolesTitulo = new System.Windows.Forms.Label();
            this.lblGolesDetalle = new System.Windows.Forms.Label();
            this.panelAsistencias = new System.Windows.Forms.Panel();
            this.lblAsistenciasValor = new System.Windows.Forms.Label();
            this.lblAsistenciasTitulo = new System.Windows.Forms.Label();
            this.panelAmarillas = new System.Windows.Forms.Panel();
            this.lblAmarillasValor = new System.Windows.Forms.Label();
            this.lblAmarillasTitulo = new System.Windows.Forms.Label();
            this.panelRojas = new System.Windows.Forms.Panel();
            this.lblRojasValor = new System.Windows.Forms.Label();
            this.lblRojasTitulo = new System.Windows.Forms.Label();
            this.panelMinutos = new System.Windows.Forms.Panel();
            this.lblMinutosValor = new System.Windows.Forms.Label();
            this.lblMinutosTitulo = new System.Windows.Forms.Label();
            this.lblMinutosDetalle = new System.Windows.Forms.Label();
            this.lblSinEstadisticas = new System.Windows.Forms.Label();
            this.panelEquipo = new System.Windows.Forms.Panel();
            this.picEscudoEquipo = new System.Windows.Forms.PictureBox();
            this.lblTituloEquipo = new System.Windows.Forms.Label();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.panelDatosPersonales = new System.Windows.Forms.Panel();
            this.picFotoJugador = new System.Windows.Forms.PictureBox();
            this.lblTituloDatos = new System.Windows.Forms.Label();
            this.lblEdadTitulo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFechaNacTitulo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblAlturaTitulo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoTitulo = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPosicionTitulo = new System.Windows.Forms.Label();
            this.lblPosicionCompleta = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelCabecera.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelEstadisticas.SuspendLayout();
            this.panelPartidos.SuspendLayout();
            this.panelGoles.SuspendLayout();
            this.panelAsistencias.SuspendLayout();
            this.panelAmarillas.SuspendLayout();
            this.panelRojas.SuspendLayout();
            this.panelMinutos.SuspendLayout();
            this.panelEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEscudoEquipo)).BeginInit();
            this.panelDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelCabecera.Controls.Add(this.lblEstado);
            this.panelCabecera.Controls.Add(this.lblNacionalidad);
            this.panelCabecera.Controls.Add(this.lblDorsal);
            this.panelCabecera.Controls.Add(this.lblPosicion);
            this.panelCabecera.Controls.Add(this.lblNombreCompleto);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(643, 87);
            this.panelCabecera.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(557, 17);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            this.lblEstado.Size = new System.Drawing.Size(68, 23);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "ACTIVO";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNacionalidad.ForeColor = System.Drawing.Color.LightGray;
            this.lblNacionalidad.Location = new System.Drawing.Point(129, 59);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(87, 19);
            this.lblNacionalidad.TabIndex = 1;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblDorsal
            // 
            this.lblDorsal.AutoSize = true;
            this.lblDorsal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDorsal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblDorsal.Location = new System.Drawing.Point(77, 56);
            this.lblDorsal.Name = "lblDorsal";
            this.lblDorsal.Size = new System.Drawing.Size(45, 25);
            this.lblDorsal.TabIndex = 2;
            this.lblDorsal.Text = "#10";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblPosicion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPosicion.ForeColor = System.Drawing.Color.White;
            this.lblPosicion.Location = new System.Drawing.Point(21, 59);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.lblPosicion.Size = new System.Drawing.Size(53, 25);
            this.lblPosicion.TabIndex = 3;
            this.lblPosicion.Text = "MED";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNombreCompleto.Location = new System.Drawing.Point(17, 17);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(294, 45);
            this.lblNombreCompleto.TabIndex = 4;
            this.lblNombreCompleto.Text = "Nombre Apellidos";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.panelEstadisticas);
            this.panelContenido.Controls.Add(this.lblSinEstadisticas);
            this.panelContenido.Controls.Add(this.panelEquipo);
            this.panelContenido.Controls.Add(this.panelDatosPersonales);
            this.panelContenido.Controls.Add(this.btnCerrar);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 87);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(643, 390);
            this.panelContenido.TabIndex = 1;
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.BackColor = System.Drawing.Color.White;
            this.panelEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEstadisticas.Controls.Add(this.lblTituloEstadisticas);
            this.panelEstadisticas.Controls.Add(this.panelPartidos);
            this.panelEstadisticas.Controls.Add(this.panelGoles);
            this.panelEstadisticas.Controls.Add(this.panelAsistencias);
            this.panelEstadisticas.Controls.Add(this.panelAmarillas);
            this.panelEstadisticas.Controls.Add(this.panelRojas);
            this.panelEstadisticas.Controls.Add(this.panelMinutos);
            this.panelEstadisticas.Location = new System.Drawing.Point(197, 108);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(429, 200);
            this.panelEstadisticas.TabIndex = 2;
            // 
            // lblTituloEstadisticas
            // 
            this.lblTituloEstadisticas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTituloEstadisticas.Location = new System.Drawing.Point(9, 9);
            this.lblTituloEstadisticas.Name = "lblTituloEstadisticas";
            this.lblTituloEstadisticas.Size = new System.Drawing.Size(171, 22);
            this.lblTituloEstadisticas.TabIndex = 0;
            this.lblTituloEstadisticas.Text = "📊 Estadísticas de Temporada";
            // 
            // panelPartidos
            // 
            this.panelPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panelPartidos.Controls.Add(this.lblPartidosValor);
            this.panelPartidos.Controls.Add(this.lblPartidosTitulo);
            this.panelPartidos.Controls.Add(this.lblPartidosDetalle);
            this.panelPartidos.Location = new System.Drawing.Point(13, 39);
            this.panelPartidos.Name = "panelPartidos";
            this.panelPartidos.Size = new System.Drawing.Size(129, 69);
            this.panelPartidos.TabIndex = 1;
            // 
            // lblPartidosValor
            // 
            this.lblPartidosValor.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblPartidosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblPartidosValor.Location = new System.Drawing.Point(4, 4);
            this.lblPartidosValor.Name = "lblPartidosValor";
            this.lblPartidosValor.Size = new System.Drawing.Size(69, 44);
            this.lblPartidosValor.TabIndex = 0;
            this.lblPartidosValor.Text = "0";
            // 
            // lblPartidosTitulo
            // 
            this.lblPartidosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPartidosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblPartidosTitulo.Location = new System.Drawing.Point(73, 13);
            this.lblPartidosTitulo.Name = "lblPartidosTitulo";
            this.lblPartidosTitulo.Size = new System.Drawing.Size(51, 17);
            this.lblPartidosTitulo.TabIndex = 1;
            this.lblPartidosTitulo.Text = "Partidos";
            // 
            // lblPartidosDetalle
            // 
            this.lblPartidosDetalle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPartidosDetalle.ForeColor = System.Drawing.Color.Gray;
            this.lblPartidosDetalle.Location = new System.Drawing.Point(4, 48);
            this.lblPartidosDetalle.Name = "lblPartidosDetalle";
            this.lblPartidosDetalle.Size = new System.Drawing.Size(120, 17);
            this.lblPartidosDetalle.TabIndex = 2;
            this.lblPartidosDetalle.Text = "0 titular";
            // 
            // panelGoles
            // 
            this.panelGoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.panelGoles.Controls.Add(this.lblGolesValor);
            this.panelGoles.Controls.Add(this.lblGolesTitulo);
            this.panelGoles.Controls.Add(this.lblGolesDetalle);
            this.panelGoles.Location = new System.Drawing.Point(150, 39);
            this.panelGoles.Name = "panelGoles";
            this.panelGoles.Size = new System.Drawing.Size(129, 69);
            this.panelGoles.TabIndex = 2;
            // 
            // lblGolesValor
            // 
            this.lblGolesValor.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblGolesValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblGolesValor.Location = new System.Drawing.Point(4, 4);
            this.lblGolesValor.Name = "lblGolesValor";
            this.lblGolesValor.Size = new System.Drawing.Size(69, 44);
            this.lblGolesValor.TabIndex = 0;
            this.lblGolesValor.Text = "0";
            // 
            // lblGolesTitulo
            // 
            this.lblGolesTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGolesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblGolesTitulo.Location = new System.Drawing.Point(73, 13);
            this.lblGolesTitulo.Name = "lblGolesTitulo";
            this.lblGolesTitulo.Size = new System.Drawing.Size(51, 17);
            this.lblGolesTitulo.TabIndex = 1;
            this.lblGolesTitulo.Text = "Goles";
            // 
            // lblGolesDetalle
            // 
            this.lblGolesDetalle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGolesDetalle.ForeColor = System.Drawing.Color.Gray;
            this.lblGolesDetalle.Location = new System.Drawing.Point(4, 48);
            this.lblGolesDetalle.Name = "lblGolesDetalle";
            this.lblGolesDetalle.Size = new System.Drawing.Size(120, 17);
            this.lblGolesDetalle.TabIndex = 2;
            this.lblGolesDetalle.Text = "0.00 por partido";
            // 
            // panelAsistencias
            // 
            this.panelAsistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.panelAsistencias.Controls.Add(this.lblAsistenciasValor);
            this.panelAsistencias.Controls.Add(this.lblAsistenciasTitulo);
            this.panelAsistencias.Location = new System.Drawing.Point(287, 39);
            this.panelAsistencias.Name = "panelAsistencias";
            this.panelAsistencias.Size = new System.Drawing.Size(129, 69);
            this.panelAsistencias.TabIndex = 3;
            // 
            // lblAsistenciasValor
            // 
            this.lblAsistenciasValor.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAsistenciasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblAsistenciasValor.Location = new System.Drawing.Point(3, 9);
            this.lblAsistenciasValor.Name = "lblAsistenciasValor";
            this.lblAsistenciasValor.Size = new System.Drawing.Size(64, 56);
            this.lblAsistenciasValor.TabIndex = 0;
            this.lblAsistenciasValor.Text = "0";
            // 
            // lblAsistenciasTitulo
            // 
            this.lblAsistenciasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAsistenciasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.lblAsistenciasTitulo.Location = new System.Drawing.Point(65, 4);
            this.lblAsistenciasTitulo.Name = "lblAsistenciasTitulo";
            this.lblAsistenciasTitulo.Size = new System.Drawing.Size(72, 17);
            this.lblAsistenciasTitulo.TabIndex = 1;
            this.lblAsistenciasTitulo.Text = "Asistencias";
            // 
            // panelAmarillas
            // 
            this.panelAmarillas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(196)))));
            this.panelAmarillas.Controls.Add(this.lblAmarillasValor);
            this.panelAmarillas.Controls.Add(this.lblAmarillasTitulo);
            this.panelAmarillas.Location = new System.Drawing.Point(13, 117);
            this.panelAmarillas.Name = "panelAmarillas";
            this.panelAmarillas.Size = new System.Drawing.Size(129, 69);
            this.panelAmarillas.TabIndex = 4;
            // 
            // lblAmarillasValor
            // 
            this.lblAmarillasValor.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblAmarillasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblAmarillasValor.Location = new System.Drawing.Point(4, 4);
            this.lblAmarillasValor.Name = "lblAmarillasValor";
            this.lblAmarillasValor.Size = new System.Drawing.Size(69, 39);
            this.lblAmarillasValor.TabIndex = 0;
            this.lblAmarillasValor.Text = "0";
            // 
            // lblAmarillasTitulo
            // 
            this.lblAmarillasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmarillasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.lblAmarillasTitulo.Location = new System.Drawing.Point(73, 13);
            this.lblAmarillasTitulo.Name = "lblAmarillasTitulo";
            this.lblAmarillasTitulo.Size = new System.Drawing.Size(51, 30);
            this.lblAmarillasTitulo.TabIndex = 1;
            this.lblAmarillasTitulo.Text = "🟨 T. Amarillas";
            // 
            // panelRojas
            // 
            this.panelRojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panelRojas.Controls.Add(this.lblRojasValor);
            this.panelRojas.Controls.Add(this.lblRojasTitulo);
            this.panelRojas.Location = new System.Drawing.Point(150, 117);
            this.panelRojas.Name = "panelRojas";
            this.panelRojas.Size = new System.Drawing.Size(129, 69);
            this.panelRojas.TabIndex = 5;
            // 
            // lblRojasValor
            // 
            this.lblRojasValor.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRojasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblRojasValor.Location = new System.Drawing.Point(4, 4);
            this.lblRojasValor.Name = "lblRojasValor";
            this.lblRojasValor.Size = new System.Drawing.Size(69, 48);
            this.lblRojasValor.TabIndex = 0;
            this.lblRojasValor.Text = "0";
            // 
            // lblRojasTitulo
            // 
            this.lblRojasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRojasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblRojasTitulo.Location = new System.Drawing.Point(73, 13);
            this.lblRojasTitulo.Name = "lblRojasTitulo";
            this.lblRojasTitulo.Size = new System.Drawing.Size(51, 30);
            this.lblRojasTitulo.TabIndex = 1;
            this.lblRojasTitulo.Text = "🟥 T. Rojas";
            // 
            // panelMinutos
            // 
            this.panelMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panelMinutos.Controls.Add(this.lblMinutosValor);
            this.panelMinutos.Controls.Add(this.lblMinutosTitulo);
            this.panelMinutos.Controls.Add(this.lblMinutosDetalle);
            this.panelMinutos.Location = new System.Drawing.Point(287, 117);
            this.panelMinutos.Name = "panelMinutos";
            this.panelMinutos.Size = new System.Drawing.Size(129, 69);
            this.panelMinutos.TabIndex = 6;
            // 
            // lblMinutosValor
            // 
            this.lblMinutosValor.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblMinutosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblMinutosValor.Location = new System.Drawing.Point(4, 4);
            this.lblMinutosValor.Name = "lblMinutosValor";
            this.lblMinutosValor.Size = new System.Drawing.Size(86, 44);
            this.lblMinutosValor.TabIndex = 0;
            this.lblMinutosValor.Text = "0";
            // 
            // lblMinutosTitulo
            // 
            this.lblMinutosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMinutosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblMinutosTitulo.Location = new System.Drawing.Point(90, 13);
            this.lblMinutosTitulo.Name = "lblMinutosTitulo";
            this.lblMinutosTitulo.Size = new System.Drawing.Size(34, 17);
            this.lblMinutosTitulo.TabIndex = 1;
            this.lblMinutosTitulo.Text = "⏱️";
            // 
            // lblMinutosDetalle
            // 
            this.lblMinutosDetalle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMinutosDetalle.ForeColor = System.Drawing.Color.Gray;
            this.lblMinutosDetalle.Location = new System.Drawing.Point(4, 48);
            this.lblMinutosDetalle.Name = "lblMinutosDetalle";
            this.lblMinutosDetalle.Size = new System.Drawing.Size(120, 17);
            this.lblMinutosDetalle.TabIndex = 2;
            this.lblMinutosDetalle.Text = "minutos jugados";
            // 
            // lblSinEstadisticas
            // 
            this.lblSinEstadisticas.BackColor = System.Drawing.Color.White;
            this.lblSinEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinEstadisticas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSinEstadisticas.ForeColor = System.Drawing.Color.Gray;
            this.lblSinEstadisticas.Location = new System.Drawing.Point(197, 108);
            this.lblSinEstadisticas.Name = "lblSinEstadisticas";
            this.lblSinEstadisticas.Size = new System.Drawing.Size(429, 200);
            this.lblSinEstadisticas.TabIndex = 3;
            this.lblSinEstadisticas.Text = "Este jugador aún no tiene estadísticas registradas";
            this.lblSinEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinEstadisticas.Visible = false;
            // 
            // panelEquipo
            // 
            this.panelEquipo.BackColor = System.Drawing.Color.White;
            this.panelEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEquipo.Controls.Add(this.picEscudoEquipo);
            this.panelEquipo.Controls.Add(this.lblTituloEquipo);
            this.panelEquipo.Controls.Add(this.lblNombreEquipo);
            this.panelEquipo.Location = new System.Drawing.Point(197, 13);
            this.panelEquipo.Name = "panelEquipo";
            this.panelEquipo.Size = new System.Drawing.Size(429, 87);
            this.panelEquipo.TabIndex = 1;
            // 
            // picEscudoEquipo
            // 
            this.picEscudoEquipo.BackColor = System.Drawing.Color.Transparent;
            this.picEscudoEquipo.Location = new System.Drawing.Point(13, 30);
            this.picEscudoEquipo.Name = "picEscudoEquipo";
            this.picEscudoEquipo.Size = new System.Drawing.Size(51, 52);
            this.picEscudoEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEscudoEquipo.TabIndex = 0;
            this.picEscudoEquipo.TabStop = false;
            // 
            // lblTituloEquipo
            // 
            this.lblTituloEquipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloEquipo.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloEquipo.Location = new System.Drawing.Point(9, 9);
            this.lblTituloEquipo.Name = "lblTituloEquipo";
            this.lblTituloEquipo.Size = new System.Drawing.Size(86, 17);
            this.lblTituloEquipo.TabIndex = 1;
            this.lblTituloEquipo.Text = "EQUIPO ACTUAL";
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblNombreEquipo.Location = new System.Drawing.Point(73, 39);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(343, 30);
            this.lblNombreEquipo.TabIndex = 2;
            this.lblNombreEquipo.Text = "Nombre del Equipo";
            // 
            // panelDatosPersonales
            // 
            this.panelDatosPersonales.BackColor = System.Drawing.Color.White;
            this.panelDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosPersonales.Controls.Add(this.picFotoJugador);
            this.panelDatosPersonales.Controls.Add(this.lblTituloDatos);
            this.panelDatosPersonales.Controls.Add(this.lblEdadTitulo);
            this.panelDatosPersonales.Controls.Add(this.lblEdad);
            this.panelDatosPersonales.Controls.Add(this.lblFechaNacTitulo);
            this.panelDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.panelDatosPersonales.Controls.Add(this.lblAlturaTitulo);
            this.panelDatosPersonales.Controls.Add(this.lblAltura);
            this.panelDatosPersonales.Controls.Add(this.lblPesoTitulo);
            this.panelDatosPersonales.Controls.Add(this.lblPeso);
            this.panelDatosPersonales.Controls.Add(this.lblPosicionTitulo);
            this.panelDatosPersonales.Controls.Add(this.lblPosicionCompleta);
            this.panelDatosPersonales.Location = new System.Drawing.Point(13, 13);
            this.panelDatosPersonales.Name = "panelDatosPersonales";
            this.panelDatosPersonales.Size = new System.Drawing.Size(172, 295);
            this.panelDatosPersonales.TabIndex = 0;
            // 
            // picFotoJugador
            // 
            this.picFotoJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picFotoJugador.Location = new System.Drawing.Point(34, 13);
            this.picFotoJugador.Name = "picFotoJugador";
            this.picFotoJugador.Size = new System.Drawing.Size(103, 104);
            this.picFotoJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoJugador.TabIndex = 0;
            this.picFotoJugador.TabStop = false;
            // 
            // lblTituloDatos
            // 
            this.lblTituloDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTituloDatos.Location = new System.Drawing.Point(9, 126);
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.Size = new System.Drawing.Size(154, 22);
            this.lblTituloDatos.TabIndex = 1;
            this.lblTituloDatos.Text = "Datos Personales";
            this.lblTituloDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdadTitulo
            // 
            this.lblEdadTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEdadTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblEdadTitulo.Location = new System.Drawing.Point(9, 152);
            this.lblEdadTitulo.Name = "lblEdadTitulo";
            this.lblEdadTitulo.Size = new System.Drawing.Size(69, 17);
            this.lblEdadTitulo.TabIndex = 2;
            this.lblEdadTitulo.Text = "Edad:";
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEdad.Location = new System.Drawing.Point(86, 152);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(77, 17);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "25 años";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaNacTitulo
            // 
            this.lblFechaNacTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaNacTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblFechaNacTitulo.Location = new System.Drawing.Point(9, 173);
            this.lblFechaNacTitulo.Name = "lblFechaNacTitulo";
            this.lblFechaNacTitulo.Size = new System.Drawing.Size(69, 17);
            this.lblFechaNacTitulo.TabIndex = 4;
            this.lblFechaNacTitulo.Text = "Nacimiento:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(86, 173);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(77, 17);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "01/01/2000";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlturaTitulo
            // 
            this.lblAlturaTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlturaTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblAlturaTitulo.Location = new System.Drawing.Point(9, 195);
            this.lblAlturaTitulo.Name = "lblAlturaTitulo";
            this.lblAlturaTitulo.Size = new System.Drawing.Size(69, 17);
            this.lblAlturaTitulo.TabIndex = 6;
            this.lblAlturaTitulo.Text = "Altura:";
            // 
            // lblAltura
            // 
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblAltura.Location = new System.Drawing.Point(86, 195);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(77, 17);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "1.80 m";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPesoTitulo
            // 
            this.lblPesoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPesoTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblPesoTitulo.Location = new System.Drawing.Point(9, 217);
            this.lblPesoTitulo.Name = "lblPesoTitulo";
            this.lblPesoTitulo.Size = new System.Drawing.Size(69, 17);
            this.lblPesoTitulo.TabIndex = 8;
            this.lblPesoTitulo.Text = "Peso:";
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblPeso.Location = new System.Drawing.Point(86, 217);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(77, 17);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "75 kg";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPosicionTitulo
            // 
            this.lblPosicionTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPosicionTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblPosicionTitulo.Location = new System.Drawing.Point(9, 238);
            this.lblPosicionTitulo.Name = "lblPosicionTitulo";
            this.lblPosicionTitulo.Size = new System.Drawing.Size(69, 17);
            this.lblPosicionTitulo.TabIndex = 10;
            this.lblPosicionTitulo.Text = "Posición:";
            // 
            // lblPosicionCompleta
            // 
            this.lblPosicionCompleta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosicionCompleta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblPosicionCompleta.Location = new System.Drawing.Point(86, 238);
            this.lblPosicionCompleta.Name = "lblPosicionCompleta";
            this.lblPosicionCompleta.Size = new System.Drawing.Size(77, 17);
            this.lblPosicionCompleta.TabIndex = 11;
            this.lblPosicionCompleta.Text = "Delantero";
            this.lblPosicionCompleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(531, 321);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormFichaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(643, 477);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFichaJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ficha del Jugador";
            this.Load += new System.EventHandler(this.FormFichaJugador_Load);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelEstadisticas.ResumeLayout(false);
            this.panelPartidos.ResumeLayout(false);
            this.panelGoles.ResumeLayout(false);
            this.panelAsistencias.ResumeLayout(false);
            this.panelAmarillas.ResumeLayout(false);
            this.panelRojas.ResumeLayout(false);
            this.panelMinutos.ResumeLayout(false);
            this.panelEquipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEscudoEquipo)).EndInit();
            this.panelDatosPersonales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJugador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Paneles
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelDatosPersonales;
        private System.Windows.Forms.Panel panelEquipo;
        private System.Windows.Forms.Panel panelEstadisticas;

        // Cabecera
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblDorsal;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEstado;

        // Datos personales
        private System.Windows.Forms.PictureBox picFotoJugador;
        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label lblEdadTitulo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFechaNacTitulo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblAlturaTitulo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPesoTitulo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPosicionTitulo;
        private System.Windows.Forms.Label lblPosicionCompleta;

        // Equipo
        private System.Windows.Forms.PictureBox picEscudoEquipo;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.Label lblTituloEquipo;

        // Estadísticas
        private System.Windows.Forms.Label lblTituloEstadisticas;
        private System.Windows.Forms.Label lblSinEstadisticas;

        private System.Windows.Forms.Panel panelPartidos;
        private System.Windows.Forms.Label lblPartidosValor;
        private System.Windows.Forms.Label lblPartidosTitulo;
        private System.Windows.Forms.Label lblPartidosDetalle;

        private System.Windows.Forms.Panel panelGoles;
        private System.Windows.Forms.Label lblGolesValor;
        private System.Windows.Forms.Label lblGolesTitulo;
        private System.Windows.Forms.Label lblGolesDetalle;

        private System.Windows.Forms.Panel panelAsistencias;
        private System.Windows.Forms.Label lblAsistenciasValor;
        private System.Windows.Forms.Label lblAsistenciasTitulo;

        private System.Windows.Forms.Panel panelAmarillas;
        private System.Windows.Forms.Label lblAmarillasValor;
        private System.Windows.Forms.Label lblAmarillasTitulo;

        private System.Windows.Forms.Panel panelRojas;
        private System.Windows.Forms.Label lblRojasValor;
        private System.Windows.Forms.Label lblRojasTitulo;

        private System.Windows.Forms.Panel panelMinutos;
        private System.Windows.Forms.Label lblMinutosValor;
        private System.Windows.Forms.Label lblMinutosTitulo;
        private System.Windows.Forms.Label lblMinutosDetalle;

        // Botón
        private System.Windows.Forms.Button btnCerrar;
    }
}