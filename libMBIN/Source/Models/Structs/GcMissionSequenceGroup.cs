using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceGroup : NMSTemplate       // size: 0x1D8
    {
        /* 0x000 */ public bool Silent;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        /* 0x004 */ public TkTextureResource Icon;
        /* 0x088 */ public GcMissionPageHint PageHint;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x08C */ public byte[] Padding8C;
        [NMS(Size = 0x20)]
        /* 0x090 */ public string PageDataLocID;
        [NMS(Size = 0x80)]
        /* 0x0B0 */ public string DebugText;
        [NMS(Size = 0x20)]
        /* 0x130 */ public string ObjectiveID;
        [NMS(Size = 0x20)]
        /* 0x150 */ public string ObjectiveTipID;
        /* 0x170 */ public bool HasCategoryOverride;
        /* 0x174 */ public GcMissionCategory OverrideCategory;
        /* 0x178 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x179 */ public byte[] Padding179;
        [NMS(Size = 0x20)]
        /* 0x180 */ public string PrefixTitleText;
        /* 0x1A0 */ public GcMissionConditionTest ConditionTest;

        /* 0x1A4 */ public int RepeatLogic;
        public string[] RepeatLogicValues()
        {
            return new[] { "None", "Loop", "RestartOnConditionFail" };
        }
        /* 0x1A8 */ public List<NMSTemplate> Conditions;
        /* 0x1B8 */ public List<NMSTemplate> Consequences;
        /* 0x1C8 */ public List<NMSTemplate> NotificationSequence;
    }
}
