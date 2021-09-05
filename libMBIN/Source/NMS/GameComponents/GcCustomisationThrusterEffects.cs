using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x76FEBE26415F7C00, NameHash = 0x0FD3FA61F96564C04)]
    public class GcCustomisationThrusterEffects : NMSTemplate
    {
        public List<GcCustomisationThrusterEffect> JetpackEffects;
        public List<NMSString0x10> SingleJetJetpacks;
        public List<GcCustomisationShipTrails> ShipEffects;
    }
}
