using System;
namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Etiqueta : IEtiqueta
    {


        public string TAG_COLOR { get; set; }

        public string TAG_VALUE_TEXT { get; set; }

        public int? TAG_PRIORITY { get; set; }

        public string TAG_COMMENTS { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string TYPE { get; set; }

        public int QRY_GROUP { get; set; }

        public int IS_CONFIG { get; set; }

    }
}
