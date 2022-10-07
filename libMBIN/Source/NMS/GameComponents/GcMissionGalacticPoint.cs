namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A248F0F98435D2F, NameHash = 0xA75A686CCD91261E)]
    public class GcMissionGalacticPoint : NMSTemplate
    {
        // size: 0x2
        public enum GalacticPointEnum {
            Atlas,
            BlackHole
        }
        /* 0x0 */ public GalacticPointEnum GalacticPoint;
    }
}
