namespace MBINCompiler.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcRewardTableItem : NMSTemplate        // size: 0x90
    {
        /* 0x00 */ public float PercentageChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSTemplate Reward;
        [NMS(Size = 0x40)]
        /* 0x50 */ public string LabelID;
    }
}
