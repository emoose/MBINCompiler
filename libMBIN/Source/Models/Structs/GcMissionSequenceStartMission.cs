namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x98)]
    public class GcMissionSequenceStartMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string MissionID;
        /* 0x10 */ public bool MakeCurrent;
        /* 0x11 */ public bool Restart;
        /* 0x12 */ public bool Forced;
        [NMS(Size = 0x80)]
        /* 0x13 */ public string DebugText;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x93 */ public byte[] EndPadding;
    }
}
