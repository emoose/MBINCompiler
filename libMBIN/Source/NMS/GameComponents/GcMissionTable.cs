using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7185CE30AF7AE25F, Broken = true)]
    public class GcMissionTable : NMSTemplate
    {
        public List<GcGenericMissionSequence> Missions;
    }
}
