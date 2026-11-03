namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1423264B1A8B2E0, NameHash = 0x921C155)]
    public class GcPhotoCreature : NMSTemplate
    {
        // size: 0x3
        public enum PhotoCreatureTypeEnum : uint {
            Ground,
            Water,
            Air,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PhotoCreatureTypeEnum PhotoCreatureType;
    }
}
