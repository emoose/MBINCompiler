using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, Alignment = 0x8, GUID = 0x4E450B0E08ABE9F0, NameHash = 0x369AF9F4E4E055D0)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcBiomeFileListOptions[] BiomeFiles;
        /* 0x100 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0x110 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
