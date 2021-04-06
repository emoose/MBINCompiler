using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x0, NameHash = 0x71B7896BF38DAAE4)]
    public class GcAlienPodComponentData : NMSTemplate
    {
        /* 0x00 */ public float AgroRate;
        /* 0x04 */ public float AgroMovement;
        /* 0x08 */ public float AgroMovementRange;
        /* 0x0C */ public float AgroTorch;
        /* 0x10 */ public float AgroTorchRange;
        /* 0x14 */ public float AgroTorchFOV;
        /* 0x18 */ public float AgroThreshold;
        /* 0x1C */ public float AgroSpookValue;
        /* 0x20 */ public float AgroSpookTime;
        /* 0x24 */ public float AgroSpookTimeMin;
        /* 0x28 */ public float AgroSpookTimeMax;
        /* 0x2C */ public float GlowIntensitymin;
        /* 0x30 */ public float GlowIntensityMax;
        /* 0x34 */ public float InstaAgroDistance;
        /* 0x38 */ public float GunfireAgro;
        /* 0x3C */ public float GunfireAgroRange;
    }
}