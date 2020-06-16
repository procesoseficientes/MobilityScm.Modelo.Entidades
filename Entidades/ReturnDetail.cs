using System;
using System.Collections.Generic;
using System.Linq;
using MobilityScm.Utilerias;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ReturnDetail : IReturnDetail
    {
        private List<ReturnSerieDetail> _swiftViewSboReturnSerieDetails;

        public List<ReturnSerieDetail> SwiftViewSboReturnSerieDetails
        {
            get
            {
                ObtenerSeries(DocEntry,LineNum,ItemCode);


                return _swiftViewSboReturnSerieDetails;
            }
            set { _swiftViewSboReturnSerieDetails = value; }
        }

        private void ObtenerSeries(string docEntry, int lineNum, string itemCode)
        {
            var dEntry = Convert.ToInt16(docEntry); 
            if(docEntry!=null && itemCode!=null && _swiftViewSboReturnSerieDetails==null)
            _swiftViewSboReturnSerieDetails =
                (from detalle in
                    Mvx.Ioc.Resolve<IBaseDeDatosServicio>().GetSwiftViewSboReturnSerieDetails(docEntry, itemCode)
                    where detalle.DocEntry == DocEntry
                          && detalle.ItemCode == ItemCode
                          &&  detalle.TransactionId == TransactionId
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