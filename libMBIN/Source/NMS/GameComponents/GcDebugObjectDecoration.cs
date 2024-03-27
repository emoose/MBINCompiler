namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1021F746516C58DF, NameHash = 0x4E8FCD335520B579)]
    public class GcDebugObjectDecoration : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Filename;
        /* 0x80 */ public GcSeed Seed;
        /* 0x90 */ public GcResource Resource;
        /* 0xA0 */ public Vector3f Offset;
        /* 0xB0 */ public Vector3f Local;
        /* 0xC0 */ public Vector3f Facing;
        /* 0xD0 */ public Vector3f Up;
    }
}
