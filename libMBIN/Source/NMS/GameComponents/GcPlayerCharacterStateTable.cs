using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70FCB377A9D4E58C, NameHash = 0xDE03C95CFD766DA8)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        // size: 0x12
        public enum CharacterStatesEnum {
            Idle,
            Jog,
            JogUphill,
            JogDownhill,
            SteepSlope,
            Sliding,
            Run,
            Airborne,
            JetpackBoost,
            RocketBoots,
            Riding,
            Swimming,
            SwimmingJetpack,
            Death,
            FullBodyOverride,
            InSpace,
            LowGWalk,
            LowGRun
        }
        [NMS(Size = 0x12, EnumType = typeof(CharacterStatesEnum))]
        /* 0x0 */ public GcPlayerCharacterStateData[] CharacterStates;
    }
}
