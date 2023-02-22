using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3AED157D9B5E63, NameHash = 0x87C83AD7D0C1D117)]
    public class GcCreatureSwarmData : NMSTemplate
    {
        /* 0x00 */ public int MinCount;
        /* 0x04 */ public int MaxCount;
        /* 0x08 */ public float SwarmMovementSpeed;
        /* 0x0C */ public float SwarmMovementRadius;
        // size: 0x6
        public enum SwarmMovementTypeEnum {
            None,
            Circle,
            Random,
            Search,
            FollowPlayer,
            FollowPlayerLimited,
        }
        /* 0x10 */ public SwarmMovementTypeEnum SwarmMovementType;
        /* 0x18 */ public List<GcCreatureSwarmDataParams> Params;
    }
}
