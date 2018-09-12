namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x1A8, GUID = 0x49E1978F3BEA5272)]
    public class GcMissionSequenceGetToExpedition : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        [NMS(Size = 0x80)]
        public string GalaxyMapMessage;
        [NMS(Size = 0x20)]
        public string Event;
        public float CompletionDistance;
        [NMS(Size = 0x80)]
        public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
