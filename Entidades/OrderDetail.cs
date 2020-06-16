using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using MobilityScm.Utilerias;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrderDetail : IOrderDetail
    {
        private List<OrderSerieDetail> _swiftViewSboOrderSerieDetails;

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

        

        public List<OrderSerieDetail> SwiftViewSboOrderSerieDetails
        {
            get
            {
                return _swiftViewSboOrderSerieDetails;
            }
            set { _swiftViewSboOrderSerieDetails = value; }
        }

        private void ObtenerSeries(string docNum, string docEntry, int lineNum, string itemCode)
        {
            if (docEntry!=null && itemCode!=null &&  _swiftViewSboOrderSerieDetails==null && TransactionId>0)
            _swiftViewSboOrderSerieDetails =
                (from detalle in
                    Mvx.Ioc.Resolve<IBaseDeDatosServicio>().GetSwiftViewSboOrderSerieDetails(docNum, docEntry, lineNum, itemCode,TransactionId)
                    where detalle.DocEntry == DocEntry
                          && detalle.ItemCode == ItemCode
                          && detalle.LineNum == LineNum
                          && detalle.TransactionId == TransactionId
                    select detalle).ToList();
        }

        public string DocNum
        {
            get ;
            set ;
        }

        public int TransactionId
        {
            get; set; }

        #region ISerializable Implementation
		
		public OrderDetail()
		{
		}
		
		protected OrderDetail(SerializationInfo info, StreamingContext context)
		{
			this.DocEntry = info.GetString("DocEntry");
			this.Quantity = (decimal?)info.GetValue("Quantity", typeof(decimal?));
			this.ItemCode = info.GetString("ItemCode");
			this.ObjType = info.GetString("ObjType");
			this.LineNum = info.GetInt32("LineNum");
		    this.TransactionId = info.GetInt32("TransactionId");

		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("DocEntry", this.DocEntry, typeof(string));
			info.AddValue("Quantity", this.Quantity, typeof(decimal?));
			info.AddValue("ItemCode", this.ItemCode, typeof(string));
			info.AddValue("ObjType", this.ObjType, typeof(string));
			info.AddValue("LineNum", this.LineNum, typeof(int));
            info.AddValue("TransactionId", this.TransactionId,typeof(int));
            info.AddValue("SwiftViewSboOrderSerieDetails", this.SwiftViewSboOrderSerieDetails, typeof(List<OrderSerieDetail>));
		
		}
		
		
		#endregion
    }
}