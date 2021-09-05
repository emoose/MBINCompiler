using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x36C2A10293DAE104, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        /* 0x0 */ public GcDefaultMissionProductEnum Default;
        /* 0x4 */ public GcProductTableEnum Product;
        /* 0x8 */ public int Amount;
        /* 0xC */ public bool SyncWithMissionFireteam;
        /* 0xD */ public bool ForceSearchFreighterAndChests;
        /* 0xE */ public bool SearchEveryShip;
    }
}
