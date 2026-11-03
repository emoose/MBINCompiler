using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF228E53E2EF19A53, NameHash = 0x435998E0)]
    public class GcFreighterBaseOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterBaseOption> FreighterBases;
    }
}
