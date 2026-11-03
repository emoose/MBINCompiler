namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA648311AD6FE2627, NameHash = 0xB75F8AD4)]
    public class GcPaletteData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x40)]
        /* 0x000 */ public Colour[] Colours;
        // size: 0x6
        public enum NumColoursEnum : uint {
            Inactive,
            _1,
            _4,
            _8,
            _16,
            All,
        }
        [NMS(Index = 0)]
        /* 0x400 */ public NumColoursEnum NumColours;
    }
}
