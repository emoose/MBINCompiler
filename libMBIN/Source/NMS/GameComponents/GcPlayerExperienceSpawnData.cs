namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77DC59C00406CFA, NameHash = 0x76E523097495B90)]
    public class GcPlayerExperienceSpawnData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Archetype;
        /* 0x10 */ public NMSString0x10 AppearAnim;
        /* 0x20 */ public NMSString0x10 SpawnLocator;
        /* 0x30 */ public NMSString0x20A SpawnLocatorScanEvent;
        // size: 0x3
        public enum FaceDirEnum {
            Random,
            TowardsPlayer,
            SpawnerAt
        }
        /* 0x50 */ public FaceDirEnum FaceDir;
        /* 0x54 */ public float MinDist;
        /* 0x58 */ public float MaxDist;
        // size: 0x7
        public enum MinNumEnum {
            Unspecified,
            Normal,
            Creative,
            Survival,
            Ambient,
            Permadeath,
            Seasonal
        }
        [NMS(Size = 0x7, EnumType = typeof(MinNumEnum))]
        /* 0x5C */ public int[] MinNum;
        // size: 0x7
        public enum MaxNumEnum {
            Unspecified,
            Normal,
            Creative,
            Survival,
            Ambient,
            Permadeath,
            Seasonal
        }
        [NMS(Size = 0x7, EnumType = typeof(MaxNumEnum))]
        /* 0x78 */ public int[] MaxNum;
        /* 0x94 */ public float ActiveTime;
    }
}
