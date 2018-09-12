using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9791FC6E56341532)]
    public class GcProjectileDataTable : NMSTemplate        // size: 0x20
    {
        public List<GcProjectileData> Table;
        public List<GcLaserBeamData> Lasers;
    }
}
