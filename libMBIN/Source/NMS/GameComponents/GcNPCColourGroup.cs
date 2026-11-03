using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88A8D54505942F5C, NameHash = 0xF7CC2A10)]
    public class GcNPCColourGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour Primary;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Colour> Secondary;
        [NMS(Index = 0)]
        /* 0x20 */ public float Rarity;
    }
}
