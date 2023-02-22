using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x809F465FC44C1F18, NameHash = 0x9439AD97E8673BC0)]
    public class GcProjectileDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcProjectileData> Table;
        /* 0x10 */ public List<GcLaserBeamData> Lasers;
    }
}
