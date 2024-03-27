using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A1BA8C4F06F7526, NameHash = 0x39BE669FF8F8CD9)]
    public class GcSolarSystemLocator : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Name;
        /* 0x20 */ public GcSolarSystemLocatorTypes Type;
        /* 0x30 */ public Vector3f Position;
        /* 0x40 */ public Vector3f Direction;
        /* 0x50 */ public float Radius;
    }
}
