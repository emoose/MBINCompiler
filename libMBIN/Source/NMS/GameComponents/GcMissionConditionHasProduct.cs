using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x35FA5512F120377A, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        /* 0x0 */ public GcDefaultMissionProductEnum Default;
        /* 0x4 */ public GcProductTableEnum Product;
        /* 0x8 */ public int Amount;
        /* 0xC */ public bool SyncWithMissionFireteam;
        /* 0xD */ public bool ForceSearchFreighterAndChests;
        /* 0xE */ public bool SearchEveryShip;
        /* 0xF */ public bool TakeAmountFromSeasonData;
    }
}
