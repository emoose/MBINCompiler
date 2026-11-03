namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BA877F44A046D15, NameHash = 0xBBF7B05E)]
    public class GcBasePartAudioLocation : NMSTemplate
    {
        // size: 0x5
        public enum BasePartAudioLocationEnum : uint {
            None,
            Freighter_SpaceWalk,
            Freighter_BioRoom,
            Freighter_TechRoom,
            Freighter_IndustrialRoom,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BasePartAudioLocationEnum BasePartAudioLocation;
    }
}
