using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x562CFE81EB5C57F7, Broken = true)]
    public class GcMarkerComponentData : NMSTemplate
    {
        /* 0x00 */ public GcGenericIconTypes GenericIconType;
        /* 0x04 */ public float Radius;
		public enum DisplayModeEnum { Always, SpaceOnly, PlanetOnly }
		/* 0x08 */ public DisplayModeEnum DisplayMode;
        /* 0x0C */ public bool ShipScannable;
        [NMS(Size = 3, Ignore = true)]
        /* 0x0D */ public byte[] PaddingD;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string CustomName;
        /* 0x30 */ public bool UseCustomIcon;
        /* 0x34 */ public GcRealityGameIcons Customicon;
    }
}
