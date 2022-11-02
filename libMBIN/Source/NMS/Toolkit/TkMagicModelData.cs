using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE0AF56E0A116790, NameHash = 0x1A5D6B5DC6FCD174)]
    public class TkMagicModelData : NMSTemplate
    {
        /* 0x00 */ public List<Vector3f> Vertices;
        /* 0x10 */ public Vector3f Centre;
        /* 0x20 */ public float Radius;
    }
}
