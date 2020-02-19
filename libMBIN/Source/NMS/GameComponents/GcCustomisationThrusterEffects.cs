using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x323651CECEC47053, NameHash = 0x0FD3FA61F96564C04)]
    public class GcCustomisationThrusterEffects : NMSTemplate
    {
        public List<GcCustomisationThrusterEffect> JetpackEffects;
        public List<GcCustomisationShipTrails> ShipEffects;
    }
}
