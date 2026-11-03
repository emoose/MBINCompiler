using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98AAD5B780D876F4, NameHash = 0xD20552DB)]
    public class GcPetBattleCamera : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 2)]
        /* 0x20 */ public GcPetBattleCameraPose End;
        [NMS(Index = 1)]
        /* 0x38 */ public GcPetBattleCameraPose Start;
        [NMS(Index = 4)]
        /* 0x50 */ public float Duration;
        [NMS(Index = 5)]
        /* 0x54 */ public float FOV;
        // size: 0x2
        public enum InterpModeEnum : uint {
            Orbit,
            Linear,
        }
        [NMS(Index = 3)]
        /* 0x58 */ public InterpModeEnum InterpMode;
        [NMS(Index = 7)]
        /* 0x5C */ public float PetPhaseSlowValue;
        [NMS(Index = 6)]
        /* 0x60 */ public GcPetBattlerMoveState SlowBeforePetPhase;
        [NMS(Index = 8)]
        /* 0x64 */ public TkCurveType EaseType;
    }
}
