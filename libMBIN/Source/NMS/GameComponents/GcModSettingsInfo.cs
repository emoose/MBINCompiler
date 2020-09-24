using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x90, GUID = 0x8FA4CA15521252DB, NameHash = 0xC0CE6220E5E98BD9)]
    public class GcModSettingsInfo : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x80 */ public string Name;
        /* 0x80 */ public ulong ID;
        /* 0x88 */ public ushort LoadOrder;
        /* 0x8C */ public bool Enabled;
        /* 0x8C */ public bool EnabledVR;
    }
}
