namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC01D849D071969E5, NameHash = 0xC42BE26)]
    public class GcGameTableDiceAutoRollParams : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public float BaseShakeMagnitude;
        [NMS(Index = 12)]
        /* 0x04 */ public float FixedPitchAdjust;
        [NMS(Index = 1)]
        /* 0x08 */ public float LaunchDirectionPitchAngle;
        [NMS(Index = 9)]
        /* 0x0C */ public float LaunchMaxShakeMagnitude;
        [NMS(Index = 6)]
        /* 0x10 */ public float LaunchTransitionAnticipationTime;
        [NMS(Index = 7)]
        /* 0x14 */ public float LaunchTransitionDuration;
        [NMS(Index = 15)]
        /* 0x18 */ public float MinReleaseDerivativePhase;
        [NMS(Index = 14)]
        /* 0x1C */ public float MinReleasePhase;
        [NMS(Index = 11)]
        /* 0x20 */ public float RandomPosVariationFactor;
        [NMS(Index = 5)]
        /* 0x24 */ public float ShakeDurationMin;
        [NMS(Index = 10)]
        /* 0x28 */ public float ShakeFrequency;
        [NMS(Index = 3)]
        /* 0x2C */ public float ShakeOriginRadialOffset;
        [NMS(Index = 2)]
        /* 0x30 */ public float ShakeOriginUpOffset;
        [NMS(Index = 0)]
        /* 0x34 */ public float ShakeStartDirectionPitchAngle;
        [NMS(Index = 4)]
        /* 0x38 */ public float ShakeStartWaitTime;
        [NMS(Index = 13)]
        /* 0x3C */ public float SyncedPitchAdjust;
    }
}
