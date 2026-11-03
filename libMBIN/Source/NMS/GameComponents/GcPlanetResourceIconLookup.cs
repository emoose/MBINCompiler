using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30F27967984C829F, NameHash = 0x70BD77E4)]
    public class GcPlanetResourceIconLookup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x18 */ public TkTextureResource IconBinocs;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 ID;
    }
}
