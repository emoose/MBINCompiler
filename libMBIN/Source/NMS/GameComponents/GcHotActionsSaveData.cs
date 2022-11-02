using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA4E06013CFE1AD1, NameHash = 0xE6D4EE849D2F9101)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x0 */ public GcQuickMenuActionSaveData[] KeyActions;
    }
}
