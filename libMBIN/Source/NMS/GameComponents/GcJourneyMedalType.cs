namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7ED4C00E4D97C4B9, NameHash = 0x50569DD5AA245CF0)]
    public class GcJourneyMedalType : NMSTemplate
    {
        // size: 0xA
        public enum MedalTypeEnum {
            Standings,
            Missions,
            Words,
            Systems,
            Sentinels,
            Pirates,
            Plants,
            Units,
            RaceCreatures,
            DistanceWarped,
        }
        /* 0x0 */ public MedalTypeEnum MedalType;
    }
}
