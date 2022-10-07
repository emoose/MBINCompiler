using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE69283A76D489484, NameHash = 0x91CAC70AC2792E2A)]
    public class GcResourceElement : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Filename;
        /* 0x080 */ public GcResource ResHandle;
        /* 0x088 */ public GcSeed Seed;
        /* 0x098 */ public NMSString0x200 AltId;
        /* 0x298 */ public TkProceduralTextureChosenOptionList ProceduralTexture;
    }
}
