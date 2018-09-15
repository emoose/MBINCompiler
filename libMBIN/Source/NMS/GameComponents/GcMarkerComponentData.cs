using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xFEC5BA8EA718B369)]
    public class GcMarkerComponentData : NMSTemplate
    {
        /* 0x00 */ public GcGenericIconTypes GenericIconType;
        /* 0x04 */ public float Radius;
		public enum DisplayModeEnum { Always, SpaceOnly, PlanetOnly }
		public DisplayModeEnum DisplayMode;

        /* 0x0C */ public bool ShipScannable;

        [NMS(Size = 3, Ignore = true)]
        public byte[] PaddingD;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string CustomName;
    }
}
