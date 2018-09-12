namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0FEC2385BD37C76F6)]
    public class GcRewardMissionOverride : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
