using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class DescuentoPorEscalaDePromo
    {
        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int PROMO_IDENTITY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int PROMO_DISCOUNT_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int PROMO_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string CODE_SKU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_SKU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int PACK_UNIT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_PACK_UNIT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int LOW_LIMIT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// // ReSharper disable once InconsistentNaming
        public int HIGH_LIMIT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal DISCOUNT { get; set; }

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

        public int IS_UPDATE { get; set; }

        /// <summary>
        /// Reference if the discount is unique to apply 
        /// </summary>
        public int IS_UNIQUE { get; set; }

        /// <summary>
        /// Reference if the discount is unique to apply 
        /// </summary>
        public string UNIQUE { get; set; }
    }
}