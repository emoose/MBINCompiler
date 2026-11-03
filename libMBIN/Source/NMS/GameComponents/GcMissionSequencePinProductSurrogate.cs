namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2EE60F13BC2EDFCD, NameHash = 0x38E736CE)]
    public class GcMissionSequencePinProductSurrogate : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ProductID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool TakeProductFromSeasonData;
    }
}
