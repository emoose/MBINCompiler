using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string MissionName;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string MissionDescription;
        [NMS(Size = 0x10)]
        /* 0x40 */ public string MissionID;
        /* 0x50 */ public bool AutoStart;
        /* 0x51 */ public bool RemoveOnCompletion;
        [NMS(Size = 6, Ignore = true)]
        /* 0x52 */ public byte[] Padding12;
        /* 0x58 */ public List<NMSTemplate> StartingConditions;
        /* 0x68 */ public List<NMSTemplate> CancelingConditions;
        /* 0x78 */ public List<NMSTemplate> NotificationSequence;
    }
}
