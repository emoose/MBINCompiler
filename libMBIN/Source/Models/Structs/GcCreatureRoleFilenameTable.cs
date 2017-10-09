namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xF0)]
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Test", "All" })]
        /* 0x00 */ public GcCreatureRoleFilenameList[] BiomeFiles;

        /* 0xA0 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        /* 0xB0 */ public GcCreatureRoleFilenameList CaveFiles;
        /* 0xC0 */ public GcCreatureRoleFilenameList AirFiles;
        /* 0xD0 */ public GcCreatureRoleFilenameList RobotFiles;

        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        /* 0xE0 */ public float[] LifeChance;
    }
}
