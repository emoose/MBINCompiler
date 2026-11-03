using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2A503B3706F2600, NameHash = 0x22E64538)]
    public class GcRewardDestructRarities : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0 */ public GcRewardDestructEntry[] Rarities;
    }
}
