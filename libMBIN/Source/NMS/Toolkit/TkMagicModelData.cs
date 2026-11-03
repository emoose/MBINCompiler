using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD48EBA925C798D46, NameHash = 0x69215F3)]
    public class TkMagicModelData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Centre;
        [NMS(Index = 0)]
        /* 0x10 */ public List<Vector3f> Vertices;
        [NMS(Index = 2)]
        /* 0x20 */ public float Radius;
    }
}
