namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x495B3915CFE27036, NameHash = 0x1E73CF8A2A7FA65D)]
    public class GcScannerIconHighlightTypes : NMSTemplate
    {
        // size: 0x5
        public enum ScannerIconHighlightTypeEnum {
            Diamond,
            Hexagon,
            Tag,
            Octagon,
            Circle
        }
        /* 0x0 */ public ScannerIconHighlightTypeEnum ScannerIconHighlightType;
    }
}
