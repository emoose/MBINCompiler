namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB4A23D1D214B86E, NameHash = 0xC217A4AF3130299A)]
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        /* 0x00 */ public float Time;
        /* 0x04 */ public NMSString0x20 SquadName;
        /* 0x24 */ public Vector2f WarpIntervalRange;
    }
}
