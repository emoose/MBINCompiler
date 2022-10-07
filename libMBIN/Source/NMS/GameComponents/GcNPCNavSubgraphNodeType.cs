namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AE92CF900AA3BD4, NameHash = 0xBFFCA397C2DEA0EE)]
    public class GcNPCNavSubgraphNodeType : NMSTemplate
    {
        // size: 0x3
        public enum NPCNavSubgraphNodeTypeEnum {
            Path,
            Connection,
            PointOfInterest
        }
        /* 0x0 */ public NPCNavSubgraphNodeTypeEnum NPCNavSubgraphNodeType;
    }
}
