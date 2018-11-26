using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8F9E2FA26ADDA411)]
    public class GcMissionTable : NMSTemplate
    {
        public List<GcGenericMissionSequence> Missions;
    }
}
