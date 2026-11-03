using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAFE6ABF1C0B0132, NameHash = 0x363A73C6)]
    public class GcItemCostTable : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "ID")]
        /* 0x0 */ public HashMap<GcItemCostData> Items;
    }
}
