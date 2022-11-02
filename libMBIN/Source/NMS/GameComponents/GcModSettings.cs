using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A5918EF585086AD, NameHash = 0xCB6FA010D5725BB5)]
    public class GcModSettings : NMSTemplate
    {
        /* 0x0 */ public List<GcModSettingsInfo> Data;
    }
}
