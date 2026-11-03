namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xACFFCCA3D625B54F, NameHash = 0xD52EBF67)]
    public class TkNavMeshAreaFlags : NMSTemplate
    {
        // size: 0x3
        public enum NavMeshAreaFlagsEnum : byte {
            None,
            Steep,
            LowHeightClearance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAreaFlagsEnum NavMeshAreaFlags;
    }
}
