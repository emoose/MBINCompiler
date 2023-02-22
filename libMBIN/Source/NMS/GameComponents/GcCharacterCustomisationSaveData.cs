using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34E14CB75FB4264A, NameHash = 0xC5B9CCD1978B8755)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SelectedPreset;
        /* 0x10 */ public GcCharacterCustomisationData CustomData;
    }
}
