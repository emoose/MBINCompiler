namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D0ED87BF140E413, NameHash = 0x415580A8)]
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        // size: 0x3
        public enum ActivationTypeEnum : uint {
            GroupNode,
            Locator,
            GroupNodeSelect,
        }
        [NMS(Index = 1)]
        /* 0x00 */ public ActivationTypeEnum ActivationType;
        [NMS(Index = 2)]
        /* 0x04 */ public float FractionOfNodesActive;
        [NMS(Index = 4)]
        /* 0x08 */ public int MaxGroupsActivated;
        [NMS(Index = 3)]
        /* 0x0C */ public int MaxNodesActivated;
        [NMS(Index = 5)]
        /* 0x10 */ public int NumGroupsToSelect;
        [NMS(Index = 0)]
        /* 0x14 */ public NMSString0x20 GroupNodeName;
        [NMS(Index = 7)]
        /* 0x34 */ public bool UseNodeAsParent;
        [NMS(Index = 6)]
        /* 0x35 */ public bool UseRaycast;
    }
}
