namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string MissionID;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
    }
}
