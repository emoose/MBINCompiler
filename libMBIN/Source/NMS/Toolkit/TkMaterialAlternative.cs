namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE3B091D0EE62D8B6, NameHash = 0xB49AE407F95DCEE4)]
    public class TkMaterialAlternative : NMSTemplate
    {
        // size: 0x4
        public enum TextureTypeEnum : uint {
            Diffuse,
            Normal,
            Ambient,
            Environment,
        }
        /* 0x00 */ public TextureTypeEnum TextureType;
        /* 0x04 */ public NMSString0x80 File;
        /* 0x88 */ public NMSString0x20A MaterialAlternativeId;
    }
}
