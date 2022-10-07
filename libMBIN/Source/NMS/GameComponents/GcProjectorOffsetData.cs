using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB560F06E5F3D3F59, NameHash = 0xB9DD91F357A56979)]
    public class GcProjectorOffsetData : NMSTemplate
    {
        /* 0x00 */ public float Scale;
        /* 0x10 */ public GcInWorldUIScreenData Active;
        /* 0x40 */ public GcInWorldUIScreenData Inactive;
    }
}
