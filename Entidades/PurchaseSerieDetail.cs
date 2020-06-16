using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class PurchaseSerieDetail : IPurchaseSerieDetail
    {
        public int TransactionId
        {
            get ;
            set ;
        }

        public string DocEntry
        {
            get ;
            set ;
        }

        public string ItemCode
        {
            get ;
            set ;
        }

        public int LineNum
        {
            get ;
            set ;
        }

        public string TxnSerie
        {
            get ;
            set ;
        }
        
    }
}