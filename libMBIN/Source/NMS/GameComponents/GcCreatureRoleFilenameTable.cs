using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x657D4EC4AA382B6D, NameHash = 0x6668980E)]
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x20, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x000 */ public GcCreatureRoleFilenameList[] WeirdBiomeFiles;
        [NMS(Index = 0, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x200 */ public GcCreatureRoleFilenameList[] BiomeFiles;
        [NMS(Index = 4)]
        /* 0x310 */ public GcCreatureRoleFilenameList AirFiles;
        [NMS(Index = 3)]
        /* 0x320 */ public GcCreatureRoleFilenameList CaveFiles;
        [NMS(Index = 5)]
        /* 0x330 */ public GcCreatureRoleFilenameList RobotFiles;
        [NMS(Index = 1)]
        /* 0x340 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        [NMS(Index = 2)]
        /* 0x350 */ public GcCreatureRoleFilenameList UnderwaterFilesExtra;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x360 */ public float[] LifeChance;
        [NMS(Index = 8, Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0x370 */ public float[] RoleFrequencyModifiers;
    }
}
