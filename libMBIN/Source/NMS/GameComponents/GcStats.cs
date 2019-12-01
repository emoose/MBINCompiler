using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD309E0875930D8B2, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        public List<GcStatsGroup> Stats;
    }
}
