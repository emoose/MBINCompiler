using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC79B5AE623105684, NameHash = 0x8B5246BFCB875531)]
    public class TkNGuiLayoutList : NMSTemplate
    {
        /* 0x0 */ public List<TkNGuiLayoutListData> Layouts;
    }
}
