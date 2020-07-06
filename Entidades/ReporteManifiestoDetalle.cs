using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Entidad de reporte de manifiesto detalle
    /// </summary>
    [Serializable]
    public class ReporteManifiestoDetalle
    {
        /// <summary>
        /// Código SKU
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// Descripción
        /// </summary>
        public string SKU_DESCRIPTION { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public decimal QTY { get; set; }
        /// <summary>
        /// Precio Total
        /// </summary>
        public decimal TOTAL_AMOUNT { get; set; }
    }
}
