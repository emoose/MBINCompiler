using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1E8F5FEA4CE3E2D, NameHash = 0x78D4180CEDFDC316)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AnimName;
        /* 0x10 */ public GcPlayerCharacterIKOverrideData Data;
    }
}
