namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x540A930A52C0384E, NameHash = 0xBFFCA397C2DEA0EE)]
    public class GcNPCNavSubgraphNodeType : NMSTemplate
    {
        // size: 0x3
        public enum NPCNavSubgraphNodeTypeEnum {
            Path,
            Connection,
            PointOfInterest,
        }
        /* 0x0 */ public NPCNavSubgraphNodeTypeEnum NPCNavSubgraphNodeType;
    }
}
