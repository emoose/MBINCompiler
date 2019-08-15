using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5CC4805D05B121FD)]
    public class GcScannerIconHighlightTypes : NMSTemplate
    {
        // Size: 0x5
		public enum ScannerIconHighlightTypeEnum { Diamond, Hexagon, Tag, Octagon, Circle }
		public ScannerIconHighlightTypeEnum ScannerIconHighlightType;
    }
}
