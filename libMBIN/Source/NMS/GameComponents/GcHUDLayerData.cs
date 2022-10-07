using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x773E299A9E36D5F7, NameHash = 0xCA155452FD6149EC)]
    public class GcHUDLayerData : NMSTemplate
    {
        /* 0x00 */ public GcHUDComponent Data;
        /* 0x28 */ public List<NMSTemplate> Children;
    }
}
