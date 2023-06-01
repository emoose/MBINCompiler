namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA408C1BC4EB7A0BD, NameHash = 0x743B54DBF617C58D)]
    public class GcRewardTableItem : NMSTemplate
    {
        /* 0x00 */ public float PercentageChance;
        /* 0x04 */ public NMSString0x40 LabelID;
        /* 0x48 */ public NMSTemplate Reward;
    }
}
