using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5523F97E34D31FA, NameHash = 0x1232AC16AD2DF95C)]
    public class GcCreatureCrystalMovementDataParams : NMSTemplate
    {
        /* 0x000 */ public List<GcBiomeSubType> ValidBiomes;
        /* 0x010 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x020 */ public int NumShards;
        /* 0x024 */ public bool UseTerrainAngle;
        /* 0x025 */ public bool ScaleOnAppear;
        /* 0x028 */ public GcAudioWwiseEvents CreationAudio;
        /* 0x02C */ public float SpawnDist;
        /* 0x030 */ public float DespawnDist;
        /* 0x034 */ public float MaxOffset;
        /* 0x038 */ public float MaxOffsetZ;
        /* 0x03C */ public float MaxTilt;
        /* 0x040 */ public float OffsetTilt;
        /* 0x044 */ public float MinScale;
        /* 0x048 */ public float MaxScale;
        /* 0x04C */ public float MinAppearTime;
        /* 0x050 */ public float MaxAppearTime;
        /* 0x054 */ public float AppearOvershoot;
        /* 0x058 */ public float MinDisappearTime;
        /* 0x05C */ public float MaxDisappearTime;
        /* 0x060 */ public float ShowOffset;
        /* 0x064 */ public float HideOffset;
        /* 0x068 */ public float MinShowTime;
        /* 0x06C */ public bool CustomHideCurve;
        /* 0x06D */ public TkCurveType HideCurve;
        /* 0x070 */ public float IdleSpeedModifier;
        /* 0x074 */ public float WalkSpeedModifier;
        /* 0x078 */ public float RunSpeedModifier;
        /* 0x07C */ public float ParticleScale;
        /* 0x080 */ public NMSString0x10 DustEffect;
        /* 0x090 */ public GcAudioWwiseEvents Audio;
        /* 0x094 */ public GcAudioWwiseEvents RetractAudio;
        /* 0x098 */ public GcAudioWwiseEvents MoveStartAudio;
        /* 0x09C */ public GcAudioWwiseEvents MoveStopAudio;
        /* 0x0A0 */ public float DeathFadeStart;
        /* 0x0A4 */ public float DeathFadeTime;
        // size: 0x2
        public enum DeathTypeEnum : uint {
            Explode,
            Drop,
        }
        /* 0x0A8 */ public DeathTypeEnum DeathType;
        // size: 0x2
        public enum SubTypeEnum : uint {
            Crystal,
            Tentacle,
        }
        /* 0x0AC */ public SubTypeEnum SubType;
        /* 0x0B0 */ public NMSString0x20 TentacleStartJoint;
        /* 0x0D0 */ public NMSString0x20 TentacleEndJoint;
        /* 0x0F0 */ public float TentacleSpeed;
        /* 0x0F4 */ public float TentacleChurnSpeed;
        /* 0x0F8 */ public float TentacleIdleLookChance;
        /* 0x0FC */ public float TentacleStretchMin;
        /* 0x100 */ public float TentacleStretchMax;
        /* 0x104 */ public float TentacleMoveSwingAngle;
        /* 0x108 */ public float TentacleWalkSwingSpeed;
        /* 0x10C */ public float TentacleRunSwingSpeed;
        /* 0x110 */ public float TentacleRotationApplyBase;
        /* 0x114 */ public float TentacleRotationApplyTip;
        /* 0x118 */ public float TentacleMoveTimeMin;
        /* 0x11C */ public float TentacleMoveTimeMax;
        /* 0x120 */ public float TentaclePitchRange;
        /* 0x124 */ public float TentacleYawRange;
        /* 0x128 */ public float TentacleRollRange;
    }
}
