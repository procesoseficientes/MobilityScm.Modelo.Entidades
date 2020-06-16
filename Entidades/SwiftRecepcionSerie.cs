using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftRecepcionSerie : ISwiftRecepcionSerie
    {
        
        public string docEntry
        {
            get ;
            set ;
        }

        public string ItemCode
        {
            get ;
            set ;
        }

        

        public string TxnSerie
        {
            get ;
            set ;
        }

        // ReSharper disable once InconsistentNaming
        public string STATUS { get; set; }

        
    }
}