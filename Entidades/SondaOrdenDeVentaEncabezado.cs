using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using MobilityScm.Utilerias;
using Telerik.OpenAccess.Data.Common;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SondaOrdenDeVentaEncabezado : ISondaOrdenDeVentaEncabezado 
    {

        private  IBaseDeDatosServicio _baseDeDatosServicio;

        private IBaseDeDatosServicio BaseDeDatosServicio => _baseDeDatosServicio ?? (_baseDeDatosServicio = Mvx.Ioc.Resolve<IBaseDeDatosServicio>());

      
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

        public DateTime? DELIVERY_DATE { get; set; }

        public int? SALES_ORDER_ID_HH { get; set; }

        public int? ATTEMPTED_WITH_ERROR { get; set; }

        public int? IS_POSTED_ERP { get; set; }

        public DateTime? POSTED_ERP { get; set; }

        public string POSTED_RESPONSE { get; set; }

        public string WAREHOUSE { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string NAME_CUSTOMER { get; set; }
        public string TAX_ID_NUMBER { get; set; }
        public string ADRESS_CUSTOMER { get; set; }

        private List<SondaOrdenDeVentaDetalle> _sondaOrdenDeVentaDetalle;

        public  List<SondaOrdenDeVentaDetalle> SondaOrdenDeVentaDetalle
        {
            get
            {
                if (SALES_ORDER_ID <= 0 || _sondaOrdenDeVentaDetalle != null) return _sondaOrdenDeVentaDetalle;
                DbParameter[] parameters =
                {
                    new OAParameter
                    {
                        ParameterName = "@SALES_ORDER_ID",
                        Value = SALES_ORDER_ID
                    },new OAParameter
                    {
                        ParameterName = "@INTERFACE_OWNER",
                        Value = INTERFACE_OWNER
                    },new OAParameter
                    {
                        ParameterName = "@CUSTOMER_OWNER",
                        Value = CLIENT_OWNER
                    }
                };



                var orderDetails =
                    BaseDeDatosServicio.ExecuteQuery<SondaOrdenDeVentaDetalle>("SWIFT_SP_GET_SALE_ORDER_DETAIL",
                        CommandType.StoredProcedure, parameters);
                _sondaOrdenDeVentaDetalle= orderDetails.ToList();
                return _sondaOrdenDeVentaDetalle;
            }
        }

        public string SALES_PERSON_CODE { get; set; }
        public string SALES_ORDER_TYPE { get; set; }

        public string OFIVENTAS { get; set; }
        public string RUTAVENTAS { get; set; }
        public string RUTAENTREGA { get; set; }
        
        public string NUM_AT_CARD { get; set; }

        public string SONDA { get; set; }

        public string COMMENT { get; set; }

        public int IS_SCOUTING { get; set; }

        public string ORGVENTAS { get; set; }

        public int EXTRA_DAYS { get; set; }

        public string PAYMENT_CONDITIONS { get; set; }
        public string OWNER { get; set; }
        public string INTERFACE_OWNER { get; set; }
        public string CLIENT_OWNER { get; set; }
    }

}