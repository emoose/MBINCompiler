using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9714E938DD430DA8, NameHash = 0x1F9B959A)]
    public class GcCustomisationFreighterEngineEffect : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Colour GlowColour;
        [NMS(Index = 4)]
        /* 0x10 */ public TkModelResource EffectResource;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x20A Tip;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x10 LinkedTechID;
        [NMS(Index = 0)]
        /* 0x70 */ public NMSString0x10 Name;
    }
}
