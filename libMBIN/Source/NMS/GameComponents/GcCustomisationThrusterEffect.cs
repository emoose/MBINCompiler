using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4367D02149119D1A, NameHash = 0xE7EC6E83CB496A6C)]
    public class GcCustomisationThrusterEffect : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public NMSString0x10 LinkedSpecialID;
        /* 0x20 */ public NMSString0x20A Tip;
        /* 0x40 */ public bool AllowedInSeasonalDefaults;
        /* 0x50 */ public Colour LightColour;
        /* 0x60 */ public List<GcCustomisationThrusterJet> Jets;
    }
}
