using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    /// <summary>
    /// Bodega por zona
    /// </summary>
    public class BodegasPorZona
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int WAREHOUSE_X_ZONE_ID { get; set; }

        /// <summary>
        /// identificador de la zona
        /// </summary>
        public int? ID_ZONE { get; set; }

        /// <summary>
        /// Codigo de bodega
        /// </summary>
        public string CODE_WAREHOUSE { get; set; }
    }
}
