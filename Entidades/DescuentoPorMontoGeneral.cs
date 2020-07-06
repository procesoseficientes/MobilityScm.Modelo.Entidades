using System;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]

    public class DescuentoPorMontoGeneral
    {
        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int TRADE_AGREEMENT_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public decimal LOW_AMOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public decimal HIGH_AMOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public decimal DISCOUNT { get; set; }
    }
}
