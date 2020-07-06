using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Vendedor
    {
        public string SELLER_CODE { get; set; }

        public string SELLER_NAME { get; set; }

        public int ASSIGNED_VEHICLE_CODE { get; set; }

        public int ASSIGNED_DISTRIBUTION_CENTER { get; set; }

        public string LOGIN { get; set; }

        public string USER_ROLE { get; set; }

        public string DEFAULT_WAREHOUSE { get; set; }

        public string SELLER_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }
        
        public string DESCRIPTION_WAREHOUSE { get; set; }

        public int ROUTE { get; set; }

        public int SALES_OFFICE_ID { get; set; }

        public string PHONE1 { get; set; }

        public string PHONE2 { get; set; }

        public string EMAIL { get; set; }

    }
}
