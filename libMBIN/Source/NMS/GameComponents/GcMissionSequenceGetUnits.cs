namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD5B98EE1C3D7717, NameHash = 0xA35414E2)]
    public class GcMissionSequenceGetUnits : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public int Amount;
    }
}
