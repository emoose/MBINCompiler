using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1, GUID = 0x91BA48EF1AD4BAD7, NameHash = 0xC7B4163B07D3C68)]
    public class GcMissionConditionHasSettlement : NMSTemplate
    {
        public bool MustBeInSettlement;
    }
}
