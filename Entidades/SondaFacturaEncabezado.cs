using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using MobilityScm.Utilerias;
using Telerik.OpenAccess.Data.Common;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SondaFacturaEncabezado : ISondaFacturaEncabezado
    {
        private  IBaseDeDatosServicio _baseDeDatosServicio;

        private IBaseDeDatosServicio BaseDeDatosServicio => _baseDeDatosServicio ?? (_baseDeDatosServicio = Mvx.Ioc.Resolve<IBaseDeDatosServicio>());

        

        public int INVOICE_ID { get; set; }

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

        public int? IS_POSTED_OFFLINE { get; set; }

        public DateTime? INVOICED_DATETIME { get; set; }

        public int? DEVICE_BATTERY_FACTOR { get; set; }

        public int? CDF_INVOICENUM { get; set; }

        public int? CDF_DOCENTRY { get; set; }

        public string CDF_SERIE { get; set; }

        public string CDF_NIT { get; set; }

        public string CDF_NOMBRECLIENTE { get; set; }

        public string CDF_RESOLUCION { get; set; }

        public DateTime? CDF_POSTED_ERP { get; set; }

        public int IS_CREDIT_NOTE { get; set; }

        public DateTime? VOID_DATETIME { get; set; }

        public int? CDF_PRINTED_COUNT { get; set; }

        public string VOID_REASON { get; set; }

        public string VOID_NOTES { get; set; }

        public int? VOIDED_INVOICE { get; set; }

        public DateTime? CLOSED_ROUTE_DATETIME { get; set; }

        public DateTime? CLEARING_DATETIME { get; set; }

        public int? IS_ACTIVE_ROUTE { get; set; }

        public decimal? SOURCE_CODE { get; set; }

        public string GPS_EXPECTED { get; set; }


        public int? ATTEMPTED_WITH_ERROR { get; set; }

        public int? IS_POSTED_ERP { get; set; }

        public DateTime? POSTED_ERP { get; set; }

        public string POSTED_RESPONSE { get; set; }

        public  string ERP_WAREHOUSE { get; set; }

        public string COST_CENTER { get; set; }

        public string INTERFACE_PAYMENT_TYPE { get; set; }

        public int ID { get; set; }

        private List<SondaFacturaDetalle> _sondaFacturaDetalle;
        public List<SondaFacturaDetalle> SondaFacturaDetalle
        {
            get
            {
                if (INVOICE_ID <= 0 || _sondaFacturaDetalle != null) return _sondaFacturaDetalle;
                DbParameter[] parameters =
                {
                    new OAParameter
                    {
                        ParameterName = "@ID",
                        Value = ID
                    }
                };



                var facturaDetalles =
                    BaseDeDatosServicio.ExecuteQuery<SondaFacturaDetalle>("SWIFT_SP_GET_INVOICE_DETAIL",
                        CommandType.StoredProcedure, parameters);
                _sondaFacturaDetalle= facturaDetalles.ToList();
                return _sondaFacturaDetalle;
            }
        }


        

    }



}