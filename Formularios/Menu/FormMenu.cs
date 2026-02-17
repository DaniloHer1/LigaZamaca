using LigaZamaca.Formularios.Clasificacion;
using LigaZamaca.Formularios.Goleadores;
using LigaZamaca.Formularios.Jugador;
using LigaZamaca.Formularios.Partido;
using LigaZamaca.Informes;
using System;
using System.Windows.Forms;
using LigaZamaca.Utilidades;


namespace LigaZamaca.Formularios.Menu
{
    /// <summary>
    /// Formulario principal de la aplicación Liga Zamaca.
    /// Contiene el menú de navegación, barra de menú y barra de estado.
    /// </summary>
    public partial class FormMenu : Form
    {
        private Timer timerReloj;

        /// <summary>
        /// Constructor del formulario del menú principal
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
            ConfigurarTimerReloj();
            AyudaHelper.RegistrarAtajoAyuda(this);
        }

        /// <summary>
        /// Evento de carga del formulario
        /// </summary>
        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Actualizar fecha en el panel superior
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");

            // Actualizar barra de estado
            ActualizarBarraEstado();

            // Iniciar timer del reloj
            timerReloj.Start();
        }

        #region Configuración del Timer

        /// <summary>
        /// Configura el timer para actualizar la hora en la barra de estado
        /// </summary>
        private void ConfigurarTimerReloj()
        {
            timerReloj = new Timer();
            timerReloj.Interval = 1000; // Cada segundo
            timerReloj.Tick += TimerReloj_Tick;
        }

        /// <summary>
        /// Actualiza la hora en la barra de estado cada segundo
        /// </summary>
        private void TimerReloj_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Actualiza toda la información de la barra de estado
        /// </summary>
        private void ActualizarBarraEstado()
        {           
            toolStripStatusLabelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            toolStripStatusLabelEstado.Text = "Conectado";
            toolStripStatusLabelVersion.Text = "v1.0";
        }

        #endregion

        #region Eventos de Botones del Panel Principal

        /// <summary>
        /// Botón Gestión de Equipos
        /// </summary>
        private void btnEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEquipos(), "Equipos");
        }

        /// <summary>
        /// Botón Gestión de Jugadores
        /// </summary>
        private void btnJugadores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormJugador(), "Jugadores");
        }

        /// <summary>
        /// Botón Gestión de Partidos
        /// </summary>
        private void btnPartidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPartidos(), "Partidos");
        }

        /// <summary>
        /// Botón Tabla de Clasificación
        /// </summary>
        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClasificacion(), "Clasificación");
        }

        /// <summary>
        /// Botón Top Goleadores
        /// </summary>
        private void btnGoleadores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormGoleadores(), "Goleadores");
        }

        /// <summary>
        /// Botón Estadísticas
        /// </summary>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo",
                           "Próximamente",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

            // TODO: Descomentar cuando esté listo
            // AbrirFormulario(new FormEstadisticas(), "Estadísticas");
        }

        /// <summary>
        /// Botón Acerca de
        /// </summary>
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MostrarAcercaDe();
        }

        /// <summary>
        /// Botón Salir
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ConfirmarSalida();
        }

        #endregion

        #region Eventos del Menú Principal (MenuStrip)

        // ===== MENÚ ARCHIVO =====

        /// <summary>
        /// Menú Archivo → Salir
        /// </summary>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmarSalida();
        }

        // ===== MENÚ GESTIÓN =====

        /// <summary>
        /// Menú Gestión → Equipos
        /// </summary>
        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEquipos(), "Equipos");
        }

        /// <summary>
        /// Menú Gestión → Jugadores
        /// </summary>
        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormJugador(), "Jugadores");
        }

        /// <summary>
        /// Menú Gestión → Partidos
        /// </summary>
        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPartidos(), "Partidos");
        }

        // ===== MENÚ INFORMES =====

        /// <summary>
        /// Menú Informes → Clasificación
        /// </summary>
        private void clasificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformeClasificacion form = new FormInformeClasificacion();
            form.ShowDialog();
        }

        /// <summary>
        /// Menú Informes → Goleadores
        /// </summary>
        private void goleadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformeGoleadores form = new FormInformeGoleadores();
            form.ShowDialog();
        }

        /// <summary>
        /// Menú Informes → Estadísticas
        /// </summary>
        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformePartidosEquipo form = new FormInformePartidosEquipo();
            form.ShowDialog();
        }

        // ===== MENÚ AYUDA =====

        /// <summary>
        /// Menú Ayuda → Manual de Usuario (F1)
        /// </summary>
        private void manualUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirAyuda();
        }

        /// <summary>
        /// Menú Ayuda → Acerca de
        /// </summary>
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarAcercaDe();
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Abre un formulario hijo y actualiza la barra de estado
        /// </summary>
        /// <param name="formulario">Formulario a abrir</param>
        /// <param name="nombreModulo">Nombre del módulo para la barra de estado</param>
        private void AbrirFormulario(Form formulario, string nombreModulo)
        {
            try
            {
                toolStripStatusLabelEstado.Text = $"Abriendo {nombreModulo}...";
                statusStrip.Refresh();

                formulario.ShowDialog();

                toolStripStatusLabelEstado.Text = "Conectado";
            }
            catch (Exception ex)
            {
                toolStripStatusLabelEstado.Text = "Error";
                MessageBox.Show($"Error al abrir {nombreModulo}: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra el cuadro de diálogo "Acerca de"
        /// </summary>
        private void MostrarAcercaDe()
        {
            MessageBox.Show(
                "Liga Zamaca - Sistema de Gestión de Liga de Fútbol\n\n" +
                "Versión: 1.0\n" +
                "Desarrollado por: Daniel\n" +
                "Año: 2026\n\n",
                "Acerca de Liga Zamaca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Confirma la salida de la aplicación
        /// </summary>
        private void ConfirmarSalida()
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir de la aplicación?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                timerReloj?.Stop();
                timerReloj?.Dispose();
                Application.Exit();
            }
        }

        /// <summary>
        /// Abre la ayuda de la aplicación (F1)
        /// </summary>
        private void AbrirAyuda()
        {
            try
            {
                AyudaHelper.AbrirManual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al abrir la ayuda: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Teclas de Acceso Rápido

        /// <summary>
        /// Procesa las teclas de acceso rápido del formulario
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    AbrirAyuda();
                    return true;

                case Keys.Alt | Keys.F4:
                    ConfirmarSalida();
                    return true;

                case Keys.Control | Keys.E:
                    btnEquipos_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Control | Keys.J:
                    btnJugadores_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Control | Keys.P:
                    btnPartidos_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Control | Keys.C:
                    btnClasificacion_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Control | Keys.G:
                    btnGoleadores_Click(this, EventArgs.Empty);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void informeClasificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformeClasificacion form = new FormInformeClasificacion();
            form.ShowDialog();
        }

        private void informeGoleadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformeGoleadores form = new FormInformeGoleadores();
            form.ShowDialog();
        }

        private void informePartidosEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformePartidosEquipo form = new FormInformePartidosEquipo();
            form.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Limpieza de recursos al cerrar el formulario
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            timerReloj?.Stop();
            timerReloj?.Dispose();
        }

        private void manualTecnicoCHMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaAyuda = System.IO.Path.Combine(Application.StartupPath, "Documentation.chm");

            // 2. Comprobamos que el archivo realmente existe para evitar errores
            if (System.IO.File.Exists(rutaAyuda))
            {
                // 3. Abrimos el archivo de ayuda
                Help.ShowHelp(this, rutaAyuda);
            }
            else
            {
                MessageBox.Show("No se ha encontrado el archivo de ayuda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}