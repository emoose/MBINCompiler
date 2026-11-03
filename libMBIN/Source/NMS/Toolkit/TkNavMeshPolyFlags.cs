namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD65C48861EC9E3F9, NameHash = 0xADA2A1CC)]
    public class TkNavMeshPolyFlags : NMSTemplate
    {
        // size: 0x2
        public enum NavMeshPolyFlagsEnum : ushort {
            None,
            TestFlag,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshPolyFlagsEnum NavMeshPolyFlags;
    }
}
