using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6724B54D8FFD4E52, NameHash = 0x7D347F979E52A1C1)]
    public class GcActionSets : NMSTemplate
    {
        public List<GcActionSet> ActionSets;
    }
}
