namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B5EF55FB79A7A45, NameHash = 0xA08BAAFBA2B1F0C1)]
    public class GcPhotoCreature : NMSTemplate
    {
        // size: 0x3
        public enum PhotoCreatureTypeEnum {
            Ground,
            Water,
            Air
        }
        /* 0x0 */ public PhotoCreatureTypeEnum PhotoCreatureType;
    }
}
