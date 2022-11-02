using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x217875B80C13A3, NameHash = 0x78D4180CEDFDC316)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AnimName;
        /* 0x10 */ public GcPlayerCharacterIKOverrideData Data;
    }
}
