namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5198BF8A16C55353, NameHash = 0xBFFCA397C2DEA0EE)]
    public class GcNPCNavSubgraphNodeType : NMSTemplate
    {
        // size: 0x3
        public enum NPCNavSubgraphNodeTypeEnum : uint {
            Path,
            Connection,
            PointOfInterest,
        }
        /* 0x0 */ public NPCNavSubgraphNodeTypeEnum NPCNavSubgraphNodeType;
    }
}
