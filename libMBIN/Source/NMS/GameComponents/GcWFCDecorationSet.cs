using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xD541717FFF061872, NameHash = 0x662BA34BF46DF2DB)]
    public class GcWFCDecorationSet : NMSTemplate
    {
        public List<GcWFCDecorationItem> Items;
    }
}
