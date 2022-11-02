using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60D197256CB6B77, NameHash = 0xC5B9CCD1978B8755)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SelectedPreset;
        /* 0x10 */ public GcCharacterCustomisationData CustomData;
    }
}
