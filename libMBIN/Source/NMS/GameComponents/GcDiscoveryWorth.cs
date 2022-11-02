namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9EC16DD6EC58CC7, NameHash = 0xC9D7FFE72FBDED51)]
    public class GcDiscoveryWorth : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x00 */ public int[] Record;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0C */ public int[] OnScan;
        /* 0x18 */ public int Mission;
    }
}
