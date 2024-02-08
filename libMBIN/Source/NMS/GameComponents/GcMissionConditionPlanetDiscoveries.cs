using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD523F943FA186627, NameHash = 0x792A334D3849EEA1)]
    public class GcMissionConditionPlanetDiscoveries : NMSTemplate
    {
        /* 0x0 */ public GcDiscoveryType DiscoveryType;
        /* 0x4 */ public float PercentDiscovered;
        /* 0x8 */ public bool DeepSearchDoneDiscos;
    }
}
