using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8625BB36FCA8CFA0, NameHash = 0xE89F09DD)]
    public class GcWeirdCreatureRewardList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x20, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0 */ public NMSString0x10[] Rewards;
    }
}
