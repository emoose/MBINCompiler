namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcCostProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;

        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;
        /* 0x18 */ public int Amount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
