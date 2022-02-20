using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x2E8523CF07C4E10A, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        /* 0x08 */ public NMSString0x10 Product;
        /* 0x18 */ public int Amount;
        /* 0x1C */ public bool SyncWithMissionFireteam;
        /* 0x1D */ public bool ForceSearchFreighterAndChests;
        /* 0x1E */ public bool SearchEveryShip;
        /* 0x1F */ public bool TakeAmountFromSeasonData;
    }
}
