namespace libMBIN.Models.Structs
{
    [NMS(Size = 10, Alignment = 0x8)]
    public class GcMissionConditionIsMissionInProgress : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public string MissionID;
    }
}
