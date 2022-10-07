using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4714DD868638194, NameHash = 0x78D4180CEDFDC316)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AnimName;
        /* 0x10 */ public GcPlayerCharacterIKOverrideData Data;
    }
}
