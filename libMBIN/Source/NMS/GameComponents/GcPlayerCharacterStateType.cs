namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x893A2370AC3E78AA, NameHash = 0xB4F01F64)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
        // size: 0x16
        public enum CharacterStateEnum : uint {
            Idle,
            Walk,
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
            Spacewalk,
            SpacewalkAtmosphere,
            LowGWalk,
            LowGRun,
            Fishing,
            GravityGunGrab,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CharacterStateEnum CharacterState;
    }
}
