using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9791FC6E56341532)]
    public class GcProjectileDataTable : NMSTemplate        // size: 0x20
    {
        public List<GcProjectileData> Table;
        public List<GcLaserBeamData> Lasers;
    }
}
