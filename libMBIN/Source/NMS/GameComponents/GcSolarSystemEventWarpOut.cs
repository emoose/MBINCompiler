namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5444D31859829A3, NameHash = 0x92C0C276)]
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        [NMS(Index = 2, MxmlName = "Warp Interval Range")]
        /* 0x0 */ public Vector2f WarpIntervalRange;
        [NMS(Index = 0)]
        /* 0x8 */ public float Time;
        [NMS(Index = 1)]
        /* 0xC */ public NMSString0x20 SquadName;
    }
}
