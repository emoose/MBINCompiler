namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x671323D2AB55A3D4, NameHash = 0x207A803)]
    public class GcGameTableNPCEventTrigger : NMSTemplate
    {
        // size: 0xA
        public enum GameTableNPCEventTriggerEnum : uint {
            PlayerVictory,
            PlayerResign,
            PetKO,
            PetSwitch,
            PetRest,
            PetUseMove,
            PetAbilityCrit,
            PetAbilityMiss,
            PetDamaged,
            PetHealed,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GameTableNPCEventTriggerEnum GameTableNPCEventTrigger;
    }
}
