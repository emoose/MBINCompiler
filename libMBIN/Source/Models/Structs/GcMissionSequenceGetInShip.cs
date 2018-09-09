namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9E2E997085841D42)]
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
    }
}


