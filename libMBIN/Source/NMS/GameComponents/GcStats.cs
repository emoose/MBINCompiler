using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7889BC093C61EC30)]
    public class GcStats : NMSTemplate
    {
        public List<GcStatsGroup> Stats;
    }
}
