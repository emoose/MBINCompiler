namespace libMBIN.Models.Structs
{
    public class GcMissionConditionCanReceiveReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
