namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC44A46D0ED42C3AC, NameHash = 0xEA11CE48)]
    public class TkCoordinateOrientation : NMSTemplate
    {
        // size: 0x2
        public enum CoordinateOrientationEnum : uint {
            None,
            Random,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CoordinateOrientationEnum CoordinateOrientation;
    }
}
