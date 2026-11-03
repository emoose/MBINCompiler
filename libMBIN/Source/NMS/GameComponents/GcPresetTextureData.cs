namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7BFB09504C3D8F7, NameHash = 0x4BADBACC)]
    public class GcPresetTextureData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x100 Filename;
        [NMS(Index = 0)]
        /* 0x100 */ public NMSString0x80 Name;
    }
}
