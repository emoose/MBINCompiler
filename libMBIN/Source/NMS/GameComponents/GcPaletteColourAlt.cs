namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x334312A1462E54C6, NameHash = 0x8BC80049)]
    public class GcPaletteColourAlt : NMSTemplate
    {
        // size: 0x8
        public enum ColourAltNewEnum : uint {
            Primary,
            Secondary,
            Alternative3,
            Alternative4,
            Alternative5,
            Unique,
            MatchGround,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ColourAltNewEnum ColourAltNew;
    }
}
