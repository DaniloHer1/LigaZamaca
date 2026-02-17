using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LigaZamaca.Formularios.Splash
{
    /// <summary>
    /// Pantalla de presentación (SplashScreen) de la aplicación Liga Zamaca.
    /// Muestra el logo, nombre de la aplicación y una barra de progreso animada.
    /// </summary>
    public partial class FormSplash : Form
    {
        private Timer timerProgreso;
        private Timer timerCierre;
        private int progreso = 0;
        private int puntosCarga = 0;

        /// <summary>
        /// Constructor del formulario SplashScreen
        /// </summary>
        public FormSplash()
        {
            InitializeComponent();
            ConfigurarTimers();
        }

        /// <summary>
        /// Configura los timers para la animación del splash
        /// </summary>
        private void ConfigurarTimers()
        {
            // Timer para la barra de progreso
            timerProgreso = new Timer();
            timerProgreso.Interval = 30; // Velocidad de la animación
            timerProgreso.Tick += TimerProgreso_Tick;

            // Timer para cerrar el splash después de cargar
            timerCierre = new Timer();
            timerCierre.Interval = 3000; // 3 segundos de visualización
            timerCierre.Tick += TimerCierre_Tick;
        }

        /// <summary>
        /// Evento de carga del formulario
        /// </summary>
        private void FormSplash_Load(object sender, EventArgs e)
        {
            // Centrar en pantalla
            this.CenterToScreen();

            // Iniciar animación
            timerProgreso.Start();
            timerCierre.Start();

            // Actualizar versión y año
            lblVersion.Text = "Versión 1.0";
            lblCopyright.Text = $"© {DateTime.Now.Year} Daniel - Liga Zamaca";
        }

        /// <summary>
        /// Animación de la barra de progreso
        /// </summary>
        private void TimerProgreso_Tick(object sender, EventArgs e)
        {
            if (progreso < 100)
            {
                progreso += 2;
                progressBar.Value = Math.Min(progreso, 100);

                // Actualizar texto de carga con animación de puntos
                puntosCarga = (puntosCarga + 1) % 4;
                string puntos = new string('.', puntosCarga);
                lblEstado.Text = $"Cargando{puntos}";
            }
            else
            {
                timerProgreso.Stop();
                lblEstado.Text = "¡Listo!";
            }
        }

        /// <summary>
        /// Cierra el splash y abre el formulario principal
        /// </summary>
        private void TimerCierre_Tick(object sender, EventArgs e)
        {
            timerCierre.Stop();
            timerProgreso.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Permite cerrar el splash haciendo clic en cualquier parte
        /// </summary>
        private void FormSplash_Click(object sender, EventArgs e)
        {
            // Permite saltar el splash haciendo clic
            if (progreso >= 50) // Solo si ya cargó al menos 50%
            {
                timerCierre.Stop();
                timerProgreso.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Dibuja el fondo con degradado
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear degradado de fondo
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(26, 71, 42),    // Verde oscuro (arriba)
                Color.FromArgb(15, 40, 25),    // Verde más oscuro (abajo)
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        /// <summary>
        /// Limpieza de recursos
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            timerProgreso?.Dispose();
            timerCierre?.Dispose();
        }
    }
}