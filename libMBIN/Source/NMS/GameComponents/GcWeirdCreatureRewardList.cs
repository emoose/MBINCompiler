namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE19496CBBE8242, NameHash = 0x16C7720D83E61CDB)]
    public class GcWeirdCreatureRewardList : NMSTemplate
    {
        [NMS(Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0 */ public NMSString0x10[] Rewards;
    }
}
