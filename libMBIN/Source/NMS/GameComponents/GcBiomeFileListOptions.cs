using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E7AB56982D347BC, NameHash = 0xA0FEA9597B471B4A)]
    public class GcBiomeFileListOptions : NMSTemplate
    {
        /* 0x0 */ public List<GcBiomeFileListOption> FileOptions;
    }
}
