using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftRecepcionDetalle : ISwiftRecepcionDetalle
    {

        public string docEntryErp { get; set; }

        public string docEntry
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

        public string ObjType
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




        

 
    }
}