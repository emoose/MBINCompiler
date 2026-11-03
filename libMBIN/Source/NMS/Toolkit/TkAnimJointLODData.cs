using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1D7DB8330F6E69EF, NameHash = 0xD48D0888)]
    public class TkAnimJointLODData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x40> JointNames;
        [NMS(Index = 0)]
        /* 0x10 */ public int LOD;
    }
}
