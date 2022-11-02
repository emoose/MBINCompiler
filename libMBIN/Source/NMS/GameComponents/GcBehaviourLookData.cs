using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22F0F8BD4ECE4E0F, NameHash = 0x79CECC228E0EBC79)]
    public class GcBehaviourLookData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LookTargetKey;
        /* 0x10 */ public bool LookWhenBeyondMaxAngle;
        /* 0x18 */ public TkBlackboardDefaultValueBool FocusOnTarget;
        /* 0x38 */ public TkBlackboardDefaultValueBool RelaxedLook;
        /* 0x58 */ public TkBlackboardDefaultValueBool CanLook;
    }
}
