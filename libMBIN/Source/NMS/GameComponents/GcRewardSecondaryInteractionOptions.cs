using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xD737D88456B964F9, NameHash = 0x448E93C725811D8E)]
    public class GcRewardSecondaryInteractionOptions : NMSTemplate
    {
        /* 0x0 */ public List<GcAlienPuzzleOption> Options;
    }
}
