using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B0A90E3C405BB33, NameHash = 0x409E4BD41C6295C9)]
    public class GcPulseEncounterSpawnFrigateFlyby : NMSTemplate
    {
        /* 0x00 */ public GcFrigateFlybyType FlybyType;
        /* 0x08 */ public NMSString0x20A CommunicatorOSDLocId;
        /* 0x28 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
    }
}
