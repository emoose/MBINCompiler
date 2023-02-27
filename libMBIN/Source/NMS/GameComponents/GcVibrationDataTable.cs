using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F805411D9D2FB67, NameHash = 0x75E1ADCE47B381E6)]
    public class GcVibrationDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcVibrationChannelData> Data;
    }
}
