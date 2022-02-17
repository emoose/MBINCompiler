using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x011C24990F91E192, NameHash = 0xB1B9570C76B5EA49)]
    public class GcFrigateFlybyLayout : NMSTemplate
    {
        /* 0x0 */ public GcFrigateFlybyType FlybyType;
        /* 0x8 */ public List<GcFrigateFlybyOption> Frigate;
    }
}
