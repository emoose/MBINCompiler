using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x150, GUID = 0x83595753419F7B77)]
    public class GcAudioGlobals : NMSTemplate
    {
        /* 0x00 */ public GcAudioNPCDoppler NPCEngines;
        /* 0x3C */ public GcAudio3PointDopplerData DroneDoppler;
        /* 0x48 */ public float AuxSendCaveRampDistance;
        /* 0x4C */ public float AuxSendOutdoorsRampDistance;
        /* 0x50 */ public float LadderStepDistance;
        /* 0x54 */ public float ShorelineSenseStartUp;
        /* 0x58 */ public float ShorelineSenseProbeDist;
        /* 0x5C */ public float ShorelineSenseBlend;
        /* 0x60 */ public float ShorelineSenseBaseU;
        /* 0x64 */ public Vector2f ShorelineSenseUJitter;
        /* 0x6C */ public Vector2f ShorelineSenseVJitter;
        /* 0x74 */ public Vector2f ShorelineSenseRadius;
        /* 0x7C */ public float ShorelineValidityRate;
        /* 0x80 */ public float ShorelineRTPCSmoothRate;
        /* 0x84 */ public float ShorelineObstructionSmoothRate;
        /* 0x88 */ public float ShorelineObstructionMul;
        /* 0x8C */ public float DroneDopplerExtentsFactor;
        /* 0x90 */ public float DistanceReportMin;
        /* 0x94 */ public float DistanceReportMax;
        /* 0x98 */ public float DistanceSquishScaleToListener;
        /* 0x9C */ public float DistanceSquishMaxTravel;
        /* 0xA0 */ public int ByteBeatMaxGeneratingAudio;
        /* 0xA4 */ public float ByteBeatCrossfadeTime;
        /* 0xA8 */ public float ByteBeatVisualisationTime;
        /* 0xAC */ public int ByteBeatVisualisationMode;
        /* 0xB0 */ public int ByteBeatVisualisationPixelStep;
        /* 0xB4 */ public int ByteBeatVisualisationMiniPixelStep;
        /* 0xB8 */ public int ByteBeatNonSilentAttempts;
        /* 0xBC */ public float ByteBeatNonSilentTime;
        /* 0xC0 */ public float ByteBeatNonSilentAvgInterpSpeed;
        /* 0xC4 */ public float ByteBeatNonSilentSDCutoff;
        /* 0xC8 */ public float ByteBeatBeginAtTonicProbability;
        /* 0xCC */ public float ByteBeatChangeNoteProbability;
        /* 0xD0 */ public float ByteBeatSkipNoteProbability;
        [NMS(Size = 0x7)]
        /* 0xD4 */ public float[] ByteBeatScaleDegreeProbability;
        /* 0xF0 */ public float ByteBeatSpeakerVolumeInterSpeed;
        /* 0xF4 */ public Vector2f ByteBeatSpeakerMaxAmplitude;
        /* 0xFC */ public Vector2f ByteBeatSpeakerMinFrequency;
        /* 0x104 */ public Vector2f ByteBeatSpeakerMaxFrequency;
        /* 0x10C */ public float AtlasStationActiveDistance;
        /* 0x110 */ public float MiniStationActiveDistance;
        /* 0x114 */ public float PlayerDepthUnderwaterMax;
        /* 0x118 */ public float PlayerLowerOffsetEmitterMul;
        /* 0x11C */ public bool ObstructionEnabled;
        /* 0x120 */ public float ObstructionSmoothTime;
        /* 0x124 */ public float ObstructionValueMax;
        /* 0x128 */ public float ObstructionAuxControlWhenVisible;
        /* 0x12C */ public float ObstructionAuxControlWhenHidden;
        /* 0x130 */ public bool PulseMusicEnabled;
        /* 0x131 */ public bool LockListenerMatrix;
        /* 0x132 */ public bool EnableVRSpecificAudio;
        /* 0x134 */ public float ArmFoleySpeedMultiplier;
        /* 0x138 */ public float ArmWhooshFoleyValueTrigger;
        /* 0x13C */ public float MinSecondsBetweenArmWhooshes;
        /* 0x140 */ public Vector2f CommsChatterFalloffFreighers;
        /* 0x148 */ public Vector2f CommsChatterFalloffShips;
    }
}
