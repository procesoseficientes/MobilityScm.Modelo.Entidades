using System;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrdenDeVentaEncabezado
    {

        public string LOGIN { get; set; }
        public int SALES_ORDER_ID { get; set; }

        public string TERMS { get; set; }

        public DateTime? POSTED_DATETIME { get; set; }

        public string CLIENT_ID { get; set; }

        public string POS_TERMINAL { get; set; }

        public string GPS_URL { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public int? STATUS { get; set; }

        public string POSTED_BY { get; set; }

        public string IMAGE_1 { get; set; }

        public string IMAGE_2 { get; set; }

        public string IMAGE_3 { get; set; }

        public int? DEVICE_BATTERY_FACTOR { get; set; }

        public DateTime? VOID_DATETIME { get; set; }

        public string VOID_REASON { get; set; }

        public string VOID_NOTES { get; set; }

        public int? VOIDED { get; set; }

        public DateTime? CLOSED_ROUTE_DATETIME { get; set; }

        public int? IS_ACTIVE_ROUTE { get; set; }

        public string GPS_EXPECTED { get; set; }

        public int? SALES_ORDER_ID_HH { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string ADRESS_CUSTOMER { get; set; }

        public string CONTACT_CUSTOMER { get; set; }
        
        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public DateTime? DELIVERY_DATE { get; set; }

        public int? IS_PARENT { get; set; }

        public string IS_PARENT_DESCRIPTION { get; set; }

        public string REFERENCE_ID { get; set; }

        public string CODE_WAREHOUSE { get; set; }

        public string DESCRIPTION_WAREHOUSE { get; set; }

        public string DOC_SERIE { get; set; }

        public int DOC_NUM { get; set; }

        public string IS_VOID { get; set; }

        public string SALES_ORDER_TYPE { get; set; }

        public decimal DISCOUNT { get; set; }

        public int IS_DRAFT { get; set; }

        public string IS_DRAFT_DESCRIPTION { get; set; }

        public string ASSIGNED_BY { get; set; }

        public decimal TOTAL_CD { get; set; }

        public int IS_POSTED_ERP { get; set; }

        public string IS_POSTED_ERP_DESCRIPTION { get; set; }

        public decimal? CREDIT_AMOUNT { get; set; }

        public decimal? CASH_AMOUNT { get; set; }

        public IList<OrdenDeVentaDetalle> Detalles { get; set; }

        public int AUTHORIZED { get; set; }

        public string AUTHORIZED_BY { get; set; }

        public DateTime AUTHORIZED_DATE { get; set; }

        public int IS_AUTHORIZED { get; set; }
        public string AUTHORIZED_STATUS { get; set; }

        public string SALES_ORDERS_IDS { get; set; }

        public DateTime SERVER_POSTED_DATETIME { get; set; }

        public string DEVICE_NETWORK_TYPE { get; set; }

        public int IS_POSTED_OFFLINE { get; set; }
    }
}