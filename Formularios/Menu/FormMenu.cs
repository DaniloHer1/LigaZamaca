using System;
using System.Windows.Forms;
using LigaZamaca.Formularios.Clasificacion;
using LigaZamaca.Formularios.Goleadores;
using LigaZamaca.Formularios.Jugador;
using LigaZamaca.Formularios.Partido;

namespace LigaZamaca.Formularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Configuración inicial si es necesaria
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
        }

        /// <summary>
        /// Botón Gestión de Equipos
        /// </summary>
        private void btnEquipos_Click(object sender, EventArgs e)
        {
            FormEquipos formEquipos = new FormEquipos();
            formEquipos.ShowDialog();
        }

        /// <summary>
        /// Botón Gestión de Jugadores
        /// </summary>
        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FormJugador formJugadores = new FormJugador();
            formJugadores.ShowDialog();
        }

        /// <summary>
        /// Botón Gestión de Partidos
        /// </summary>
        private void btnPartidos_Click(object sender, EventArgs e)
        {
            FormPartidos formPartidos = new FormPartidos();
            formPartidos.ShowDialog();
        }

        /// <summary>
        /// Botón Tabla de Clasificación
        /// </summary>
        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            FormClasificacion formClasificacion  = new FormClasificacion();
            formClasificacion.ShowDialog();

          
        }

        /// <summary>
        /// Botón Top Goleadores
        /// </summary>
        private void btnGoleadores_Click(object sender, EventArgs e)
        {
         
            
             FormGoleadores formGoleadores = new FormGoleadores();
             formGoleadores.ShowDialog();
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

            // TODO: Cuando esté listo, descomentar:
            // FormEstadisticas formEstadisticas = new FormEstadisticas();
            // formEstadisticas.ShowDialog();
        }

        /// <summary>
        /// Botón Salir
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir de la aplicación?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Botón Acerca De
        /// </summary>
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Liga Zamaca - Sistema de Gestión de Liga de Fútbol\n\n" +
                "Versión: 1.0\n" +
                "Desarrollado por: Daniel\n" +
                "Año: 2025\n\n" +
                "Funcionalidades:\n" +
                "✓ Gestión de Equipos\n" +
                "✓ Gestión de Jugadores\n" +
                "✓ Gestión de Partidos\n" +
                "• Estadísticas (Próximamente)\n" +
                "• Clasificación (Próximamente)\n" +
                "• Top Goleadores (Próximamente)",
                "Acerca de Liga Zamaca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}