using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x4FDBDEDFBA4CEB35)]
    public class TkNGuiTextStyle : NMSTemplate
    {
        public TkNGuiTextStyleData Default;
        public TkNGuiTextStyleData Highlight;
        public TkNGuiTextStyleData Active;
    }
}
