namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceCommunicator : NMSTemplate      // size: 0x1B0
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string OSTMessage;
        /* 0x100 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x128 */ public bool AutoOpen;
        [NMS(Size = 0x80)]
        /* 0x129 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1A9 */ public byte[] EndPadding;
    }
}
