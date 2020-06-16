using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    
    public interface IOrderDetail:ISerializable
    {
        string DocEntry { get; set; }
        decimal? Quantity { get; set; }
        string ItemCode { get; set; }
        string ObjType { get; set; }
        int LineNum { get; set; }
        
        List<OrderSerieDetail> SwiftViewSboOrderSerieDetails { get; set; }
        string DocNum{ get; set; }
        int TransactionId { get; set; }
        
    }
}