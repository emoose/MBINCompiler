using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC1D97718BFD9814, NameHash = 0x75E1ADCE47B381E6)]
    public class GcVibrationDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcVibrationChannelData> Data;
    }
}
