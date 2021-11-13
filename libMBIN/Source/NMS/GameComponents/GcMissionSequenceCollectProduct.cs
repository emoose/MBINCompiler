using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x140, GUID = 0x054E0E22E5CC287A, NameHash = 0x139E6194371FE10E)]
    public class GcMissionSequenceCollectProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcDefaultMissionProductEnum Default;
        /* 0x84 */ public GcProductTableEnum Product;
        /* 0x88 */ public int AmountMin;
        /* 0x8C */ public int AmountMax;
        /* 0x90 */ public bool WaitForSelected;
        /* 0x98 */ public NMSString0x10 ForBuild;
        /* 0xA8 */ public NMSString0x10 ForRepair;
        /* 0xB8 */ public bool TeachIfNotKnown;
        /* 0xB9 */ public bool FromNow;
        /* 0xBA */ public bool TakeAmountFromSeasonData;
        /* 0xBB */ public NMSString0x80 DebugText;
    }
}
