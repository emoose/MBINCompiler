using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A59903ADF762EEC, NameHash = 0xA0FEA9597B471B4A)]
    public class GcBiomeFileListOptions : NMSTemplate
    {
        /* 0x0 */ public List<GcBiomeFileListOption> FileOptions;
    }
}
