namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x58A543990E811D50, NameHash = 0x507739C4)]
    public class TkNavMeshPathingQuality : NMSTemplate
    {
        // size: 0x3
        public enum NavMeshPathingQualityEnum : uint {
            Normal,
            High,
            Highest,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshPathingQualityEnum NavMeshPathingQuality;
    }
}
