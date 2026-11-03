using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE491B119DF06F47E, NameHash = 0xDC769B4C)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "EmoteID")]
        /* 0x0 */ public HashMap<GcPlayerEmote> Emotes;
    }
}
