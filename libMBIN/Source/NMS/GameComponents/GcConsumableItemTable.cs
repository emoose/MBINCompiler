using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F5FF21A31CFDC7D, NameHash = 0xA9AA29AB69917BF0)]
    public class GcConsumableItemTable : NMSTemplate
    {
        /* 0x0 */ public List<GcConsumableItem> Table;
    }
}
