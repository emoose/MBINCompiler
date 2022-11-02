using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1C656BA6ED89F0FB, NameHash = 0xB5E5441084DA383E)]
    public class GcFreighterBaseOptions : NMSTemplate
    {
        /* 0x0 */ public List<GcFreighterBaseOption> FreighterBases;
    }
}
