namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */public string MissionID;
    }
}
