using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD703C43065CC9294, NameHash = 0x88EF02AAFC25BCE6)]
    public class GcBehaviourApplyDamageData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueId PlayerDamageType;
        /* 0x28 */ public TkBlackboardDefaultValueFloat Radius;
        /* 0x50 */ public TkBlackboardDefaultValueVector Offset;
    }
}
