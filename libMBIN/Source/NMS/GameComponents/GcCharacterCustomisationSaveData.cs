using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4049DBF9FF79AAD5, NameHash = 0xC5B9CCD1978B8755)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SelectedPreset;
        /* 0x10 */ public GcCharacterCustomisationData CustomData;
    }
}
