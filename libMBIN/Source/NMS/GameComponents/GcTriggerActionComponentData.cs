using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2813EFD2D28E870, NameHash = 0x20597571)]
    public class GcTriggerActionComponentData : NMSTemplate
    {
        [NMS(Index = 2, KeyField = "StateID")]
        /* 0x00 */ public HashMap<GcActionTriggerState> States;
        [NMS(Index = 4)]
        /* 0x30 */ public NMSString0x10 PersistentState;
        [NMS(Index = 0)]
        /* 0x40 */ public bool HideModel;
        [NMS(Index = 6)]
        /* 0x41 */ public bool LinkStateToBaseGrid;
        [NMS(Index = 3)]
        /* 0x42 */ public bool Persistent;
        [NMS(Index = 5)]
        /* 0x43 */ public bool ResetShotTimeOnStateChange;
        [NMS(Index = 1)]
        /* 0x44 */ public bool StartInactive;
    }
}
