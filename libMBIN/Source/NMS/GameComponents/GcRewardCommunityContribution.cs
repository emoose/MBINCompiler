using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8EC14D17EF48A02, NameHash = 0xCE090483FC7B2C67)]
    public class GcRewardCommunityContribution : NMSTemplate
    {
        /* 0x00 */ public GcAtlasSendSubmitContribution Contribution;
        // size: 0x3
        public enum SubmitTypeEnum {
            Value,
            Stat,
            StatsDiff,
        }
        /* 0x08 */ public SubmitTypeEnum SubmitType;
        /* 0x10 */ public NMSString0x10 Stat;
        /* 0x20 */ public NMSString0x10 OtherStat;
    }
}
