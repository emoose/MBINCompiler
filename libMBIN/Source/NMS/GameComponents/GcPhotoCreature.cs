namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFD13BEA7BB1992F, NameHash = 0xA08BAAFBA2B1F0C1)]
    public class GcPhotoCreature : NMSTemplate
    {
        // size: 0x3
        public enum PhotoCreatureTypeEnum : uint {
            Ground,
            Water,
            Air,
        }
        /* 0x0 */ public PhotoCreatureTypeEnum PhotoCreatureType;
    }
}
