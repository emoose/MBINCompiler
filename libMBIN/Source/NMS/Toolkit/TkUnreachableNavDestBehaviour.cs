namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x22FF20C8DAA7012C, NameHash = 0xF7F09C95)]
    public class TkUnreachableNavDestBehaviour : NMSTemplate
    {
        // size: 0x2
        public enum UnreachableNavDestBehaviourEnum : byte {
            ClampToFurthestReachable,
            ContinueOffMesh,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public UnreachableNavDestBehaviourEnum UnreachableNavDestBehaviour;
    }
}
