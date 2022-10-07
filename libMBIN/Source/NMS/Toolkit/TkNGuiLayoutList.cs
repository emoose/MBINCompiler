using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x50BDF4B763608D81, NameHash = 0x8B5246BFCB875531)]
    public class TkNGuiLayoutList : NMSTemplate
    {
        /* 0x0 */ public List<TkNGuiLayoutListData> Layouts;
    }
}
