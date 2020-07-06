using System;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// DescuentoPorMontoGeneralDePromo
    /// </summary>
    [Serializable]
    public class DescuentoPorMontoGeneralDePromo
    {
        /// <summary>
        /// DISCOUNT_BY_GENERAL_AMOUNT_ID
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int DISCOUNT_BY_GENERAL_AMOUNT_ID { get; set; }

        /// <summary>
        /// PROMO_ID
        /// </summary>
        // ReSharper disable once InconsistentNaming

        public int PROMO_IDENTITY { get; set; }

        public int PROMO_ID { get; set; }

        /// <summary>
        /// LOW_AMOUNT
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public double LOW_AMOUNT { get; set; }

        /// <summary>
        /// HIGH_AMOUNT
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public double HIGH_AMOUNT { get; set; }

        /// <summary>
        /// DISCOUNT
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public double DISCOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string DISCOUNT_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string CODE_FAMILY_SKU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_FAMILY_SKU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int IS_UPDATE { get; set; }

        /// <summary>
        /// Tipo de pago por familia 
        /// </summary>
        public string PAYMENT_TYPE { get; set; }


    }
}