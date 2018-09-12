namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A6EC1041FE8F1AF9)]
    public class GcGalaxyStarColours : NMSTemplate      // size: 0x40
    {
        [NMS(Size = 0x4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        public Colour[] ColourByStarType;
    }
}
