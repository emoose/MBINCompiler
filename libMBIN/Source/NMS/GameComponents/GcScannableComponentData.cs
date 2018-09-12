using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C, GUID = 0x0C6EAC88A3D6359E5)]
    public class GcScannableComponentData : NMSTemplate
    {
        /* 0x00 */ public float ScanRange;
        [NMS(Size = 0x20)]
        /* 0x04 */ public string ScanName;
        /* 0x24 */ public float ScanTime;
        /* 0x28 */ public float CompassRangeMultiplier;
        /* 0x2C */ public float AlwaysShowRange;
        /* 0x30 */ public bool CantagIcon;

        /* 0x34 */ public GcScannerIconTypes IconType;
		public enum ScannableTypeEnum { Binoculars, Scanner, Marker, None }
		public ScannableTypeEnum ScannableType;
    }
}
