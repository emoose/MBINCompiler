namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x371CB145FBCA6D9E, NameHash = 0x2B1E96CF)]
    public class GcAtlasMissionProgressTarget : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Total;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x20 MissionName;
    }
}
