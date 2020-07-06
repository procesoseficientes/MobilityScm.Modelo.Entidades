using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Entidad que muestra el encabezado de la orden de venta junto con su respectivo detalle
    /// </summary>
    [Serializable]
    public class OrdenDeVentaConDetalle
    {

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string LOGIN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int ORDER_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int SALES_ORDER_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string TERMS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public DateTime? POSTED_DATETIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string CLIENT_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string POS_TERMINAL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string GPS_URL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal? TOTAL_AMOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? STATUS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string POSTED_BY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IMAGE_1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IMAGE_2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IMAGE_3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? DEVICE_BATTERY_FACTOR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public DateTime? VOID_DATETIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string VOID_REASON { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string VOID_NOTES { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? VOIDED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public DateTime? CLOSED_ROUTE_DATETIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? IS_ACTIVE_ROUTE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string GPS_EXPECTED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? SALES_ORDER_ID_HH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string NAME_CUSTOMER { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string ADRESS_CUSTOMER { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string CONTACT_CUSTOMER { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string CODE_ROUTE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string NAME_ROUTE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public DateTime? DELIVERY_DATE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? IS_PARENT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IS_PARENT_DESCRIPTION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string REFERENCE_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_WAREHOUSE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string DOC_SERIE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int DOC_NUM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IS_VOID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string SALES_ORDER_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int IS_DRAFT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IS_DRAFT_DESCRIPTION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string ASSIGNED_BY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IS_POSTED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int? IS_POSTED_ERP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public DateTime? POSTED_ERP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string POSTED_RESPONSE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal? CREDIT_AMOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal? CASH_AMOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int AUTHORIZED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string AUTHORIZED_BY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public DateTime AUTHORIZED_DATE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int IS_AUTHORIZED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string AUTHORIZED_STATUS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string SALES_ORDERS_IDS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public DateTime SERVER_POSTED_DATETIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string DEVICE_NETWORK_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string IS_POSTED_OFFLINE { get; set; }

        //======== Detalle ==========================

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int CORRELATIVE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string SKU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_SKU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int LINE_SEQ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal QTY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal PRICE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal DISCOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string SERIE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string SERIE_2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int REQUERIES_SERIE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string COMBO_REFERENCE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int PARENT_SEQ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string SKU_DESCRIPTION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal TOTAL_DISCOUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string CODE_PACK_UNIT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string DESCRIPTION_PACK_UNIT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal TOTAL_CD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal TOTAL_LINE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public decimal LONG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string CODE_WAREHOUSE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string NAME_WAREHOUSE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string COMMENT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public int AVAILABLE_QTY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string INTERFACE_OWNER { get; set; }
    }
}
