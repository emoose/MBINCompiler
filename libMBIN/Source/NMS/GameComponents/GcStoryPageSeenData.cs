namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC34067C295D28B4A, NameHash = 0x5338F448)]
    public class GcStoryPageSeenData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int LastSeenEntryIdx;
        [NMS(Index = 0)]
        /* 0x4 */ public int PageIdx;
    }
}
