//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.ServiceModel.DomainServices.Hosting;
using System.ServiceModel.DomainServices.Server;
using Telerik.OpenAccess;
using MobilityScm.Modelo.Entidades;
using Telerik.OpenAccess.Data.Common;

#pragma warning disable 1591

namespace MobilityScm.Modelo	
{    
    [EnableClientAccess()]
    public partial class BaseDeDatosServicio : OpenAccessDomainService <EntitiesModel>
	{
        private class SapPicking
        {
            [Column("ERP_DOC", OpenAccessType = OpenAccessType.Int32, IsNullable = true, Length = 0, Scale = 0, SqlType = "int")]
            public Int32  ErpDoc { get; set; }


            [Column("CUSTOMER_ID", OpenAccessType = OpenAccessType.StringVariableLength, IsNullable = true, Length = 0, Scale = 0, SqlType = "varchar")]
            public string CustomerId { get; set; }
        }


        //private EntitiesModel _dataContext; 


        //protected override EntitiesModel DataContext
        //{
        //    get
        //    {
        //        if ((object) _dataContext == null)
        //        {
        //            _dataContext = new EntitiesModel("");
        //        }

        //    }
        //}


        public BaseDeDatosServicio() : base()
		{
		}

        
        public IQueryable<SwiftTxn> GetSwiftTxns()
		{ 
			return this.DataContext.SwiftTxns;
		}       
		public void DeleteSwiftTxns(SwiftTxn swiftTxn)
		{
			// This is a callback method. The actual Delete is performed internally.
		}

		public void UpdateSwiftTxns(SwiftTxn swiftTxn)
		{
			// This is a callback method. The actual Update is performed internally.
		}

		public void InsertSwiftTxns(SwiftTxn swiftTxn)
		{
			// This is a callback method. The actual Insert is performed internally.
		} 
		
		public void DeleteSwiftViewSboOrderHeaders(OrderHeader orderHeader)
		{
			// This is a callback method. The actual Delete is performed internally.
		}

		public void UpdateSwiftViewSboOrderHeaders(OrderHeader orderHeader)
		{
			// This is a callback method. The actual Update is performed internally.
		}

		public void InsertSwiftViewSboOrderHeaders(OrderHeader orderHeader)
		{
			// This is a callback method. The actual Insert is performed internally.
		} 
		
		

		
	}
}

#pragma warning restore 1591