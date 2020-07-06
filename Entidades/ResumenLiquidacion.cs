using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    /// <summary>
    /// Resumen de liquidación
    /// </summary>
    public class ResumenLiquidacion
    {
        
        /// <summary>
        /// Tipo de documento
        /// </summary>
        public string DOCUMENT_TYPE { get; set; }

        /// <summary>
        /// login
        /// </summary>
        public string LOGIN { get; set; }

        /// <summary>
        /// login
        /// </summary>
        public string NAME_USER { get; set; }

        /// <summary>
        /// Codigo de ruta
        /// </summary>
        public string CODE_ROUTE { get; set; }

        /// <summary>
        /// Nombre de ruta
        /// </summary>
        public string ROUTE_NAME { get; set; }

        /// <summary>
        /// Código SKU
        /// </summary>
        public string CODE_SKU { get; set; }

        /// <summary>
        /// Descripción SKU
        /// </summary>
        public string SKU_DESCRIPTION { get; set; }

        /// <summary>
        /// Inventario inicial
        /// </summary>
        public int IN_INVENTORY{ get; set; }

        /// <summary>
        /// Cantidad
        /// </summary>
        public int OUT_INVENTORY { get; set; }

        /// <summary>
        /// Diferencia
        /// </summary>
        public int DIFERENCE { get; set; }

        /// <summary>
        /// Status de la linea
        /// </summary>
        public string LINE_STATUS { get; set; }
    }
}
