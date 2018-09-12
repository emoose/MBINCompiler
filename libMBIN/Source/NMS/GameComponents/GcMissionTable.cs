using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x29F9A029C9F24AF8)]
    public class GcMissionTable : NMSTemplate
    {
        public List<GcGenericMissionSequence> Missions;
    }
}
