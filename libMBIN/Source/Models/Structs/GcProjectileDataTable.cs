using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcProjectileDataTable : NMSTemplate        // size: 0x20
    {
        public List<GcProjectileData> Table;
        public List<GcLaserBeamData> Lasers;
    }
}
