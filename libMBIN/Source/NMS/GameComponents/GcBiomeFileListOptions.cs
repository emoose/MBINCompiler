using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1BB6832BA2D5831, NameHash = 0xBA59227C)]
    public class GcBiomeFileListOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBiomeFileListOption> FileOptions;
    }
}
