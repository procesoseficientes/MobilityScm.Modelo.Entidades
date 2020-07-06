using System;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// VentaPorMultiploDePromo
    /// </summary>
    [Serializable]
    public class VentaPorMultiploDePromo
    {
        /// <summary>
        /// SKU_SALE_BY_MULTIPLY_ID
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int SWIFT_PROMO_SKU_SALES_BY_MULTIPLE_ID { get; set; }

        /// <summary>
        /// PROMO_ID
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int PROMO_ID { get; set; }

        /// <summary>
        /// CODE_SKU
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string CODE_SKU { get; set; }

        /// <summary>
        /// DESCRIPTION_SKU
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_SKU { get; set; }

        /// <summary>
        /// PACK_UNIT
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int PACK_UNIT { get; set; }

        /// <summary>
        /// DESCRIPTION_PACK_UNIT
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_PACK_UNIT { get; set; }

        /// <summary>
        /// CODE_FAMILY_SKU
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string CODE_FAMILY_SKU { get; set; }

        /// <summary>
        /// DESCRIPTION_FAMILY_SKU
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_FAMILY_SKU { get; set; }

        /// <summary>
        /// MULTIPLE
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int MULTIPLE { get; set; }

    }
}