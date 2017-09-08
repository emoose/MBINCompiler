namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceSetGlobalMission : NMSTemplate
    {
        public int GlobalMission;
        public string[] GlobalMissionValues()
        {
            return new[] { "Atlas", "BlackHole", "Anomaly", "Explore" };
        }
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
