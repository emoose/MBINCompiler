using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB594AA5C542C3AFC, NameHash = 0x7C5208D16FF2D5BF)]
    public class GcMissionConditionProductKnown : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Product;
        /* 0x10 */ public GcDefaultMissionProductEnum Default;
        /* 0x14 */ public bool DependentOnSeasonMilestone;
        /* 0x15 */ public bool TakeProductFromSeasonData;
    }
}
