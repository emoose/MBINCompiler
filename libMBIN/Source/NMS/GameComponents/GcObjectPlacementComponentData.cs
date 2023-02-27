namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44119D1A01247A34, NameHash = 0x6520972F5B89CD77)]
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 GroupNodeName;
        // size: 0x2
        public enum ActivationTypeEnum : uint {
            GroupNode,
            Locator,
        }
        /* 0x20 */ public ActivationTypeEnum ActivationType;
        /* 0x24 */ public float FractionOfNodesActive;
        /* 0x28 */ public int MaxNodesActivated;
        /* 0x2C */ public int MaxGroupsActivated;
        /* 0x30 */ public bool UseRaycast;
        /* 0x31 */ public bool UseNodeParent;
    }
}
