namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E5F1E008F7DE744, NameHash = 0x79F9025A)]
    public class GcMissionSequenceProductAmountNeeded : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Item;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 ToBuild;
        [NMS(Index = 3)]
        /* 0x40 */ public bool IsRepair;
    }
}
