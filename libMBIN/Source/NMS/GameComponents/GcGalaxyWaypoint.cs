using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0x2D42DA20AA74B61E, NameHash = 0x562052A8272CC4A3)]
    public class GcGalaxyWaypoint : NMSTemplate
    {
        /* 0x00 */ public GcGalacticAddressData Address;
        /* 0x14 */ public GcGalaxyWaypointTypes Type;
        [NMS(Size = 0x20)]
        /* 0x18 */ public string EventId;
    }
}
