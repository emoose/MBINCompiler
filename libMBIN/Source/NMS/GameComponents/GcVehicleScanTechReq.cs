using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90ABE893DE4210FF, NameHash = 0xCC564F1F)]
    public class GcVehicleScanTechReq : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<int> ApplicableSeasons;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 RequiredTech;
    }
}
