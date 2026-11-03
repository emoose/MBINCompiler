namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x588A5F1AF5884367, NameHash = 0x170F9E7D)]
    public class GcMissionSequenceVehicleScan : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A ScanEventID;
        [NMS(Index = 2)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
    }
}
