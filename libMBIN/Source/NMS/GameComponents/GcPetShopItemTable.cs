using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA788EBCC948F4581, NameHash = 0xBEC9AFBA)]
    public class GcPetShopItemTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetShopItem> Items;
    }
}
