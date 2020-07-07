using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class FrecuenciaArgumento : EventArgs
    {
        public Frecuencia Data { get; set; }
        public string XmlDocumentos { get; set; }
        public int UpdateAndInsert { get; set; }
        public string UserID { get; set; }


        /// <summary>
        /// DescuentosPorMontoGeneral
        /// </summary>
        public IList<Frecuencia> Frecuencia { get; set; }

    }
}
