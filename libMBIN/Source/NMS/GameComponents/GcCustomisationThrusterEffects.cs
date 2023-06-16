using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD92E980B0061775B, NameHash = 0xFD3FA61F96564C04)]
    public class GcCustomisationThrusterEffects : NMSTemplate
    {
        /* 0x00 */ public List<GcCustomisationThrusterEffect> JetpackEffects;
        /* 0x10 */ public List<GcCustomisationBackpackData> BackpackData;
        /* 0x20 */ public List<GcCustomisationShipTrails> ShipEffects;
        /* 0x30 */ public List<GcCustomisationFreighterEngineEffect> FreighterEngineEffects;
    }
}
