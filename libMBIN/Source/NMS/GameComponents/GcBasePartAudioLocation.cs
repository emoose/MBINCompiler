namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C0B10C2C39FB59A, NameHash = 0x832159F5794C47D5)]
    public class GcBasePartAudioLocation : NMSTemplate
    {
        // size: 0x5
        public enum BasePartAudioLocationEnum {
            None,
            Freighter_SpaceWalk,
            Freighter_BioRoom,
            Freighter_TechRoom,
            Freighter_IndustrialRoom
        }
        /* 0x0 */ public BasePartAudioLocationEnum BasePartAudioLocation;
    }
}
