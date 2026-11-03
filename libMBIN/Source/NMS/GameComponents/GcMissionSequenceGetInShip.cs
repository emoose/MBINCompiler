namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7FE7973BBADE83E5, NameHash = 0x5C890E29)]
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
    }
}
