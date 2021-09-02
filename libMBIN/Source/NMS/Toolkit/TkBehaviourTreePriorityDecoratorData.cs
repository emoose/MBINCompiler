using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x50, GUID = 0x6ED236B5392FB6A, NameHash = 0x8941C010DEA33BFC)]
    public class TkBehaviourTreePriorityDecoratorData : NMSTemplate
    {
        public NMSTemplate Child;
    }
}
