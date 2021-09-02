using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x8E1179E2A9D837B9, NameHash = 0xB219FB318ABC12CF)]
    public class GcBaseBuildingPart : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 ID;
        /* 0x20 */ public List<GcBaseBuildingPartStyleModel> StyleModels;
    }
}
