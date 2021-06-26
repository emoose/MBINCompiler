using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0xCA0B0AE310E6D309, NameHash = 0x754263974A1E2442)]
    public class GcMissionConditionHasProcProduct : NMSTemplate
    {
        /* 0x0 */ public GcProceduralProductCategory ProcProduct;
        /* 0x4 */ public bool ForceSearchFreighterAndChests;
        /* 0x5 */ public bool SearchEveryShip;
    }
}
