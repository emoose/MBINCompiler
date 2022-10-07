using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB87B58B8B1F76870, NameHash = 0x2E19620D3EC8F3AC)]
    public class GcNPCColourGroup : NMSTemplate
    {
        /* 0x00 */ public float Rarity;
        /* 0x10 */ public Colour Primary;
        /* 0x20 */ public List<Colour> Secondary;
    }
}
