namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEE2D68A0ACD6454, NameHash = 0xAD8C5D131CC2AD70)]
    public class GcMissionConditionNearRobotSite : NMSTemplate
    {
        /* 0x0 */ public float Distance;
        /* 0x4 */ public bool RequireNPCs;
        /* 0x5 */ public bool RequireRevealTech;
    }
}
