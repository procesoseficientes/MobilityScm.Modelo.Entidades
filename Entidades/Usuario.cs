using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Tipos;
using System.Xml.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Usuario
    {
        public int CORRELATIVE { get; set; }

        public string LOGIN { get; set; }

        public string NAME_USER { get; set; }

        public string TYPE_USER { get; set; }

        public string PASSWORD { get; set; }

        public string ENTERPRISE { get; set; }

        public string IMAGE { get; set; }

        public string RELATED_SELLER { get; set; }

        public string SELLER_ROUTE { get; set; }

        public string USER_TYPE { get; set; }

        public decimal USER_ROLE { get; set; }

        public string DEFAULT_WAREHOUSE { get; set; }

        public string PRESALE_WAREHOUSE { get; set; }

        public string DOC_SERIE { get; set; }

        public int DOC_NUM { get; set; }

        public string SELLER_NAME { get; set; }

        public int DOC_LEFT { get; set; }

        public int HAVE_ALERT { get; set; }

        public string ROUTE_RETURN_WAREHOUSE { get; set; }

        public int? USE_PACK_UNIT { get; set; }

        public int? ZONE_ID { get; set; }

        public int? DISTRIBUTION_CENTER_ID { get; set; }

        public string CODE_PRICE_LIST { get; set; }

        public int TEAM_ID { get; set; }

        public int LICENSE_ID { get; set; }


        public IList<BodegaConAccesoPorUsuario> BodegasAsociadas { get; set; }

        /// <summary>
        /// Propiedad que indica si el usuario es, Nuevo, Actualizado o Eliminado
        /// </summary>
        public AccionEjecutadaSobreUsuario AccionEjecutadaSobreUsuario { get; set; }

        /// <summary>
        /// Propiedad que indica QUIEN fue la última persona en realizar alguna acción sobre el objeto actual
        /// </summary>
        public string LastUpdateBy { get; set; }
        
    }
}
