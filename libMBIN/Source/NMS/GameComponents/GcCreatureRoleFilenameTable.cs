using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x280, GUID = 0xD049F5710295C1E0)]
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        [NMS(Size = 0xD, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        /* 0x000 */ public GcCreatureRoleFilenameList[] BiomeFiles;

        /* 0x0D0 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        /* 0x0E0 */ public GcCreatureRoleFilenameList UnderwaterFilesExtra;
        /* 0x0F0 */ public GcCreatureRoleFilenameList CaveFiles;
        /* 0x100 */ public GcCreatureRoleFilenameList AirFiles;
        /* 0x110 */ public GcCreatureRoleFilenameList RobotFiles;

        [NMS(Size = 0x14)]
        /* 0x120 */ public GcCreatureRoleFilenameList[] WeirdBiomeFiles;

        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        /* 0x260 */ public float[] LifeChance;

        [NMS(Size = 4)]
        /* 0x270 */ public float[] RoleFrequencyModifiers;
    }
}
