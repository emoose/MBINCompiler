using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B9263DA69C29E1F, NameHash = 0x72703AC399E3162F)]
    public class GcRewardDestructRarities : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0 */ public GcRewardDestructEntry[] Rarities;
    }
}
