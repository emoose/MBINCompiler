namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x383AE2D7AAB7119E, NameHash = 0xA75A686CCD91261E)]
    public class GcMissionGalacticPoint : NMSTemplate
    {
        // size: 0x2
        public enum GalacticPointEnum {
            Atlas,
            BlackHole,
        }
        /* 0x0 */ public GalacticPointEnum GalacticPoint;
    }
}
