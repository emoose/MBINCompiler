namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB4ECED34D2B78698, NameHash = 0x4DB7C299)]
    public class TkNavMeshInclusionType : NMSTemplate
    {
        // size: 0x4
        public enum NavMeshInclusionTypeEnum : byte {
            Auto,
            Ignore,
            Obstacle,
            Walkable,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshInclusionTypeEnum NavMeshInclusionType;
    }
}
