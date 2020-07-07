using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class SecuenciaDocumentosArgumento : EventArgs
    {

        public SecuenciaDeDocumento Data { get; set; }

        public Clasificacion DataClasificacion { get; set; }

    }
}
