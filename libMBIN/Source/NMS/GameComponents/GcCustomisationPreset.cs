using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEBA353186AB2C53, NameHash = 0x6B329F862808895A)]
    public class GcCustomisationPreset : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public GcCharacterCustomisationData Data;
    }
}
