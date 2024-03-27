using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1B74654E438150, NameHash = 0x381A76E400DE3EE7)]
    public class GcCameraShakeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float TimeStart;
        /* 0x14 */ public float TotalTime;
        /* 0x18 */ public float DecayRate;
        /* 0x1C */ public float StrengthScale;
        /* 0x20 */ public float ThirdPersonDamp;
        /* 0x24 */ public float VRStrength;
        /* 0x28 */ public GcCameraShakeCapturedData CapturedData;
        /* 0x40 */ public GcCameraShakeMechanicalData MechanicalData;
        /* 0xB0 */ public float FovStrength;
        /* 0xB4 */ public float FovFrequency;
    }
}
