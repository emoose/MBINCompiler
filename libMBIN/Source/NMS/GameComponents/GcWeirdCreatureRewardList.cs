namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3147BCDA0F39A1E0, NameHash = 0x16C7720D83E61CDB)]
    public class GcWeirdCreatureRewardList : NMSTemplate
    {
        // size: 0x1B
        public enum RewardsEnum {
            None,
            Standard,
            HighQuality,
            Structure,
            Beam,
            Hexagon,
            FractCube,
            Bubble,
            Shards,
            Contour,
            Shell,
            BoneSpire,
            WireCell,
            HydroGarden,
            HugePlant,
            HugeLush,
            HugeRing,
            HugeRock,
            HugeScorch,
            HugeToxic,
            Variant_A,
            Variant_B,
            Variant_C,
            Variant_D,
            Infested,
            Swamp,
            Lava
        }
        [NMS(Size = 0x1B, EnumType = typeof(RewardsEnum))]
        /* 0x0 */ public NMSString0x10[] Rewards;
    }
}
