using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE38AF240DDEF7C3, NameHash = 0x499B7E363F46B54F)]
    public class GcMarkerComponentData : NMSTemplate
    {
        /* 0x00 */ public GcGenericIconTypes Icon;
        /* 0x04 */ public float Radius;
        // size: 0x3
        public enum DisplayModeEnum : uint {
            Always,
            SpaceOnly,
            PlanetOnly,
        }
        /* 0x08 */ public DisplayModeEnum DisplayMode;
        /* 0x0C */ public bool ShipScannable;
        /* 0x10 */ public NMSString0x20A CustomName;
        /* 0x30 */ public bool UseCustomIcon;
        /* 0x34 */ public GcRealityGameIcons CustomIcon;
    }
}
