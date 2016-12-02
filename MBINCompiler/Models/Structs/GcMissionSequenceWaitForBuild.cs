namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWaitForBuild : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string MissionID;
        /* 0x10 */ public bool AutoStart;
        /* 0x11 */ public bool RemoveOnCompletion;
        [NMS(Size = 6, Ignore = true)]
        /* 0x12 */ public byte[] Padding12;
        ///* 0x18 */ public List<> StartingConditions;
        ///* 0x28 */ public List<> CancelingConditions;
        ///* 0x38 */ public List<> NotificationSequence;
    }
}
