using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x422033583BC1AAA2, NameHash = 0x6597D4E975E02DA7)]
    public class GcMissionConditionRefinerHasOutput : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string OutputProduct;
        public int OutputAmount;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
