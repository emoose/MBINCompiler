using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7E43BD26D260E8E, NameHash = 0x754263974A1E2442)]
    public class GcMissionConditionHasProcProduct : NMSTemplate
    {
        /* 0x0 */ public GcProceduralProductCategory ProcProduct;
        /* 0x4 */ public bool ForceSearchFreighterAndChests;
        /* 0x5 */ public bool SearchEveryShip;
    }
}
