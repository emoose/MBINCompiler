using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA9878C86D7BC7C2, NameHash = 0xC9F9F1B2965E5228)]
    public class GcMissionSequenceModifyStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Stat;
        /* 0x10 */ public int Amount;
        /* 0x14 */ public GcStatModifyType ModifyType;
    }
}
