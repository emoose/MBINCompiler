namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C02623F66277A41, NameHash = 0xC9D7FFE72FBDED51)]
    public class GcDiscoveryWorth : NMSTemplate
    {
        // size: 0x3
        public enum RecordEnum {
            Common,
            Uncommon,
            Rare
        }
        [NMS(Size = 0x3, EnumType = typeof(RecordEnum))]
        /* 0x00 */ public int[] Record;
        // size: 0x3
        public enum OnScanEnum {
            Common,
            Uncommon,
            Rare
        }
        [NMS(Size = 0x3, EnumType = typeof(OnScanEnum))]
        /* 0x0C */ public int[] OnScan;
        /* 0x18 */ public int Mission;
    }
}
