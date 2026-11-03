namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24DC0E3438A09A0C, NameHash = 0xD3539161)]
    public class GcGameTablePetBattlerEvent : NMSTemplate
    {
        // size: 0xA
        public enum PetBattlerEventEnum : uint {
            OnBeforeTurnStart,
            OnBeforeAction,
            OnAfterAction,
            OnAfterTurnEnd,
            OnBuffAdded,
            OnBuffRemoved,
            OnBuffRemovedByHeal,
            OnPetDied,
            OnPetHealthChange,
            OnPetReceivedPayload,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerEventEnum PetBattlerEvent;
    }
}
