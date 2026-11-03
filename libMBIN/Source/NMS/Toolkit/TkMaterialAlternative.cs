namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4C13A8FC6D419B8A, NameHash = 0xFC096DCB)]
    public class TkMaterialAlternative : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MaterialAlternativeId;
        [NMS(Index = 1)]
        /* 0x20 */ public GcFilename File;
        // size: 0x4
        public enum TextureTypeEnum : uint {
            Diffuse,
            Normal,
            Ambient,
            Environment,
        }
        [NMS(Index = 0)]
        /* 0x30 */ public TextureTypeEnum TextureType;
    }
}
