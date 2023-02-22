namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B3EF978A93CD288, NameHash = 0xAD03B051106BCE0A)]
    public class GcRewardChangeGlobalMission : NMSTemplate
    {
        // size: 0x4
        public enum GlobalMissionEnum {
            Atlas,
            BlackHole,
            Anomaly,
            Explore,
        }
        /* 0x0 */ public GlobalMissionEnum GlobalMission;
    }
}
