using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x0B312AEA88F41EBE, NameHash = 0x0F437AEF1AED36067)]
    public class GcCustomisationJetpackThrusterEffects : NMSTemplate
    {
        public List<GcCustomisationThrusterEffect> Effects;
    }
}
