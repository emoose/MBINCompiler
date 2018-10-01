using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC53FEDE00D44F5BF, Broken = true)]
    public class GcProjectileDataTable : NMSTemplate        // size: 0x20
    {
        public List<GcProjectileData> Table;
        public List<GcLaserBeamData> Lasers;
    }
}
