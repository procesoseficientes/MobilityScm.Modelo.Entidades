using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using MobilityScm.Utilerias;
using Telerik.OpenAccess.Data.Common;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftRecepcionEncabezado : ISwiftRecepcionEncabezado
    {
        private List<SwiftRecepcionDetalle> _swiftRecepcionDetalle;
      


        public List<SwiftRecepcionDetalle> SwiftRecepcionDetalle { get; set; }



    
        public List<SwiftRecepcionSerie> SwiftRecepcionSeries { get; set; }



        public int TargetEntry
        {
            get;
            set;
        }

        public string DocNum
        {
            get;
            set;
        }

        public string DocEntry
        {
            get;
            set;
        }

        public string CardCode
        {
            get;
            set;
        }

        public string CardName
        {
            get;
            set;
        }

        public char HandWritten
        {
            get;
            set;
        }

        public DateTime DocDate
        {
            get;
            set;
        }

        public string Comments
        {
            get;
            set;
        }

        public string DocCur
        {
            get;
            set;
        }

        public decimal? DocRate
        {
            get;
            set;
        }

        public string UFacserie
        {
            get;
            set;
        }

        public string UFacnit
        {
            get;
            set;
        }

        public string UFacnom
        {
            get;
            set;
        }

        public string UFacfecha
        {
            get;
            set;
        }

        public string UTienda
        {
            get;
            set;
        }

        public string UStatusNc
        {
            get;
            set;
        }

        public string UNoExencion
        {
            get;
            set;
        }

        public string UTipoDocumento
        {
            get;
            set;
        }

        public string UUsuario
        {
            get;
            set;
        }

        public string UFacnum
        {
            get;
            set;
        }

        public string USucursal
        {
            get;
            set;
        }

        public string UTotalFlete
        {
            get;
            set;
        }

        public string UTipoPago
        {
            get;
            set;
        }

        public string UCuotas
        {
            get;
            set;
        }

        public string UTotalTarjeta
        {
            get;
            set;
        }

        public string UFechap
        {
            get;
            set;
        }

        public string UTrasladooc
        {
            get;
            set;
        }

        public string NumAtCard
        {
            get;
            set;
        }

    }
}