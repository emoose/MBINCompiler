using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB203D07ED276578F, NameHash = 0xEED656C0)]
    public class GcRewardRepairTech : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 SpecificTechToRepair;
        [NMS(Index = 0)]
        /* 0x10 */ public GcTechnologyCategory Category;
        [NMS(Index = 2)]
        /* 0x14 */ public bool ShowRepairMessage;
    }
}
