namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x2, GUID = 0x23EDE32E8B69B0AE)]
    public class GcMissionConditionOnOtherSideOfPortal : NMSTemplate
    {
        /* 0x0 */ public bool TestForRegularPortal;
        /* 0x1 */ public bool TestForStoryPortal;
    }
}
