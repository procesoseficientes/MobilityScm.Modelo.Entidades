using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using MobilityScm.Utilerias;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrderHeader : IOrderHeader
    {
        private List<OrderDetail> _swiftViewSboOrderDetails;


        public List<OrderDetail> SwiftViewSboOrderDetails
        {
             
            get
            {
                ObtenerDetalle(DocEntry, DocNum);


                return _swiftViewSboOrderDetails;
            }
            set { _swiftViewSboOrderDetails = value; }
        }


        private void  ObtenerDetalle(string docEntry, string docNum)
        {
            if (docEntry != "" && docNum != "" && _swiftViewSboOrderDetails==null)
            _swiftViewSboOrderDetails =
                (from detalle in Mvx.Ioc.Resolve<IBaseDeDatosServicio>().GetSwiftViewSboOrderDetails(docEntry, docNum)
                    where detalle.DocEntry == DocEntry.ToString()
                    select detalle).ToList();
        }

        public int TargetEntry
        {
            get;
            set;
        }

        public string DocNum{ get; set; }

        public string DocEntry { get; set; }

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

        public decimal? DiscPrcnt
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string Address2
        {
            get;
            set;
        }

        public string ShipToAddressType
        {
            get;
            set;
        }

        public string ShipToStreet
        {
            get;
            set;
        }

        public string ShipToState
        {
            get;
            set;
        }

        public string ShipToCountry
        {
            get;
            set;
        }

        public short? TrnspCode
        {
            get;
            set;
        }

        public DateTime? DocDueDate
        {
            get;
            set;
        }

        public short? SalesPersoncode
        {
            get;
            set;
        }

        public string Warehouse
        {
            get;
            set;
        }

        public string UEstado2
        {
            get;
            set;
        }

        public string UStatusDespacho
        {
            get;
            set;
        }

        public string UUsuario
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

        public string UTienda
        {
            get;
            set;
        }

        public string USucursal
        {
            get;
            set;
        }

        public string UTipoDocumento
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

        


    }
}