using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xCCB13805BC4EFC10, NameHash = 0x8F7F2EBCF9C0EDF)]
    public class GcColouriseComponentData : NMSTemplate
    {
        /* 0x00 */ public Colour PrimaryColour;
        /* 0x10 */ public Colour SecondaryColour;
    }
}
