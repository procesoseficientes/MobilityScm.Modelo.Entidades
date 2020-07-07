using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class PickingArgumento : EventArgs
    {
        public PickingArgumento Data { get; set; }

        public List<PickingDetalle> Detalle { get; set; }

        public List<PickingEncabezado> Encabezados { get; set; }
    }
}
