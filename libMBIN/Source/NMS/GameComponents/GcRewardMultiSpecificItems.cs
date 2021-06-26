using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x6F3AFF718EB4F2ED, NameHash = 0x26C3924987148B0B)]
    public class GcRewardMultiSpecificItems : NMSTemplate
    {
        public List<GcMultiSpecificItemEntry> Items;
    }
}
