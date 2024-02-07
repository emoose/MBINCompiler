using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF78D54B32ABA4F75, NameHash = 0x76E523097495B90)]
    public class GcPlayerExperienceSpawnData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Archetype;
        /* 0x10 */ public NMSString0x10 AppearAnim;
        /* 0x20 */ public NMSString0x10 SpawnLocator;
        /* 0x30 */ public NMSString0x20A SpawnLocatorScanEvent;
        // size: 0x3
        public enum FaceDirEnum : uint {
            Random,
            TowardsPlayer,
            SpawnerAt,
        }
        /* 0x50 */ public FaceDirEnum FaceDir;
        /* 0x54 */ public float MinDist;
        /* 0x58 */ public float MaxDist;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x5C */ public int[] MinNum;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x6C */ public int[] MaxNum;
        /* 0x7C */ public float ActiveTime;
    }
}
