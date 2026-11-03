namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAD30D9F3971A28F, NameHash = 0x63D46D77)]
    public class GcPetBattlerMoveState : NMSTemplate
    {
        // size: 0x9
        public enum PetStateEnum : uint {
            None,
            Idle,
            KnockedOut,
            PerformingMoveIntro,
            PerformingMove,
            PerformingMoveOutro,
            PerformingMoveOutroMultiMove,
            PostMovePause,
            PostMovePauseMultiMove,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetStateEnum PetState;
    }
}
