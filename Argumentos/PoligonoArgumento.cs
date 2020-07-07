using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class PoligonoArgumento: EventArgs
    {
        public Poligono Poligono { get; set; }

        public PoligonoPuntos PoligonoPunto { get; set; }

        public Vendedor Vendedor { get; set; }

        public Frecuencia Frecuencia { get; set; }

        public List<Poligono> ListaDePoligonos { get; set; }

        public string LOGIN { get; set; }

        public DateTime FechaDe { get; set; }

        public DateTime FechaHasta { get; set; }

        public Etiqueta Etiqueta { get; set; }

        public Canal Canal { get; set; }

        public string TipoAnalisis { get; set; }

        public int? TOP { get; set; }

        public List<string> ListaDeTareas { get; set; }

        public string CHANNEL_ID { get; set; }

        public string TAG_COLOR { get; set; }
        public string Canales { get; set; }
        public string Etiquetas { get; set; }

    }
}
