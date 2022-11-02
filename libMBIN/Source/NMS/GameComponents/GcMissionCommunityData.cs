using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC96E7E82BB1C4AC1, NameHash = 0xDAB99EB4164B2DF1)]
    public class GcMissionCommunityData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> CommunityMissionsIDs;
        /* 0x10 */ public List<GcMissionCommunityMissionData> CommunityMissionsData;
    }
}
