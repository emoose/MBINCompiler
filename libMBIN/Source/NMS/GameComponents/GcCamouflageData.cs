using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89FA7100747D117F, NameHash = 0x4548C9A8732E084E)]
    public class GcCamouflageData : NMSTemplate
    {
        /* 0x00 */ public TkMaterialResource CamouflageMaterial;
        /* 0x84 */ public float DissolveTime;
        /* 0x88 */ public float DissolveTimeVR;
        /* 0x8C */ public float FadeOutTime;
        /* 0x90 */ public float FadeInTime;
        /* 0x94 */ public float LowQualityFresnelModifier;
        /* 0x98 */ public float LowQualityBrightnessMultiplier;
    }
}
