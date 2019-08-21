using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x4671E972C5C0AB5F)]
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
        /* 0xA0 */ public float AtlasStationActiveDistance;
        /* 0xA4 */ public float MiniStationActiveDistance;
        /* 0xA8 */ public float PlayerDepthUnderwaterMax;
        /* 0xAC */ public float PlayerLowerOffsetEmitterMul;
        /* 0xB0 */ public bool ObstructionEnabled;
        /* 0xB4 */ public float ObstructionSmoothTime;
        /* 0xB8 */ public float ObstructionValueMax;
        /* 0xBC */ public float ObstructionAuxControlWhenVisible;
        /* 0xC0 */ public float ObstructionAuxControlWhenHidden;
        /* 0xC4 */ public bool PulseMusicEnabled;
        /* 0xC5 */ public bool LockListenerMatrix;
        /* 0xC6 */ public bool Unknown0xC6;
        /* 0xC8 */ public float Unknown0xC8;
        /* 0xCC */ public float Unknown0xCC;
        /* 0xD0 */ public float Unknown0xD0;
        /* 0xD4 */ public Vector2f CommsChatterFalloffFreighers;
        /* 0xDC */ public Vector2f CommsChatterFalloffShips;
    }
}
