namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F97309D7C8E1647, NameHash = 0xAD03B051106BCE0A)]
    public class GcRewardChangeGlobalMission : NMSTemplate
    {
        // size: 0x4
        public enum GlobalMissionEnum {
            Atlas,
            BlackHole,
            Anomaly,
            Explore
        }
        /* 0x0 */ public GlobalMissionEnum GlobalMission;
    }
}
