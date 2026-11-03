namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3E7B8DD3B44CAE3, NameHash = 0x6CF9E934)]
    public class GcCharacterCustomisationTextureOptionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A TextureOptionName;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 TextureOptionGroupName;
    }
}
