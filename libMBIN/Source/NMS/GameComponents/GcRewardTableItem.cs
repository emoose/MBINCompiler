namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B558C9BA03F4E5, NameHash = 0xCEEDBB60)]
    public class GcRewardTableItem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString LabelID;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSTemplate Reward;
        [NMS(Index = 0)]
        /* 0x20 */ public float PercentageChance;
    }
}
