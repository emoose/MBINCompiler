namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x747121EF90EDBAAC, NameHash = 0x6C6EDC3D5C0DA932)]
    public class GcNPCInteractiveObjectType : NMSTemplate
    {
        // size: 0x8
        public enum NPCInteractiveObjectTypeEnum {
            Idle,
            Generic,
            Chair,
            Conversation,
            WatchShip,
            Shop,
            Dance,
            None
        }
        /* 0x0 */ public NPCInteractiveObjectTypeEnum NPCInteractiveObjectType;
    }
}
