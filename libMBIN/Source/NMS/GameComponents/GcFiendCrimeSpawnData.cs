using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF786C36972AE4FF7, NameHash = 0x9F76738BACABEAD2)]
    public class GcFiendCrimeSpawnData : NMSTemplate
    {
        /* 0x00 */ public GcCreatureTypes Type;
        /* 0x04 */ public float MinDist;
        /* 0x08 */ public float MaxDist;
        // size: 0x4
        public enum MinNumEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x4, EnumType = typeof(MinNumEnum))]
        /* 0x0C */ public int[] MinNum;
        // size: 0x4
        public enum MaxNumEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxNumEnum))]
        /* 0x1C */ public int[] MaxNum;
    }
}
