using MobilityScm.Modelo.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class LicenciaDetalle
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DeviceIdentfier { get; set; }
        public Status Status { get; set;} 
        public DateTime? ActivationDate { get; set; }
        public string CodeRoute { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public string LastModifiedBy { get; set; }
        public int LicenseId { get; set; }
    }
}
