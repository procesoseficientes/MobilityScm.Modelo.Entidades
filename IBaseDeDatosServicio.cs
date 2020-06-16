using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using MobilityScm.Modelo.Entidades;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Data.Common;

namespace MobilityScm.Modelo
{
    public interface IBaseDeDatosServicio
    {
        string Esquema { get;    }
        IList<T> ExecuteQuery<T>(string commandText, CommandType commandType, params DbParameter[] parameters);
        IList<T> ExecuteQuery<T>(string commandText, params DbParameter[] parameters);
        int ExecuteNonQuery(string commandText, CommandType commandType, params DbParameter[] parameters);
        int ExecuteNonQuery(string commandText, params DbParameter[] parameters);
        T ExecuteScalar<T>(string commandText, params DbParameter[] parameters);
        T ExecuteScalar<T>(string commandText, CommandType commandType, params DbParameter[] parameters);
        
        IQueryable<SwiftTxn> GetSwiftTxns();
        List<PurchaseOrderDetail> GetSwiftViewSboPurchaseOrderDetails(string docEntry);

        IQueryable<IReturnHeader> GetSwiftViewSboReturnHeaders(string docEntry);
        List<ReturnDetail> GetSwiftViewSboReturnDetails(string docEntry);
        List<ReturnSerieDetail> GetSwiftViewSboReturnSerieDetails(string docEntry, string itemCode);
        IQueryable<IPurchaseOrderHeader> GetSwiftViewSboPurchaseOrderHeaders(string docEntry);
        void Dispose();
        void BeginTransaction();
        void Commit();
        void Rollback();
        void FlushChanges();
        void Insert<T>(T entity);
        void Update<T>(T entity);
        void Delete<T>(T entity);
        List<OrderDetail> GetSwiftViewSboOrderDetails(string docEntry, string docNum);
        IEnumerable<IOrderHeader> GetSwiftViewSboOrderHeaders(string docNum);
        List<PurchaseSerieDetail> GetSwiftViewSboPurchaseSerieDetails( string docEntry,  string itemCode);
        List<OrderSerieDetail> GetSwiftViewSboOrderSerieDetails(string docNum, string docEntry, int lineNum, string itemCode, int transactionId);

        IList<PurchaseSerieDetail> ObtenerSeriesOrdenDeCompra(string referencia);
        IList<OrderSerieDetail> ObtenerSeriesOrdeDeVenta(string docNum, string docEntry);
    }

    public partial class BaseDeDatosServicio : IBaseDeDatosServicio
    {
        public string Esquema => ConfigurationManager.AppSettings.Get("Squema");

        public IList<T> ExecuteQuery<T>(string commandText, CommandType commandType, params DbParameter[] parameters)
        {

            var ls = DataContext.ExecuteQuery<T>(commandText, commandType, parameters);
            DataContext.SaveChanges();
            return ls;
            

        }

        public IList<T> ExecuteQuery<T>(string commandText, params DbParameter[] parameters)
        {

            var ls = DataContext.ExecuteQuery<T>(commandText, parameters);
            DataContext.SaveChanges();
            return ls;

        }



        public int ExecuteNonQuery(string commandText, CommandType commandType, params DbParameter[] parameters)
        {
            return DataContext.ExecuteNonQuery(commandText, commandType, parameters);
        }

        public int ExecuteNonQuery(string commandText, params DbParameter[] parameters)
        {
            return DataContext.ExecuteNonQuery(commandText, parameters);
        }


        public T ExecuteScalar<T>(string commandText, params DbParameter[] parameters)
        {
            return DataContext.ExecuteScalar<T>(commandText, parameters);
        }

        public T ExecuteScalar<T>(string commandText, CommandType commandType, params DbParameter[] parameters)
        {
            return DataContext.ExecuteScalar<T>(commandText, commandType, parameters);
        }

        private BackendConfiguration GetBackendConfiguration()
        {
            return EntitiesModel.GetBackendConfiguration();


        }

        public List<OrderDetail> GetSwiftViewSboOrderDetails(string docEntry, string docNum)
        {
            DbParameter[] parameters = {
                                           new OAParameter
                                           {
                                               ParameterName = "@DOC_NUM",
                                               Value =docNum.ToString()
                                           } ,
                                           new OAParameter
                                           {
                                               ParameterName = "@DOC_ENTRY",
                                               Value = docEntry.ToString()
                                           },
                                           
                                       };


            
            var orderDetails = DataContext.ExecuteQuery<OrderDetail>("SWIFT_SP_GET_SBO_SOD",
                CommandType.StoredProcedure, parameters);
            return orderDetails.ToList();
        }

        public List<PurchaseOrderDetail> GetSwiftViewSboPurchaseOrderDetails(string docEntry)
        {
            DbParameter[] parameters = {
                                           new OAParameter
                                           {
                                               ParameterName = "@DOC_ENTRY",
                                               Value = docEntry.ToString()
                                           },
                                       };



            var purchaseOrderDetails = DataContext.ExecuteQuery<PurchaseOrderDetail>("SWIFT_SP_GET_SBO_POD",
                 CommandType.StoredProcedure, parameters).ToList();
            return purchaseOrderDetails;
        }

        public IQueryable<IReturnHeader> GetSwiftViewSboReturnHeaders(string docEntry)
        {
            DbParameter[] parameters = {new OAParameter
            {
                ParameterName = "@DOC_ENTRY",
                Value = docEntry.ToString()
            }};



            var returnHeaders = DataContext.ExecuteQuery<ReturnHeader>("SWIFT_SP_GET_SBO_RTH",
                 CommandType.StoredProcedure, parameters).AsQueryable();
            return returnHeaders;
        }

        public List<ReturnDetail> GetSwiftViewSboReturnDetails(string docEntry)
        {
            DbParameter[] parameters = {
                                           new OAParameter
                                           {
                                               ParameterName = "@DOC_ENTRY",
                                               Value = docEntry.ToString()
                                           },
                                       };



            var orderDetails = DataContext.ExecuteQuery<ReturnDetail>("SWIFT_SP_GET_SBO_RTD",
                 CommandType.StoredProcedure, parameters).ToList();
            return orderDetails;
        }

        public List<ReturnSerieDetail> GetSwiftViewSboReturnSerieDetails(string docEntry, string itemCode)
        {
            DbParameter[] parameters = {new OAParameter
            {
                ParameterName = "@DOC_ENTRY",
                Value = docEntry
            },new OAParameter
            {
                ParameterName = "@ITEMCODE",
                Value = itemCode
            }
                                       };



            var returnSerieDetails = DataContext.ExecuteQuery<ReturnSerieDetail>("SWIFT_SP_GET_SBO_RTS",
                 CommandType.StoredProcedure, parameters).ToList();
            return returnSerieDetails;
        }

        public IQueryable<IPurchaseOrderHeader> GetSwiftViewSboPurchaseOrderHeaders(string docEntry)
        {
            DbParameter[] parameters = {new OAParameter
            {
                ParameterName = "@DOC_ENTRY",
                Value = docEntry.ToString()
            }};



            var purchaseOrderHeaders = DataContext.ExecuteQuery<PurchaseOrderHeader>("SWIFT_SP_GET_SBO_POH",
                 CommandType.StoredProcedure, parameters).AsQueryable();
            return purchaseOrderHeaders;
        }
      

        public IEnumerable<IOrderHeader> GetSwiftViewSboOrderHeaders(string docNum)
        {
            DbParameter[] parameters = {new OAParameter
            {
                ParameterName = "@DOC_NUM",
                Value = docNum.ToString()
            }};



            var orderHeaders = DataContext.ExecuteQuery<OrderHeader>("SWIFT_SP_GET_SBO_SOH",
                 CommandType.StoredProcedure, parameters).AsQueryable();
            
            return orderHeaders;
        }

        public List<PurchaseSerieDetail> GetSwiftViewSboPurchaseSerieDetails(string docEntry, string itemCode)
        {
            DbParameter[] parameters = {new OAParameter
            {
                ParameterName = "@DOC_ENTRY",
                Value = docEntry
            },new OAParameter
            {
                ParameterName = "@ITEMCODE",
                Value = itemCode
            }
                                       };

            

            var sboPurchaseSerieDetails = DataContext.ExecuteQuery<PurchaseSerieDetail>("SWIFT_SP_GET_SBO_POS",
                 CommandType.StoredProcedure, parameters).ToList();
            return sboPurchaseSerieDetails;
        }

        public List<OrderSerieDetail> GetSwiftViewSboOrderSerieDetails(string docNum, string docEntry, int lineNum, string itemCode, int transactionId)
        {
            DbParameter[] parameters = {
                                           new OAParameter
                                           {
                                               ParameterName = "@DOC_ENTRY",
                                               Value = docEntry
                                           },
                                           new OAParameter
                                           {
                                               ParameterName = "@ITEM_CODE",
                                               Value = itemCode
                                           },
                                           new OAParameter
                                           {
                                               ParameterName = "@LINE_NUM",
                                               Value = lineNum.ToString()
                                           }
                                           ,
                                           new OAParameter
                                           {
                                               ParameterName = "@DOC_NUM",
                                               Value = docNum.ToString()
                                           }
                                           ,
                                           new OAParameter
                                           {
                                               ParameterName = "@TRANS_ID",
                                               Value = transactionId.ToString()
                                           }
                                       };



            var orderSerieDetails = DataContext.ExecuteQuery<OrderSerieDetail>("SWIFT_SP_GET_SBO_SOS",
                 CommandType.StoredProcedure, parameters).ToList();
            return orderSerieDetails;
        }

        public IList<PurchaseSerieDetail> ObtenerSeriesOrdenDeCompra(string referencia)
        {
            DbParameter[] parameters = {new OAParameter
            {
                ParameterName = "@DOC_ENTRY",
                Value = referencia
            }
            };



            var sboPurchaseSerieDetails = DataContext.ExecuteQuery<PurchaseSerieDetail>("SWIFT_SP_GET_SBO_POSS",
                 CommandType.StoredProcedure, parameters).ToList();
            return sboPurchaseSerieDetails;
        }

        public IList<OrderSerieDetail> ObtenerSeriesOrdeDeVenta(string docNum, string docEntry)
        {
            DbParameter[] parameters = {new OAParameter
            {
                ParameterName = "@DOC_NUM",
                Value = docNum
            },
            new OAParameter {
                ParameterName = "@DOC_ENTRY",
                Value = docEntry
            }};

            var orderSerieDetails = DataContext.ExecuteQuery<OrderSerieDetail>("SWIFT_SP_GET_SBO_SOSS",
               CommandType.StoredProcedure, parameters).ToList();
            return orderSerieDetails;

        }

        public void BeginTransaction()
        {

        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }

        public void Rollback()
        {
            DataContext.ClearChanges();
        }

        public void FlushChanges()
        {
            DataContext.FlushChanges();
        }

        public void Insert<T>(T entity)
        {
            DataContext.Add(entity);
        }

        public void Update<T>(T entity)
        {
        }

        public void Delete<T>(T entity)
        {
            DataContext.Delete(entity);
        }

       
    }


}