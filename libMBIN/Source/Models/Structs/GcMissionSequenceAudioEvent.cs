namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceAudioEvent : NMSTemplate      // size: 0x84
    {
        public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
