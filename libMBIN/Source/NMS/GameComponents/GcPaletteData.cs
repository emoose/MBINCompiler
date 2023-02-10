namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x424831EA107022FD, NameHash = 0xB66F8D60603D1092)]
    public class GcPaletteData : NMSTemplate
    {
        // size: 0x6
        public enum NumColoursEnum {
            Inactive,
            _1,
            _4,
            _8,
            _16,
            All,
        }
        /* 0x00 */ public NumColoursEnum NumColours;
        [NMS(Size = 0x40)]
        /* 0x10 */ public Colour[] Colours;
    }
}
