using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrderSerieDetail : IOrderSerieDetail
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

        public int SysNumber
        {
            get ;
            set ;
        }

        

    }
}