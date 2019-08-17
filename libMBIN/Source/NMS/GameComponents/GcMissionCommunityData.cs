using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x217A1A17636245C1, Size = 0x10, SubGUID = 0xDAB99EB4164B2DF1)]
    public class GcMissionCommunityData : NMSTemplate
    {
        public List<NMSString0x10> CommunityMissionsIDs;
    }
}
