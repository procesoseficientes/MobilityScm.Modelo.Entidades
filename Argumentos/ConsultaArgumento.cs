using System;

namespace MobilityScm.Modelo.Argumentos
{
    public class ConsultaArgumento : EventArgs
    {
        public DateTime FechaInicial { get; set; }

        public DateTime FechaFinal { get; set; }

        public string Login { get; set; }

        public string Ruta { get; set; }
    }
}