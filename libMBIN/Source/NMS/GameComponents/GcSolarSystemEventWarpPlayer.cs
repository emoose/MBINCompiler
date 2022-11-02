using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A1AE7643EC73360, NameHash = 0xB4862F5009F24854)]
    public class GcSolarSystemEventWarpPlayer : NMSTemplate
    {
        /* 0x00 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x2C */ public float Time;
    }
}
