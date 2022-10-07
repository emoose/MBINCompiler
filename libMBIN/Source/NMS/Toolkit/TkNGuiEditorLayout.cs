using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x55A2F338BBCB7BA, NameHash = 0x7CDF4EDAA0962EA0)]
    public class TkNGuiEditorLayout : NMSTemplate
    {
        [NMS(Size = 0x100)]
        /* 0x0 */ public TkNGuiWindowLayoutData[] Windows;
    }
}
