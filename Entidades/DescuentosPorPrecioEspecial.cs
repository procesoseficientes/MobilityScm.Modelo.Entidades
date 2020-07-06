using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// DescuentosPorPrecioEspecial
    /// </summary>
    [Serializable]
    public class DescuentosPorPrecioEspecial
    {
        /// <summary>
        /// Id para obtener del descuento por precio especial. 
        /// </summary>
        public int SPECIAL_PRICE_LIST_BY_SCALE_ID { get; set; }
        /// <summary>
        /// Id de la promocion 
        /// </summary>
        public int? PROMO_ID { get; set; }
        /// <summary>
        /// Codigo del producto. 
        /// </summary>
        public string CODE_SKU { get; set; }
        /// <summary>
        /// Unidad de medida 
        /// </summary>
        public int PACK_UNIT { get; set; }
        /// <summary>
        /// Limite minimo para la promo 
        /// </summary>
        public int LOW_LIMIT { get; set; }
        /// <summary>
        /// limite maximo para la promo 
        /// </summary>
        public int HIGH_LIMIT { get; set; }
        /// <summary>
        /// Descuento 
        /// </summary>
        public decimal DISCOUNT { get; set; }
        /// <summary>
        /// Ultima actualizacion 
        /// </summary>
        public DateTime LAST_UPDATE { get; set; }
        /// <summary>
        /// Incluye descuento
        /// </summary>
        public int INCLUDE_DISCOUNT { get; set; }
        /// <summary>
        /// Descripcion del producto 
        /// </summary>
        public string DESCRIPTION_SKU { get; set; }
        /// <summary>
        /// codigo de familia del producto  
        /// </summary>
        public string CODE_FAMILY_SKU { get; set; }
        /// <summary>
        /// Descripcion del codigo de familia 
        /// </summary>
        public string DESCRIPTION_FAMILY_SKU { get; set; }
        /// <summary>
        /// Descripcion de la unidad de medida 
        /// </summary>
        public string DESCRIPTION_PACK_UNIT { get; set; }
        /// <summary>
        /// tipo de descuento 
        /// </summary>
        public string DISCOUNT_TYPE { get; set; }
        /// <summary>
        /// Precio de la promocion 
        /// </summary>
        public decimal PRICE { get; set; }
    }
}
