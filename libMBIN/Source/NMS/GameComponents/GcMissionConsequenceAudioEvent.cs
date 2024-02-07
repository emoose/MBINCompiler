using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C624A46D62D509D, NameHash = 0xDFAC7EA3D5A0F64C)]
    public class GcMissionConsequenceAudioEvent : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x4 */ public bool UseFrontendAudioObject;
    }
}
