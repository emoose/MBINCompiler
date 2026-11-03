namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3812D8CDC3F1FBD9, NameHash = 0x5206D5AE)]
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5)]
        /* 0x00 */ public Colour[] Colours;
        [NMS(Index = 1, Size = 0x5)]
        /* 0x50 */ public int[] ColourIndices;
    }
}
