using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC14802260D6660, NameHash = 0xE6D4EE849D2F9101)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x0 */ public GcQuickMenuActionSaveData[] KeyActions;
    }
}
