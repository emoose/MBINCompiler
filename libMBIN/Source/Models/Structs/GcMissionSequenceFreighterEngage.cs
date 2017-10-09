namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionSequenceFreighterEngage : NMSTemplate      // size: 0x180
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
