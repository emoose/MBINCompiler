namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xABEC31B831D9F45, NameHash = 0x5F02C151C26450C8)]
    public class TkCoordinateOrientation : NMSTemplate
    {
        // size: 0x2
        public enum CoordinateOrientationEnum {
            None,
            Random
        }
        /* 0x0 */ public CoordinateOrientationEnum CoordinateOrientation;
    }
}
