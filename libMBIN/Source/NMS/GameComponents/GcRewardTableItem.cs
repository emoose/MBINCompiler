namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA9F3918572932CA, NameHash = 0x743B54DBF617C58D)]
    public class GcRewardTableItem : NMSTemplate
    {
        /* 0x00 */ public float PercentageChance;
        /* 0x08 */ public NMSTemplate Reward;
        /* 0x58 */ public NMSString0x40 LabelID;
    }
}
