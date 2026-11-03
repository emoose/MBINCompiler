namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BB1D4161463D21E, NameHash = 0x9D2B4681)]
    public class GcByteBeatJukeboxData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10)]
        /* 0x000 */ public NMSString0x10[] Playlist;
        [NMS(Index = 2)]
        /* 0x100 */ public bool Playing;
        [NMS(Index = 1)]
        /* 0x101 */ public bool Shuffle;
    }
}
