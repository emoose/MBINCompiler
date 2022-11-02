namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E6046F6AA5D0D8B, NameHash = 0x3F4922910DCC54BD)]
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Size = 0x5)]
        /* 0x00 */ public Colour[] Colours;
        [NMS(Size = 0x5)]
        /* 0x50 */ public int[] ColourIndices;
    }
}
