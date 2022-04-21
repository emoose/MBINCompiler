using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x168, GUID = 0x916D68D153BCF764, NameHash = 0x7B6EECDDCAF6F923)]
    public class GcAudioGlobals : NMSTemplate
    {
        /* 0x000 */ public GcAudioNPCDoppler NPCEngines;
        /* 0x048 */ public GcAudio3PointDopplerData DroneDoppler;
        /* 0x054 */ public float AuxSendCaveRampDistance;
        /* 0x058 */ public float AuxSendOutdoorsRampDistance;
        /* 0x05C */ public float LadderStepDistance;
        /* 0x060 */ public float ShorelineSenseStartUp;
        /* 0x064 */ public float ShorelineSenseProbeDist;
        /* 0x068 */ public float ShorelineSenseBlend;
        /* 0x06C */ public float ShorelineSenseBaseU;
        /* 0x070 */ public Vector2f ShorelineSenseUJitter;
        /* 0x078 */ public Vector2f ShorelineSenseVJitter;
        /* 0x080 */ public Vector2f ShorelineSenseRadius;
        /* 0x088 */ public float ShorelineValidityRate;
        /* 0x08C */ public float ShorelineRTPCSmoothRate;
        /* 0x090 */ public float ShorelineObstructionSmoothRate;
        /* 0x094 */ public float ShorelineObstructionMul;
        /* 0x098 */ public float DroneDopplerExtentsFactor;
        /* 0x09C */ public float DistanceReportMin;
        /* 0x0A0 */ public float DistanceReportMax;
        /* 0x0A4 */ public float DistanceSquishScaleToListener;
        /* 0x0A8 */ public float DistanceSquishMaxTravel;
        /* 0x0AC */ public int ByteBeatMaxGeneratingAudio;
        /* 0x0B0 */ public float ByteBeatCrossfadeTime;
        /* 0x0B4 */ public float ByteBeatVisualisationTime;
        /* 0x0B8 */ public int ByteBeatVisualisationMode;
        /* 0x0BC */ public int ByteBeatVisualisationPixelStep;
        /* 0x0C0 */ public int ByteBeatVisualisationMiniPixelStep;
        /* 0x0C4 */ public int ByteBeatNonSilentAttempts;
        /* 0x0C8 */ public float ByteBeatNonSilentTime;
        /* 0x0CC */ public float ByteBeatNonSilentAvgInterpSpeed;
        /* 0x0D0 */ public float ByteBeatNonSilentSDCutoff;
        /* 0x0D4 */ public float ByteBeatBeginAtTonicProbability;
        /* 0x0D8 */ public float ByteBeatChangeNoteProbability;
        /* 0x0DC */ public float ByteBeatSkipNoteProbability;
        /* 0x0E0 */ public List<float> ByteBeatScaleDegreeProbability;
        /* 0x0F0 */ public float ByteBeatSpeakerVolumeInterSpeed;
        /* 0x0F4 */ public Vector2f ByteBeatSpeakerMaxAmplitude;
        /* 0x0FC */ public Vector2f ByteBeatSpeakerMinFrequency;
        /* 0x104 */ public Vector2f ByteBeatSpeakerMaxFrequency;
        /* 0x10C */ public int ByteBeatPlayerNumLoops;
        /* 0x110 */ public float ByteBeatPlayerFadeOut;
        /* 0x114 */ public float ByteBeatDrumMixLow;
        /* 0x118 */ public float ByteBeatDrumMixHigh;
        /* 0x11C */ public float ByteBeatSynthMixLow;
        /* 0x120 */ public float ByteBeatSynthMixHigh;
        /* 0x124 */ public float AtlasStationActiveDistance;
        /* 0x128 */ public float MiniStationActiveDistance;
        /* 0x12C */ public float PlayerDepthUnderwaterMax;
        /* 0x130 */ public float PlayerLowerOffsetEmitterMul;
        /* 0x134 */ public bool ObstructionEnabled;
        /* 0x138 */ public float ObstructionSmoothTime;
        /* 0x13C */ public float ObstructionValueMax;
        /* 0x140 */ public float ObstructionAuxControlWhenVisible;
        /* 0x144 */ public float ObstructionAuxControlWhenHidden;
        /* 0x148 */ public bool PulseMusicEnabled;
        /* 0x149 */ public bool LockListenerMatrix;
        /* 0x14A */ public bool EnableVRSpecificAudio;
        /* 0x14C */ public float ArmFoleySpeedMultiplier;
        /* 0x150 */ public float ArmWhooshFoleyValueTrigger;
        /* 0x154 */ public float MinSecondsBetweenArmWhooshes;
        /* 0x158 */ public Vector2f CommsChatterFalloffFreighers;
        /* 0x160 */ public Vector2f CommsChatterFalloffShips;
    }
}
