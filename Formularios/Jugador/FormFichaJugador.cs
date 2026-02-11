using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LigaZamaca.AccesoDatos;
using LigaZamaca.Modelos;

namespace LigaZamaca.Formularios.Jugador
{
    /// <summary>
    /// Formulario que muestra la ficha completa de un jugador con sus estadísticas
    /// </summary>
    public partial class FormFichaJugador : Form
    {
        private int idJugador;
        private JugadorDAO jugadorDAO;
        private EquipoDAO equipoDAO;
        private EstadisticaDAO estadisticaDAO;

        public FormFichaJugador(int idJugador)
        {
            InitializeComponent();
            this.idJugador = idJugador;
            jugadorDAO = new JugadorDAO();
            equipoDAO = new EquipoDAO();
            estadisticaDAO = new EstadisticaDAO();
        }

        private void FormFichaJugador_Load(object sender, EventArgs e)
        {
            CargarFichaJugador();
        }

        /// <summary>
        /// Carga toda la información del jugador
        /// </summary>
        private void CargarFichaJugador()
        {
            try
            {
                // Obtener datos del jugador
                var jugador = jugadorDAO.ObtenerPorId(idJugador);
                if (jugador == null)
                {
                    MessageBox.Show("No se encontró el jugador", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Cargar cabecera
                CargarCabecera(jugador);

                // Cargar datos personales
                CargarDatosPersonales(jugador);

                // Cargar info del equipo
                CargarInfoEquipo(jugador);

                // Cargar estadísticas
                CargarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ficha del jugador: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga la cabecera con nombre, posición y dorsal
        /// </summary>
        private void CargarCabecera(LigaZamaca.Modelos.Jugador jugador)
        {
            // Nombre completo
            lblNombreCompleto.Text = $"{jugador.Nombre} {jugador.Apellidos}";

            // Posición y dorsal
            string posicionCorta = ObtenerPosicionCorta(jugador.Posicion);
            lblPosicion.Text = posicionCorta;
            lblPosicion.BackColor = ObtenerColorPosicion(jugador.Posicion);

            lblDorsal.Text = jugador.Dorsal.HasValue ? $"#{jugador.Dorsal}" : "";

            // Nacionalidad
            lblNacionalidad.Text = jugador.Nacionalidad ?? "Sin especificar";

            // Estado (activo/inactivo)
            lblEstado.Text = jugador.Activo ? "ACTIVO" : "INACTIVO";
            lblEstado.BackColor = jugador.Activo ? Color.FromArgb(76, 175, 80) : Color.FromArgb(244, 67, 54);

            // Título del formulario
            this.Text = $"Ficha de {jugador.Nombre} {jugador.Apellidos}";
        }

        /// <summary>
        /// Carga los datos personales del jugador
        /// </summary>
        private void CargarDatosPersonales(LigaZamaca.Modelos.Jugador jugador)
        {
            // Foto del jugador (placeholder si no hay)
            if (!string.IsNullOrEmpty(jugador.Foto))
            {
                picFotoJugador.Image = CargarImagen(jugador.Foto);
            }
            else
            {
                picFotoJugador.Image = CrearPlaceholderJugador(jugador.Posicion);
            }

            // Edad
            if (jugador.FechaNacimiento.HasValue)
            {
                int edad = jugador.CalcularEdad();
                lblEdad.Text = $"{edad} años";
                lblFechaNacimiento.Text = jugador.FechaNacimiento.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                lblEdad.Text = "-";
                lblFechaNacimiento.Text = "-";
            }

            // Altura
            lblAltura.Text = jugador.Altura.HasValue ? $"{jugador.Altura:F2} m" : "-";

            // Peso
            lblPeso.Text = jugador.Peso.HasValue ? $"{jugador.Peso:F0} kg" : "-";

            // Posición completa
            lblPosicionCompleta.Text = jugador.Posicion ?? "-";
        }

        /// <summary>
        /// Carga la información del equipo
        /// </summary>
        private void CargarInfoEquipo(LigaZamaca.Modelos.Jugador jugador)
        {
            if (jugador.IdEquipo.HasValue)
            {
                var equipo = equipoDAO.ObtenerPorId(jugador.IdEquipo.Value);
                if (equipo != null)
                {
                    lblNombreEquipo.Text = equipo.Nombre;
                    picEscudoEquipo.Image = CargarImagen(equipo.Escudo);
                }
                else
                {
                    lblNombreEquipo.Text = "Sin equipo";
                    picEscudoEquipo.Image = CrearPlaceholderEquipo();
                }
            }
            else
            {
                lblNombreEquipo.Text = "Sin equipo";
                picEscudoEquipo.Image = CrearPlaceholderEquipo();
            }
        }

        /// <summary>
        /// Carga las estadísticas del jugador
        /// </summary>
        private void CargarEstadisticas()
        {
            try
            {
                var stats = estadisticaDAO.ObtenerEstadisticasTotalesJugador(idJugador);

                if (stats.Count > 0)
                {
                    // Partidos
                    int partidos = Convert.ToInt32(stats["PartidosJugados"]);
                    int titular = Convert.ToInt32(stats["PartidosTitular"]);
                    lblPartidosValor.Text = partidos.ToString();
                    lblPartidosDetalle.Text = $"{titular} titular";

                    // Goles
                    int goles = Convert.ToInt32(stats["TotalGoles"]);
                    lblGolesValor.Text = goles.ToString();
                    double promedio = Convert.ToDouble(stats["PromedioGoles"]);
                    lblGolesDetalle.Text = $"{promedio:F2} por partido";

                    // Asistencias
                    int asistencias = Convert.ToInt32(stats["TotalAsistencias"]);
                    lblAsistenciasValor.Text = asistencias.ToString();

                    // Tarjetas amarillas
                    int amarillas = Convert.ToInt32(stats["TotalAmarillas"]);
                    lblAmarillasValor.Text = amarillas.ToString();

                    // Tarjetas rojas
                    int rojas = Convert.ToInt32(stats["TotalRojas"]);
                    lblRojasValor.Text = rojas.ToString();

                    // Minutos
                    int minutos = Convert.ToInt32(stats["MinutosTotales"]);
                    lblMinutosValor.Text = minutos.ToString();
                    lblMinutosDetalle.Text = "minutos jugados";

                    // Mostrar panel de estadísticas
                    panelEstadisticas.Visible = true;
                    lblSinEstadisticas.Visible = false;
                }
                else
                {
                    // Sin estadísticas
                    panelEstadisticas.Visible = false;
                    lblSinEstadisticas.Visible = true;
                    lblSinEstadisticas.Text = "Este jugador aún no tiene estadísticas registradas";
                }
            }
            catch (Exception ex)
            {
                panelEstadisticas.Visible = false;
                lblSinEstadisticas.Visible = true;
                lblSinEstadisticas.Text = $"Error al cargar estadísticas: {ex.Message}";
            }
        }

        #region Métodos auxiliares

        /// <summary>
        /// Obtiene la posición corta (POR, DEF, MED, DEL)
        /// </summary>
        private string ObtenerPosicionCorta(string posicion)
        {
            if (string.IsNullOrEmpty(posicion)) return "?";

            switch (posicion.ToLower())
            {
                case "portero": return "POR";
                case "defensa": return "DEF";
                case "centrocampista": return "MED";
                case "delantero": return "DEL";
                default: return posicion.Substring(0, Math.Min(3, posicion.Length)).ToUpper();
            }
        }

        /// <summary>
        /// Obtiene el color según la posición
        /// </summary>
        private Color ObtenerColorPosicion(string posicion)
        {
            if (string.IsNullOrEmpty(posicion)) return Color.Gray;

            switch (posicion.ToLower())
            {
                case "portero": return Color.FromArgb(255, 152, 0);      // Naranja
                case "defensa": return Color.FromArgb(33, 150, 243);     // Azul
                case "centrocampista": return Color.FromArgb(76, 175, 80); // Verde
                case "delantero": return Color.FromArgb(233, 30, 99);    // Rosa/Rojo
                default: return Color.Gray;
            }
        }

        /// <summary>
        /// Carga una imagen desde URL o ruta local
        /// </summary>
        private Image CargarImagen(string urlImagen)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(urlImagen))
                    return null;

                if (urlImagen.StartsWith("http://") || urlImagen.StartsWith("https://"))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(urlImagen);
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
                else if (File.Exists(urlImagen))
                {
                    return Image.FromFile(urlImagen);
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Crea un placeholder para el jugador
        /// </summary>
        private Image CrearPlaceholderJugador(string posicion)
        {
            Bitmap bmp = new Bitmap(120, 120);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Fondo con color de posición
                Color colorFondo = ObtenerColorPosicion(posicion);
                using (Brush brush = new SolidBrush(Color.FromArgb(100, colorFondo)))
                {
                    g.FillEllipse(brush, 5, 5, 110, 110);
                }

                // Icono de persona
                using (Font font = new Font("Segoe UI", 50))
                using (Brush brush = new SolidBrush(colorFondo))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString("👤", font, brush, new RectangleF(0, 0, 120, 120), sf);
                }
            }
            return bmp;
        }

        /// <summary>
        /// Crea un placeholder para el escudo del equipo
        /// </summary>
        private Image CrearPlaceholderEquipo()
        {
            Bitmap bmp = new Bitmap(80, 80);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Segoe UI", 30))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString("⚽", font, Brushes.Gray, new RectangleF(0, 0, 80, 80), sf);
                }
            }
            return bmp;
        }

        #endregion

        /// <summary>
        /// Botón Cerrar
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}