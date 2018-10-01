using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6F76814613D1BECA, Broken = true)]
    public class GcStats : NMSTemplate
    {
        public List<GcStatsGroup> Stats;
    }
}
