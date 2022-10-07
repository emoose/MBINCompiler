using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x122A23E7D278667B, NameHash = 0x270204EDCEE4DB62)]
    public class TkAnimNodeFrameData : NMSTemplate
    {
        /* 0x00 */ public List<ushort> Rotations;
        /* 0x10 */ public List<Vector3f> Translations;
        /* 0x20 */ public List<Vector3f> Scales;
    }
}
