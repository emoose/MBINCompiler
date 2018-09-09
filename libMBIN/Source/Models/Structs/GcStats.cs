using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7889BC093C61EC30)]
    public class GcStats : NMSTemplate
    {
        public List<GcStatsGroup> Stats;
    }
}
