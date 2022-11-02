using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A9750775C6B324F, NameHash = 0xB6947F6F9E247CD4)]
    public class GcPlayerTitleData : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerTitle> Titles;
    }
}
