using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CB4538036FB3C3B, NameHash = 0xE386FFCF32C92476)]
    public class GcSeasonTransferInventoryData : NMSTemplate
    {
        /* 0x00 */ public int SeasonId;
        /* 0x08 */ public GcInventoryLayout Layout;
        /* 0x28 */ public GcInventoryContainer Inventory;
    }
}
