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
        /* 0xA0 */ public int UnknownInt0xA0;
        /* 0xA4 */ public float Unknown0xA4;
        /* 0xA8 */ public float Unknown0xA8;
        /* 0xAC */ public int UnknownInt0xAC;
        /* 0xB0 */ public int UnknownInt0xB0;
        /* 0xB4 */ public int UnknownInt0xB4;
        /* 0xB8 */ public int UnknownInt0xB8;
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
        /* 0xE8 */ public float Unknown0xE8;
        /* 0xEC */ public float Unknown0xEC;
        /* 0xF0 */ public float Unknown0xF0;
        /* 0xF4 */ public float Unknown0xF4;
        /* 0xF8 */ public float Unknown0xF8;
        /* 0xFC */ public float Unknown0xFC;
        /* 0x100 */ public float Unknown0x100;
        /* 0x104 */ public float Unknown0x104;
        /* 0x108 */ public float Unknown0x108;
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
        /* 0x132 */ public bool Unknown0x132;
        /* 0x134 */ public float Unknown0x134;
        /* 0x138 */ public float Unknown0x138;
        /* 0x13C */ public float Unknown0x13C;
        /* 0x140 */ public Vector2f CommsChatterFalloffFreighers;
        /* 0x148 */ public Vector2f CommsChatterFalloffShips;
    }
}
