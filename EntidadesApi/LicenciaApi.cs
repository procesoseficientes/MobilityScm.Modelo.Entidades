using System;
using MobilityScm.Modelo.Tipos;

namespace MobilityScm.Modelo.EntidadesApi
{

    /// <summary>
    /// Entidad que refleja el objeto que se utiliza en el API de Licenciamiento
    /// </summary>
    [Serializable]
    public class LicenciaApi
    {
        public int Id { get; set; }
        public int EnterpriseId { get; set; }
        public int LicenseTypeId { get; set; }
        public int TotalLicenses { get; set; }

        public int LicensesInUse { get; set; }

        public int AvailableLicenses { get; set; }
        public string CommunicationAddress { get; set; }

        public AssignationType AssignationType { get; set; }

        public ValidationTypes ValidationType { get; set; }

        public DateTime DateValidFrom { get; set; }

        public DateTime DateValidTo { get; set; }

        public string WaterMark { get; set; }

        public string InitializationVector { get; set; }
        public string Key { get; set; }

        public Status Status { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        public string LastModifiedBy { get; set; }

        public int Priority { get; set; }
    }
}