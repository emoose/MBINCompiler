using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDFB78C440DC2E8, NameHash = 0xFABB438AC71DAB8D)]
    public class GcBiomeListPerStarType : NMSTemplate
    {
        // size: 0x4
        public enum StarTypeEnum {
            Yellow,
            Green,
            Blue,
            Red
        }
        [NMS(Size = 0x4, EnumType = typeof(StarTypeEnum))]
        /* 0x000 */ public GcBiomeList[] StarType;
        /* 0x200 */ public GcBiomeList LushYellow;
        /* 0x280 */ public GcBiomeList AbandonedYellow;
        // size: 0x4
        public enum LifeChanceEnum {
            Dead,
            Low,
            Mid,
            Full
        }
        [NMS(Size = 0x4, EnumType = typeof(LifeChanceEnum))]
        /* 0x300 */ public float[] LifeChance;
        // size: 0x4
        public enum AbandonedLifeChanceEnum {
            Dead,
            Low,
            Mid,
            Full
        }
        [NMS(Size = 0x4, EnumType = typeof(AbandonedLifeChanceEnum))]
        /* 0x310 */ public float[] AbandonedLifeChance;
        /* 0x320 */ public float ConvertDeadToWeird;
    }
}
