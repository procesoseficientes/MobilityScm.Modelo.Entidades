using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SecuenciaDeDocumento
    {

    public int ID_DOCUMENT_SECUENCE { get; set; }

    public string DOC_TYPE { get; set; }

    public DateTime? ASSIGNED_DATETIME { get; set; }

    public DateTime? POST_DATETIME { get; set; }

    public string ASSIGNED_BY { get; set; }

    public int? DOC_FROM { get; set; }

    public int? DOC_TO { get; set; }

    public string SERIE { get; set; }

    public string ASSIGNED_TO { get; set; }

    public int? CURRENT_DOC { get; set; }

    public string STATUS { get; set; }

    public string BRANCH_NAME { get; set; }

    public string BRANCH_ADDRESS { get; set; }

    public int RANK { get; set; }

    public string NAME_ROUTE { get; set; }

    public string DOC_TYPE_DESCRIPTION { get; set; }
        

    }
}
