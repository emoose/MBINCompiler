namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7179E99BE97BBEA9, NameHash = 0xB6298D20)]
    public class GcMissionSequenceWaitForDepots : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x24 */ public int AmountMin;
    }
}
