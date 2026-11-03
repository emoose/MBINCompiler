namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3442FE8C3F377A2B, NameHash = 0x4B7625CE)]
    public class GcGameTableNPCEventTriggerOwner : NMSTemplate
    {
        // size: 0x3
        public enum GameTableNPCEventTriggerOwnerEnum : uint {
            Self,
            Opponent,
            AsSpectator,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GameTableNPCEventTriggerOwnerEnum GameTableNPCEventTriggerOwner;
    }
}
