using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCA6268733B22F92D, NameHash = 0x6316491205B3FC32)]
    public class TkAnimJointLODData : NMSTemplate
    {
        /* 0x0 */ public int LOD;
        /* 0x8 */ public List<NMSString0x40> JointNames;
    }
}
