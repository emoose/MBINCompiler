using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FDCEA82E0047EAF, NameHash = 0xA95856C785F7F5CB)]
    public class GcSubstanceSecondaryBiome : NMSTemplate
    {
        // size: 0x10
        public enum SecondarySubstanceByBiomeEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(SecondarySubstanceByBiomeEnum))]
        /* 0x0 */ public GcSubstanceSecondary[] SecondarySubstanceByBiome;
    }
}
