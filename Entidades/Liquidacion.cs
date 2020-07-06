

using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    /// <summary>
    /// Entidad liquidación 
    /// </summary>
    public class Liquidacion
    {
        /// <summary>
        /// identificador
        /// </summary>
        public long LIQUIDATION_ID { get; set; }

        /// <summary>
        /// Código de ruta
        /// </summary>
        public string CODE_ROUTE { get; set; }

        /// <summary>
        /// Login
        /// </summary>
        public string LOGIN { get; set; }

        /// <summary>
        /// fecha liquidacion
        /// </summary>
        public DateTime LIQUIDATION_DATE { get; set; }

        /// <summary>
        /// Ultima actualización
        /// </summary>
        public DateTime LAST_UPDATE { get; set; }

        /// <summary>
        /// Ultimo que lo actualizo
        /// </summary>
        public string LAST_UPDATE_BY { get; set; }

        /// <summary>
        /// estado de la liquidación
        /// </summary>
        public string LIQUIDATION_STATUS { get; set; }

        /// <summary>
        /// estado del registro
        /// </summary>
        public string STATUS { get; set; }

        /// <summary>
        /// tipo de ruta
        /// </summary>
        public string TYPE_ROUTE { get; set; }

        /// <summary>
        /// Comentario de liquidación
        /// </summary>
        public string LIQUIDATION_COMMENT { get; set; }

        public string NAME_ROUTE { get; set; }

        public string NAME_USER { get; set; }

        public string LAST_UPDATE_NAME { get; set; }

        public string USER_TYPE { get; set; }

        public string TYPE_USER_DESCRIPTION { get; set; }

        public string SELLER_CODE { get; set; }

        public string SELLER_NAME { get; set; }
    }
}
