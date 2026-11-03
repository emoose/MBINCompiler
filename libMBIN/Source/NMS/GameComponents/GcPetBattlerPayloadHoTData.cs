namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47AE4F40AFE21FE7, NameHash = 0xF0E7F646)]
    public class GcPetBattlerPayloadHoTData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool ApplyOnTurnBegin;
        [NMS(Index = 1)]
        /* 0x1 */ public bool ApplyOnTurnEnd;
    }
}
