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
    public class CambiosCliente : ICambiosCliente
    {
        
        private IBaseDeDatosServicio _baseDeDatosServicio;

        private IBaseDeDatosServicio BaseDeDatosServicio => _baseDeDatosServicio ?? (_baseDeDatosServicio = Mvx.Ioc.Resolve<IBaseDeDatosServicio>());

        public int CUSTOMER { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string PHONE_CUSTOMER { get; set; }

        public string ADRESS_CUSTOMER { get; set; }

        public string CONTACT_CUSTOMER { get; set; }

        public string GPS { get; set; }

        public DateTime POSTED_DATETIME { get; set; }

        public string POSTED_BY { get; set; }

        public string CODE_ROUTE { get; set; }

        public string STATUS { get; set; }

        public string STATUS_CHANGE_BY { get; set; }

        public DateTime? STATUS_CHANGE_DATETIME { get; set; }

        public int? ATTEMPTED_WITH_ERROR { get; set; }

        public int? IS_POSTED_ERP { get; set; }

        public DateTime? POSTED_ERP { get; set; }

        public string POSTED_RESPONSE { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string TAX_ID { get; set; }

        public string INVOICE_NAME { get; set; }

        public string FIELD_NAME_FOR_TAX_ID { get; set; }

        private List<Etiqueta> _etiquetas;

        public string DEPARTMENT { get; set; }
        public string MUNICIPALITY { get; set; }
        public string COLONY { get; set; }

        public List<Etiqueta> Etiquetas
        {
            get
            {
                if (CUSTOMER <= 0 || _etiquetas != null) return _etiquetas;
                DbParameter[] parameters =
                {
                    new OAParameter
                    {
                        ParameterName = "@CUSTOMER",
                        Value = CUSTOMER
                    }
                };

                var tags = BaseDeDatosServicio.ExecuteQuery<Etiqueta>("SWIFT_SP_GET_ALL_TAG_BY_CUSTOMER_CHANGE", CommandType.StoredProcedure, parameters);
                _etiquetas = tags.ToList();
                return _etiquetas;
            }
        }

        public string NEW_CUSTOMER_NAME { get; set; }

        public string OWNER { get; set; }
    }
}