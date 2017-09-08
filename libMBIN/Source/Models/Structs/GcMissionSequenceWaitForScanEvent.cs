namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate        // size: 0x228
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string GalaxyMapMessage;
        [NMS(Size = 0x20)]
        /* 0x100 */ public string Event;
        /* 0x120 */ public float Timeout;
        /* 0x124 */ public bool DistanceTimeout;
        [NMS(Size = 0x80, Ignore = true)]
        /* 0x125 */ public string TimeoutOSD;
        [NMS(Size = 0x80, Ignore = true)]
        /* 0x1A5 */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
