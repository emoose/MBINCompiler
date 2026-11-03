namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x208B04FCFB95FF18, NameHash = 0xADA5A448)]
    public class GcNPCInteractiveObjectType : NMSTemplate
    {
        // size: 0x9
        public enum NPCInteractiveObjectTypeEnum : uint {
            Idle,
            Generic,
            Chair,
            Conversation,
            WatchShip,
            Shop,
            Dance,
            SpectateGameTable,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCInteractiveObjectTypeEnum NPCInteractiveObjectType;
    }
}
