using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C8D0F7D4CC9EBCC, NameHash = 0x2D9EAD5F5CF5EAF6)]
    public class GcCostProcProduct : NMSTemplate
    {
        /* 0x0 */ public GcProceduralProductCategory Type;
        /* 0x4 */ public bool CareAboutRarity;
        /* 0x8 */ public GcRarity Rarity;
        /* 0xC */ public int FreighterPasswordIndex;
    }
}
