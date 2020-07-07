using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class InventarioPorBodegaArgumento : EventArgs
    {
        public InventarioPorBodega Data {get;set;}

        public Bodega DataBodega { get; set; }

        public TransferenciaEncabezado DatoTranferenciaEncabezado { get; set; }
    }
}
