using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcScanEventTriggers : NMSTemplate      // size: 0x20
    {
        public float Range;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<NMSString0x10> Triggers;
        public bool AllowRetrigger;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
