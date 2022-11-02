using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x984B3A8CCB3A9E6B, NameHash = 0x9B0B9933C035E4C2)]
    public class GcCustomisationColourPaletteExtraData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductToUnlock;
        /* 0x10 */ public List<NMSString0x20A> TipText;
    }
}
