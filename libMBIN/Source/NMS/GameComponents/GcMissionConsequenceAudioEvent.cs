using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC258B46C92EBDB85, NameHash = 0xDFAC7EA3D5A0F64C)]
    public class GcMissionConsequenceAudioEvent : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x4 */ public bool UseFrontendAudioObject;
    }
}
