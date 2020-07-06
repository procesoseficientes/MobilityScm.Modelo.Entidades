using System;
namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Pagina
    {
        public decimal PAGE_ID { get; set; }

        public decimal SURVEY_ID { get; set; }

        public string NAME { get; set; }

        public string DESCRIPTION { get; set; }

        public short ORDER { get; set; }

    }
}