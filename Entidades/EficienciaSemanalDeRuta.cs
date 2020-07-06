using System;
namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class EficienciaSemanalDeRuta
    {
        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string LOGIN { get; set; }

        public string NAME_USER { get; set; }

        public decimal SUNDAY { get; set; }

        public decimal MONDAY { get; set; }

        public decimal TUESDAY { get; set; }
        
        public decimal WEDNESDAY { get; set; }
        
        public decimal THURSDAY { get; set; }

        public decimal FRIDAY { get; set; }

        public decimal SATURDAY { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public DateTime STAR_DATE { get; set; }

        public DateTime END_DATE { get; set; }
        
    }
}
