namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D59334CF9C7FE96, NameHash = 0xF2A93C95)]
    public class GcMissionSequenceSuppressMarkers : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool Suppressed;
        [NMS(Index = 1)]
        /* 0x1 */ public bool SuppressedAfterNextWarp;
    }
}
