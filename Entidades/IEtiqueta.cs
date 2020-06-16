using System;

namespace MobilityScm.Modelo.Entidades
{

    public interface IEtiqueta
    {
        string TAG_COLOR { get; set; }
        string TAG_VALUE_TEXT { get; set; }
        int? TAG_PRIORITY { get; set; }
        string TAG_COMMENTS { get; set; }
        DateTime? LAST_UPDATE { get; set; }
        string LAST_UPDATE_BY { get; set; }
        string TYPE { get; set; }
        int QRY_GROUP { get; set; }
    }
}