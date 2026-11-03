namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA34B4817EBEA522B, NameHash = 0x4D074E23)]
    public class GcSavedInteractionDialogData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Dialog;
        [NMS(Index = 0)]
        /* 0x20 */ public ulong Hash;
    }
}
