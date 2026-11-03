using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x156A12B9E68945C3, NameHash = 0x8B231872)]
    public class GcMissionSequenceShowHintMessage : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 InventoryHint;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString MessagePadControl;
        [NMS(Index = 2)]
        /* 0x40 */ public VariableSizeString MessageTitle;
        [NMS(Index = 8)]
        /* 0x50 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        [NMS(Index = 5)]
        /* 0x60 */ public float HighPriorityTime;
        [NMS(Index = 4)]
        /* 0x64 */ public float InitialWaitTime;
        [NMS(Index = 6)]
        /* 0x68 */ public float SecondaryWaitTime;
        [NMS(Index = 7)]
        /* 0x6C */ public bool AllowedWhileInDanger;
    }
}
