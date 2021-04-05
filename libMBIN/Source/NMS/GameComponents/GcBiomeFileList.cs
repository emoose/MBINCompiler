using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x130, Alignment = 0x8, GUID = 0xCA4117113AA28365, NameHash = 0x369AF9F4E4E055D0)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcBiomeFileListOptions[] BiomeFiles;
        /* 0x100 */ public GcBiomeType ValidStartPlanetBiome;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x104 */ public byte[] Padding104;
        /* 0x110 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0x120 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
