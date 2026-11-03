using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF190C67CD3C4100E, NameHash = 0xCB70E6C1)]
    public class GcPlanetWaterData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int ColourIndex;
        [NMS(Index = 2)]
        /* 0x4 */ public GcWaterEmissionBehaviourType FoamEmission;
        [NMS(Index = 3)]
        /* 0x8 */ public float Murkyness;
        [NMS(Index = 1)]
        /* 0xC */ public GcWaterEmissionBehaviourType WaterEmission;
    }
}
