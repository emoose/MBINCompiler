using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xA0814A4C94B662F6, NameHash = 0x6F214CFBE5603A0)]
    public class GcScanEventTriggers : NMSTemplate
    {
        /* 0x00 */ public float Range;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public List<NMSString0x10> Triggers;
        /* 0x18 */ public bool AllowRetrigger;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x19 */ public byte[] EndPadding;
    }
}
