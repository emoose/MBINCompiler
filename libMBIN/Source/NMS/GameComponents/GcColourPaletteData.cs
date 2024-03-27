namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99579791A89F2068, NameHash = 0x3F4922910DCC54BD)]
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Size = 0x5)]
        /* 0x00 */ public Colour[] Colours;
        [NMS(Size = 0x5)]
        /* 0x50 */ public int[] ColourIndices;
    }
}
