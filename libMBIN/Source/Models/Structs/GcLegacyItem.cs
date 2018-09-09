namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x28, GUID = 0x661046F281F45BC6)]
    public class GcLegacyItem : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string ConvertID;
        
        /* 0x20 */ public float ConvertRatio;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
