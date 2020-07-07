using MobilityScm.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Tipos;

namespace MobilityScm.Modelo.Argumentos
{
    public class MetaArgumento : EventArgs
    {
        public Meta meta { get; set; }
        public MetaDetalle metaDetalle { get; set; }
        public IList<MetaDetalle> ObtenerMetaInsertada { get; set; }

        public string EstadosDeMeta { get; set; }
    }
}
