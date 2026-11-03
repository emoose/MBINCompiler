namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE9C5BCD0756787E7, NameHash = 0x4ABF5533)]
    public class GcMissionSequenceOpenSettlementBuildingWithScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A ScanEvent;
        [NMS(Index = 5)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x40 */ public VariableSizeString MessageWhenDistant;
        [NMS(Index = 1)]
        /* 0x50 */ public VariableSizeString UpgradeMessage;
        [NMS(Index = 3)]
        /* 0x60 */ public VariableSizeString UpgradeMessageWhenDistant;
    }
}
