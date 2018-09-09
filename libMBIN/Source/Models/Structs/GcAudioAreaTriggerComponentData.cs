namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4B756FC2819E3DF)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate      // size: 0x10
    {
        public GcAudioWwiseEvents EventEnter;
        public GcAudioWwiseEvents EventExit;
        public float EnterDistance;
        public float ExitDistance;
    }
}
