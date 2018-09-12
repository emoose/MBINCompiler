using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x29F9A029C9F24AF8)]
    public class GcMissionTable : NMSTemplate
    {
        public List<GcGenericMissionSequence> Missions;
    }
}
