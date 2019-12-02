using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x3A1E69C3CE78B679)]
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
        /* 0xA0 */ public float Unknown0xA0;
        /* 0xA4 */ public int UnknownInt0xA4;
        /* 0xA8 */ public int UnknownInt0xA8;
        /* 0xAC */ public int UnknownInt0xAC;
        /* 0xB0 */ public int UnknownInt0xB0;
        /* 0xB4 */ public float Unknown0xB4;
        /* 0xB8 */ public float Unknown0xB8;
        /* 0xBC */ public float Unknown0xBC;
        /* 0xC0 */ public float Unknown0xC0;
        /* 0xC4 */ public float Unknown0xC4;
        /* 0xC8 */ public float Unknown0xC8;
        /* 0xCC */ public float Unknown0xCC;
        /* 0xD0 */ public float Unknown0xD0;
        /* 0xD4 */ public float Unknown0xD4;
        /* 0xD8 */ public float Unknown0xD8;
        /* 0xDC */ public float Unknown0xDC;
        /* 0xE0 */ public float Unknown0xE0;
        /* 0xE4 */ public float Unknown0xE4;
        /* 0xE8 */ public float AtlasStationActiveDistance;
        /* 0xEC */ public float MiniStationActiveDistance;
        /* 0xF0 */ public float PlayerDepthUnderwaterMax;
        /* 0xF4 */ public float PlayerLowerOffsetEmitterMul;
        /* 0xF8 */ public bool ObstructionEnabled;
        /* 0xFC */ public float ObstructionSmoothTime;
        /* 0x100 */ public float ObstructionValueMax;
        /* 0x104 */ public float ObstructionAuxControlWhenVisible;
        /* 0x108 */ public float ObstructionAuxControlWhenHidden;
        /* 0x10C */ public bool PulseMusicEnabled;
        /* 0x10D */ public bool LockListenerMatrix;
        /* 0x10E */ public bool Unknown0x10E;
        /* 0x110 */ public float Unknown0x110;
        /* 0x114 */ public float Unknown0x114;
        /* 0x118 */ public float Unknown0x118;
        /* 0x11C */ public Vector2f CommsChatterFalloffFreighers;
        /* 0x124 */ public Vector2f CommsChatterFalloffShips;
    }
}
