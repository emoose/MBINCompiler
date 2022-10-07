namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC24B357A69A98EB0, NameHash = 0xE4AFCD52DEB8A62F)]
    public class GcGalaxyStarColours : NMSTemplate
    {
        // size: 0x4
        public enum ColourByStarTypeEnum {
            Yellow,
            Green,
            Blue,
            Red
        }
        [NMS(Size = 0x4, EnumType = typeof(ColourByStarTypeEnum))]
        /* 0x0 */ public Colour[] ColourByStarType;
    }
}
