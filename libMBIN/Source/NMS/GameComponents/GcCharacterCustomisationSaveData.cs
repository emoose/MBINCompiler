using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0xCFF95D1DE4A528CD)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string SelectedPreset;
        /* 0x10 */ public GcCharacterCustomisationData CustomData;
    }
}
