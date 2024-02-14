using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DED22C4351ACE1E, NameHash = 0x26335C55292A7766)]
    public class GcMissionTable : NMSTemplate
    {
        /* 0x0 */ public List<GcGenericMissionSequence> Missions;
    }
}
