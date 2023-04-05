using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBCCB4AC2CBE23A48, NameHash = 0x9F76738BACABEAD2)]
    public class GcFiendCrimeSpawnData : NMSTemplate
    {
        /* 0x00 */ public GcCreatureTypes Type;
        /* 0x04 */ public float MinDist;
        /* 0x08 */ public float MaxDist;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x0C */ public int[] MinNum;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x1C */ public int[] MaxNum;
    }
}
