namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD729431BCB083995, NameHash = 0x2431FBC75DE4AEB6)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
        // size: 0x2
        public enum MissionUpdateMessageEnum : uint {
            Start,
            End,
        }
        /* 0x00 */ public MissionUpdateMessageEnum MissionUpdateMessage;
        /* 0x08 */ public NMSString0x20A CustomMessageLocID;
        /* 0x28 */ public NMSString0x20A CustomObjectiveLocID;
        /* 0x48 */ public bool SetMissionSelected;
        /* 0x49 */ public bool WaitForMessageOver;
        /* 0x4A */ public bool ShowChangeMissionNotify;
        // size: 0x3
        public enum PlayMusicStingEnum : uint {
            None,
            Start,
            End,
        }
        /* 0x4C */ public PlayMusicStingEnum PlayMusicSting;
        /* 0x50 */ public NMSString0x80 DebugText;
    }
}
