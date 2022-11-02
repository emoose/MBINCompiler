using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9B0A4EB0F7E5874A, NameHash = 0x7CDF4EDAA0962EA0)]
    public class TkNGuiEditorLayout : NMSTemplate
    {
        [NMS(Size = 0x100)]
        /* 0x0 */ public TkNGuiWindowLayoutData[] Windows;
    }
}
