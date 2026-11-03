namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD73E877F9DDE442, NameHash = 0x92011EFC)]
    public class GcNPCNavSubgraphNodeType : NMSTemplate
    {
        // size: 0x3
        public enum NPCNavSubgraphNodeTypeEnum : uint {
            Path,
            Connection,
            PointOfInterest,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCNavSubgraphNodeTypeEnum NPCNavSubgraphNodeType;
    }
}
