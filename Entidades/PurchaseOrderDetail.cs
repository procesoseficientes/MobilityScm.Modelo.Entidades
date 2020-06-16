using System;
using System.Collections.Generic;
using System.Linq;
using MobilityScm.Utilerias;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class PurchaseOrderDetail : IPurchaseOrderDetail
    {
        private List<PurchaseSerieDetail> _swiftViewSboPurchaseSerieDetails;

        public List<PurchaseSerieDetail> SwiftViewSboPurchaseSerieDetails
        {
            get
            {
               // ObtenerSeries(DocNum,DocEntry,LineNum,ItemCode);


                return _swiftViewSboPurchaseSerieDetails;
            }
            set { _swiftViewSboPurchaseSerieDetails = value; }
        }

        private void ObtenerSeries(string docNum, string docEntry, int lineNum, string itemCode)
        {
            if(docEntry!=null && itemCode!=null && _swiftViewSboPurchaseSerieDetails==null)
            _swiftViewSboPurchaseSerieDetails =
                (from detalle in
                    Mvx.Ioc.Resolve<IBaseDeDatosServicio>().GetSwiftViewSboPurchaseSerieDetails(docEntry, itemCode)
                    where detalle.DocEntry == DocEntry
                          && detalle.ItemCode == ItemCode
                          && detalle.TransactionId == TransactionId 
                    select detalle).ToList();
        }

        public string DocNum
        {
            get ;
            set ;
        }

        public string DocEntry
        {
            get ;
            set ;
        }

        public decimal? Quantity
        {
            get ;
            set ;
        }

        public string ItemCode
        {
            get ;
            set ;
        }

        public string Objtype
        {
            get ;
            set ;
        }

        public int LineNum
        {
            get ;
            set ;
        }

        public string WarehouseCode
        {
            get ;
            set ;
        }

        public string SalesUnit
        {
            get ;
            set ;
        }

        public int TransactionId { get; set; }

        public decimal QuantityErp { get; set; }

        public string docEntryErp { get; set; }

        
    }
}