namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
    }
}


