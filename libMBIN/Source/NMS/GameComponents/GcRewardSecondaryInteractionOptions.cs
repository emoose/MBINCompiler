using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0558355C87CF116, NameHash = 0x448E93C725811D8E)]
    public class GcRewardSecondaryInteractionOptions : NMSTemplate
    {
        /* 0x0 */ public List<GcAlienPuzzleOption> Options;
    }
}
