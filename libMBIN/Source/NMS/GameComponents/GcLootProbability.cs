using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x88, GUID = 0xE1523F4E617D82A9, NameHash = 0xFCFB8A97D2A5B063)]
    public class GcLootProbability : NMSTemplate
    {
        /* 0x00 */ public TkModelResource LootModel;
        /* 0x84 */ public float Probability;
    }
}
