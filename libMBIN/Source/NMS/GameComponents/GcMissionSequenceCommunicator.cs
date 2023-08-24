using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF98009422D647E54, NameHash = 0xD14F8D38E31CAB20)]
    public class GcMissionSequenceCommunicator : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 VRMessage;
        /* 0x100 */ public NMSString0x20A OptionalWaitMessage;
        /* 0x120 */ public NMSString0x80 OSDMessage;
        /* 0x1A0 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x1F8 */ public bool AutoOpen;
        /* 0x1F9 */ public bool UsePulseEncounterObjectAsAttachment;
        /* 0x1FC */ public float MinTimeInSpaceBeforeCall;
        /* 0x200 */ public NMSString0x80 DebugText;
    }
}
