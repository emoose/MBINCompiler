using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBiomeFileList : NMSTemplate      // size: 0xC0
    {
        [NMS(Size = 0xA, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Test", "All" })]
        /* 0x00 */ public GcBiomeFileListOptions[] BiomeFiles;

        /* 0xA0 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0xB0 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
