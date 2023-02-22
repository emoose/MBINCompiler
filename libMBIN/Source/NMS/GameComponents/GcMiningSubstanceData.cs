using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD1BE90CC526B2B9, NameHash = 0x4FA3A2D9F8D4A156)]
    public class GcMiningSubstanceData : NMSTemplate
    {
        /* 0x0 */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x4 */ public bool UseRarity;
        /* 0x8 */ public GcRarity Rarity;
    }
}
