namespace MobilityScm.Modelo.Entidades
{
    public class BroadcastPendiente
    {
        public int? ID_BROADCAST { get; set; }

        public string CODE_BROADCAST { get; set; }

        public string SOURCE_TABLE { get; set; }

        public string SOURCE_KEY { get; set; }

        public string SOURCE_VALUE { get; set; }

        public string STATUS { get; set; }

        public string ADDRESS { get; set; }

        public string OPERATION_TYPE { get; set; }
    }
}