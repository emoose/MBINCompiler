using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x7810F7D041306E2D, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        /* 0x0 */ public GcDefaultMissionProductEnum Default;
        /* 0x4 */ public GcProductTableEnum Product;
        /* 0x8 */ public int Amount;
        /* 0xC */ public bool SyncWithMissionFireteam;
        /* 0xD */ public bool ForceSearchFreighterAndChests;
        /* 0xE */ public bool SearchEveryShip;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0xF */ public byte[] EndPadding;
    }
}
