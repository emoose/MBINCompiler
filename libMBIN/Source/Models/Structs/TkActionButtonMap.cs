using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class TkActionButtonMap : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ActionId;
        /* 0x10 */ public bool ScaleToFitFont;
        /* 0x14 */ public int PadButtonId;      // TkInputEnum
        /* 0x18 */ public List<TkPlatformButtonPair> Platforms;
    }
}
