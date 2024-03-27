using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4D71B061933C6D3, NameHash = 0xB219FB318ABC12CF)]
    public class GcBaseBuildingPart : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A ID;
        /* 0x20 */ public List<GcBaseBuildingPartStyleModel> StyleModels;
    }
}
