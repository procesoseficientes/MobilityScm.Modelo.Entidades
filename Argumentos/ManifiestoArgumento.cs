using System;
using MobilityScm.Modelo.Entidades;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Argumentos
{
    public class ManifiestoArgumento : EventArgs
    {
        public ManifiestoEncabezado ManifiestoEncabezado { get; set; }

        public ManifiestoDetalle ManifiestoDetalle { get; set; }
        
        public IList<ManifiestoDetalle> DetallesManifiesto { get; set; }
        public string Piloto { get; set; }

        public string Ruta { get; set; }

        public string Comentario { get; set; }

        public string Vehiculo { get; set; }

        public string Login { get; set; }
    }
}
