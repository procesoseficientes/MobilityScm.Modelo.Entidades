using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    /// <summary>
    /// Detalle de documentos en liquidación
    /// </summary>
    public class DetalleDocumentoLiquidacion
    {
        public string DOCUMENT_TYPE { get; set; }

        public string DOC_RESOLUTION { get; set; }

        public string DOC_SERIE { get; set; }
        /// <summary>
        /// Numero documento
        /// </summary>
        public int DOC_NUM { get; set; }


        public string CODE_SKU { get; set; }

        public string SKU_DESCRIPTION { get; set; }
        
        /// <summary>
        /// Precio
        /// </summary>
        public decimal PRICE { get; set; }

        /// <summary>
        /// Cantidad
        /// </summary>
        public int QTY { get; set; }

        /// <summary>
        /// Total 
        /// </summary>
        public decimal TOTAL_AMOUNT { get; set; }
    }
}
