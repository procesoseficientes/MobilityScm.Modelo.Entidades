using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo
{
    [Serializable]
    public class MasterPackTransaction
    {
        public TransaccionInventario EncabezadoTransaccion { get; set; }
        public List<InventarioDetalle> ListadoSalidaInventario { get; set; }
        public List<InventarioDetalle> ListadoEntradaInventario { get; set; }
    }
}
