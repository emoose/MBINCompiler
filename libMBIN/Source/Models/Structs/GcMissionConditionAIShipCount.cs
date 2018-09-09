namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x769F8AECB3093B13)]
    public class GcMissionConditionAIShipCount : NMSTemplate
    {
        /* 0x0 */ public GcRealityCommonFactions Type;
        /* 0x4 */ public int Count;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
