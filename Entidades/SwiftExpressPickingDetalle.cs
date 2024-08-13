using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftExpressPickingDetalle : ISwiftExpressPickingDetalle
    {

        public string docEntryErp { get; set; }
        public int DoEntry { get; set; }
        public int Quantity { get; set; }
        public string ItemCode { get; set; }
        public int ObjType { get; set; }
        public int LineNum { get; set; }
        public string ItemDescription { get; set; }
        public string Warehouse { get; set; }
        public double? Price { get; set; }
        public string TaxCode { get; set; }

        public int IS_MASTERPACK { get; set; }
        public int WAS_IMPLODED { get; set; }
        public int ATTEMPTED_WITH_ERROR { get; set; }
        public int IS_POSTED_ERP { get; set; }
        public DateTime? POSTED_ERP { get; set; }
        public string ERP_REFERENCE { get; set; }
        public string POSTED_STATUS { get; set; }
        public string POSTED_RESPONSE { get; set; }
        public string MATERIAL_OWNER { get; set; }
        public string TONE { get; set; }
        public string CALIBER { get; set; }
        public string BATCH { get; set; }
        public string U_FAMILIA { get; set; }
        public decimal DISCOUNT { get; set; }
        public string DISCOUNT_TYPE { get; set; }
        public string AcctCode { get; set; }
        public string CogsAcct { get; set; }
    }
}