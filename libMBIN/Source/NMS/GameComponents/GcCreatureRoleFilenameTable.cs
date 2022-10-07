using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD049F5710295C1E0, NameHash = 0x15A053481CA45D03)]
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        // size: 0x10
        public enum BiomeFilesEnum {
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
        [NMS(Size = 0x10, EnumType = typeof(BiomeFilesEnum))]
        /* 0x000 */ public GcCreatureRoleFilenameList[] BiomeFiles;
        /* 0x100 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        /* 0x110 */ public GcCreatureRoleFilenameList UnderwaterFilesExtra;
        /* 0x120 */ public GcCreatureRoleFilenameList CaveFiles;
        /* 0x130 */ public GcCreatureRoleFilenameList AirFiles;
        /* 0x140 */ public GcCreatureRoleFilenameList RobotFiles;
        // size: 0x1B
        public enum WeirdBiomeFilesEnum {
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
        [NMS(Size = 0x1B, EnumType = typeof(WeirdBiomeFilesEnum))]
        /* 0x150 */ public GcCreatureRoleFilenameList[] WeirdBiomeFiles;
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
        public enum RoleFrequencyModifiersEnum {
            Never,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(RoleFrequencyModifiersEnum))]
        /* 0x310 */ public float[] RoleFrequencyModifiers;
    }
}
