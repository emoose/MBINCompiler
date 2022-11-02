namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC92883A1FA87E877, NameHash = 0x7C5208D16FF2D5BF)]
    public class GcMissionConditionProductKnown : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Product;
        /* 0x10 */ public bool DependentOnSeasonMilestone;
        /* 0x11 */ public bool TakeProductFromSeasonData;
    }
}
