using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, Alignment = 0x8, GUID = 0x0, NameHash = 0x24A11989AE4D41A1)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
        public bool RequiresFullFireteam;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
