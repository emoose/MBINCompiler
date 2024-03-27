namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A71E592A520DD3C, NameHash = 0xDA00E84E26C162C5)]
    public class GcMetaBallComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 File;
        /* 0x80 */ public NMSString0x20 Root;
        /* 0xA0 */ public float Radius;
        /* 0xB0 */ public Vector3f MinSize;
        /* 0xC0 */ public Vector3f MaxSize;
    }
}
