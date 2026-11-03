using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6EE56BC9B1C348C, NameHash = 0x72ADBEFC)]
    public class GcFreighterDungeonParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcDungeonGenerationParams DungeonParams;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x10 Name;
    }
}
