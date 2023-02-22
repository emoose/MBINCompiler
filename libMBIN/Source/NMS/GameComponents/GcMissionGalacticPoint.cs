namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x216768598125DA74, NameHash = 0xA75A686CCD91261E)]
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
